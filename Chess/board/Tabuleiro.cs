using System;

namespace board
{
    internal class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            Pecas = new Peca[linha, coluna];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca Peca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistsPeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }


        public void ColocarPeca(Peca p, Posicao pos)
        {
            if(ExistsPeca(pos))
            {
                throw new TabException($"Já existe uma peça na Linha {pos.Linha} e Coluna {pos.Coluna}");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linha || pos.Coluna < 0 || pos.Coluna >= Coluna)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabException($"Posição: Linha {pos.Linha} e Coluna {pos.Coluna} é inválida");
            }
        }
    }
}
