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
    public partial class frmListagem : Form
    {
        public frmListagem()
        {
            InitializeComponent();
            Initialize();
        }

        public List<Livro> Livros { get; set; }

        private void Initialize()
        {
            Livros = new List<Livro>();
            gdLivro.AutoGenerateColumns = false;

            Livros.Add(new Livro()
            {
                Id = 1,
                Titulo = "Titulo1" ,
                Autor = "Autor1",
                NumeroPaginas = 10,
                DataLancamento = DateTime.Now.AddDays(-10),
            });

            Livros.Add(new Livro()
            {
                Id = 2,
                Titulo = "Titulo2",
                Autor = "Autor2",
                NumeroPaginas = 20,
                DataLancamento = DateTime.Now.AddDays(-20),
            });

            Livros.Add(new Livro()
            {
                Id = 3,
                Titulo = "Titulo3",
                Autor = "Autor3",
                NumeroPaginas = 30,
                DataLancamento = DateTime.Now.AddDays(-30),
            });

            Livros.Add(new Livro()
            {
                Id = 4,
                Titulo = "Titulo4",
                Autor = "Autor4",
                NumeroPaginas = 40,
                DataLancamento = DateTime.Now.AddDays(-40),
            });

            gdLivro.DataSource = Livros;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmManutencaoLivro frm = new frmManutencaoLivro();
            frm.Show();

            Livros.Add(frm.LivroManutencao);

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            gdLivro.DataSource = null;
            gdLivro.DataSource = Livros.OrderBy(a=>a.DataLancamento).ToList();
        }

        private void dgLivro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Livro livro = (Livro)gdLivro.Rows[e.RowIndex].DataBoundItem;

            frmManutencaoLivro frm = new frmManutencaoLivro();
            frm.PreencherLivro(livro);
            frm.Show();
            AtualizarGrid();
        }

        private void dgLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //MessageBox.Show(gdLivro.Columns[e.ColumnIndex].Name);
            if (gdLivro.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                Livro livro = (Livro)gdLivro.Rows[e.RowIndex].DataBoundItem;

                frmManutencaoLivro frm = new frmManutencaoLivro();
                frm.PreencherLivro(livro);
                frm.Show();
                AtualizarGrid();
            }

            else if (gdLivro.Columns[e.ColumnIndex].Name == "btnApagar")
            {
                Livro itemSelecionado = (Livro)gdLivro.Rows[e.RowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show("Deseja apagar o item?", "Remover", 
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    Livros.Remove(itemSelecionado);
                    AtualizarGrid();
                }

            }


        }
    }
}
