using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezConsole.Tabuleiro
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Conluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Conluna = coluna;
        }

        public override string ToString()
        {
            return Linha + ", " + Conluna;
        }
    }
}
