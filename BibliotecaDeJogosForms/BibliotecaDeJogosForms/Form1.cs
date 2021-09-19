using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeJogosForms.Classes;
namespace BibliotecaDeJogosForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            String titulo = textTitulo.Text;
            String genero = textGenero.Text;
            String lancamento = textLancamento.Text;
            String maxJogadores = textJogadores.Text;

            Jogo jogo = new Jogo(titulo, genero, lancamento, maxJogadores);
        }
    }
}
