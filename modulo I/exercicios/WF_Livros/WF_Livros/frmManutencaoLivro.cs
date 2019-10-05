using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Livros
{
    public partial class frmManutencaoLivro : Form
    {
        public Livro LivroManutencao { get; private set; }

        public frmManutencaoLivro()
        {
            InitializeComponent();
            
            Livros = new List<Livro>();
        }

        public List<Livro> Livros { get; set; }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            LivroManutencao = new Livro
            {
                Id = guid.new;
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                NumeroPaginas = Convert.ToInt32(nmNumeroPaginas.Value),
                DataLancamento = dtDataLancamento.Value
            };
            Close();
        }

        public void PreencherLivro(Livro livro)
        {
            txtId.Text = Convert.ToString(livro.Id);
            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            dtDataLancamento.Value = livro.DataLancamento;
            nmNumeroPaginas.Value = livro.NumeroPaginas;
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
