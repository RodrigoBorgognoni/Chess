using System;
using board;

namespace Chess
{
    internal class Tela
    {
        public static void ImprimirTab(Tabuleiro tab)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < tab.Linha; i++)
            {
                Console.Write("    " + (8 - i) + "  ");
                for (int j = 0; j < tab.Coluna; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                        ImprimirPeca(tab.Peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("                               ");
            Console.WriteLine("        a  b  c  d  e  f  g  h ");
        }

        public static void ImprimirPeca(Peca peca)
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
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(peca + " ");
                Console.ForegroundColor = aux;
            }
        }    
    }
}
