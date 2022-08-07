namespace board
{
    internal class Position : Board
    {
       public Position (int linha, int coluna) : base(linha, coluna)
        {
        }

        public override string ToString()
        {
            return $"{Linha}, {Coluna}";
        }
    }
}
