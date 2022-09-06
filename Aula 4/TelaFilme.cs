using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_4
{
    public partial class TelaFilme : Form
    {
        public TelaFilme()
        {
            InitializeComponent();
        }

        Filme f = new Filme(); // instanciando objeto
        Filme[] vet = new Filme[5]; //declaração de vetor de objetos
        int i = 0;
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(i==5)
            {
                MessageBox.Show("Não foi possível gravar!!");
            }
            else
            {
                f.Titulo = textTitulo.Text;
                f.Classificacao = textClassifcacao.Text;
                f.Genero = textGenero.Text;
                f.Sinopse = textSinopse.Text;
                vet[i] = f;
                i++;
            }
        }
    }
}
