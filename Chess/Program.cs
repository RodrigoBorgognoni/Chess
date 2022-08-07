 using System;
using board;
using chess;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(Cor.Amarelo, tab), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Amarelo, tab), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(Cor.Amarelo, tab), new Posicao(2, 4));

            Tela.ImprimirTab(tab);

            Console.ReadLine();
        }
    }
}
