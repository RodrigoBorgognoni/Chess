 using System;
using board;
using chess;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preto, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preto, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Cor.Preto, tab), new Posicao(2, 4));

                tab.ColocarPeca(new Torre(Cor.Branco, tab), new Posicao(3, 5));

                Tela.ImprimirTab(tab);

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
