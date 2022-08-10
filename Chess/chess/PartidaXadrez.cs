using System;
using board;

namespace chess
{
    internal class PartidaXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            ColocarPeca();
            terminada = false;
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncremetarQtdMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);

        }

        private void ColocarPeca()
        {
            tab.ColocarPeca(new Torre(Cor.Branco, tab), new PosicaoXadrez('a', 1).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Branco, tab), new PosicaoXadrez('h', 1).ToPosicao());
            tab.ColocarPeca(new Rei(Cor.Branco, tab), new PosicaoXadrez('d', 1).ToPosicao());

            tab.ColocarPeca(new Torre(Cor.Preto, tab), new PosicaoXadrez('a', 8).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Preto, tab), new PosicaoXadrez('h', 8).ToPosicao());
            tab.ColocarPeca(new Rei(Cor.Preto, tab), new PosicaoXadrez('d', 8).ToPosicao());
        }
    }
}
