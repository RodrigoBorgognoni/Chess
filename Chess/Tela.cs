using System;
using board;
using chess;

namespace Chess
{
    internal class Tela
    {
        public static void ImprimirTab(Tabuleiro tab)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.Linha; i++)
            {
                Console.Write("    " + (8 - i) + "  ");
                for (int j = 0; j < tab.Coluna; j++)
                {
                    ImprimirPeca(tab.Peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("                               ");
            Console.WriteLine("        a  b  c  d  e  f  g  h ");
            Console.WriteLine("                               ");
        }

        public static void ImprimirTab(Tabuleiro tab, bool[,] posicaopossivel)
        {
            ConsoleColor fundooriginal = Console.BackgroundColor;
            ConsoleColor fundoalt = ConsoleColor.DarkRed;

            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.Linha; i++)
            {
                Console.Write("    " + (8 - i) + "  ");
                for (int j = 0; j < tab.Coluna; j++)
                {
                    if (posicaopossivel[i, j])
                    {
                        Console.BackgroundColor = fundoalt;
                    }
                    else
                    {
                        Console.BackgroundColor = fundooriginal;
                    }
                    ImprimirPeca(tab.Peca(i, j));
                    Console.BackgroundColor = fundooriginal;
                }
                Console.WriteLine();
                Console.BackgroundColor = fundooriginal;
            }
            Console.WriteLine("                               ");
            Console.WriteLine("        a  b  c  d  e  f  g  h ");
            Console.WriteLine("                               ");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write(" - ");
            }
            else
            {
                if (peca.Cor == Cor.Branco)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(peca + " ");
                    Console.ForegroundColor = aux;
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca + " ");
                    Console.ForegroundColor = aux;
                }
            }
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1].ToString());

            return new PosicaoXadrez(coluna, linha);
        }
    }
}
