using System;
using System.Windows.Forms;
using _232017.Models;

namespace _232017.Views
{
    public partial class FrmCategorias : Form
    {
        Categoria ca;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Clear();
            txtCategoria.Clear();
            txtPesquisa.Clear();
        }
        void carregarGrid(string pesquisa)
        {
            ca = new Categoria()
            {
                categoria = pesquisa
            };
            DgvCategorias.DataSource = ca.Consultar();

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == String.Empty) return;
            ca = new Categoria()
            {
                categoria = txtCategoria.Text
            };
            ca.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void DgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCategorias.RowCount > 0)
            {
                txtID.Text = DgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtCategoria.Text = DgvCategorias.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            ca = new Categoria()
            {
                id = int.Parse(txtID.Text),
                categoria = txtCategoria.Text
            };
            ca.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            if (MessageBox.Show("Deseja excluir a categoria?", "Exclusão", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ca = new Categoria()
                {
                    id = int.Parse(txtID.Text),
                };
                ca.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
