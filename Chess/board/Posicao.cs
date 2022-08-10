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
        public void DefinirValores(int linha, int coluna)
        { 
            Linha = linha;
            Coluna = coluna;
        }
    }
}
