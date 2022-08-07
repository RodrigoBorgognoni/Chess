namespace board
{
    internal class Board
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Piece[,] Piece;

        public Board(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            Piece = new Piece[linha, coluna];
        }
    }
}
