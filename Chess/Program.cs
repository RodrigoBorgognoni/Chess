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
                PosicaoXadrez pos = new PosicaoXadrez('a', 1);
                Console.WriteLine(pos);
                Console.WriteLine(pos.ToPosicao());
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.ColocarPeca(new Torre(Cor.Preto, tab), new Posicao(0, 0));
                //tab.ColocarPeca(new Torre(Cor.Preto, tab), new Posicao(1, 3));
                //tab.ColocarPeca(new Rei(Cor.Preto, tab), new Posicao(2, 4));
                

                //Tela.ImprimirTab(tab);



                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
