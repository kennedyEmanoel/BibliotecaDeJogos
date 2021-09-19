using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeJogosForms.Classes
{
    class Jogo
    {
        private string titulo { get; set; }
        private string genero { get; set; }
        private string lancamento { get; set; }
        private string maxJogadores { get; set; }

        public Jogo(string titulo, string genero, string lancamento, string maxJogadores)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.lancamento = lancamento;
            this.maxJogadores = maxJogadores;
        }
    }
}
