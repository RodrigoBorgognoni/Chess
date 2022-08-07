namespace board
{
    internal class Posicao : Tabuleiro
    {
       public Posicao (int linha, int coluna) : base(linha, coluna)
        {
        }

        public override string ToString()
        {
            return $"{Linha}, {Coluna}";
        }
    }
}
