﻿using ConsoleApp2.tabuleiro;
using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor{ get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab,Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            qtdMovimentos = 0;
        }

    }
}
