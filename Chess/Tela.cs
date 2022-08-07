using System;
using board;

namespace Chess
{
    internal class Tela
    {
        public static void ImprimirTab(Tabuleiro board)
        {

            //board.ColorBack();

            for (int i = 0; i < board.Linha; i++)
            {
                for (int j = 0; j < board.Coluna; j++)
                {
                    if (board.Peca(i, j) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    Console.Write($"{board.Peca(i,j)} ");
                }
                Console.WriteLine();
            }
            
        }

        
    }
}
