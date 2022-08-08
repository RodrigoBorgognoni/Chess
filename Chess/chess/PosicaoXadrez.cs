using board;

namespace chess
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            //converte a posição do xadrez para a posiçao da matriz. Ex: linha 3 do xadrez
            // é a linha 5 da matriz. 8 - 3(linha) = 5
            //Char a é o numero inteiro 97 na tabela ASCII ou seja, a-a = 97-97 = 0
            //b = 98. b-a = 98-97 = 1
            return new Posicao(8 - Linha, Coluna - 'a');
        }
        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }
    }
}
