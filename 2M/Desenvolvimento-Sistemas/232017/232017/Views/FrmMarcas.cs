using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _232017.Models;

namespace _232017.Views
{
    public partial class FrmMarcas : Form
    {
        Marca m;
        public FrmMarcas()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Clear();
            txtMarca.Clear();
            txtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            m = new Marca()
            {
                marca = pesquisa
            };
            DgvMarcas.DataSource = m.Consultar();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == String.Empty) return;
            m = new Marca()
            {
                marca = txtMarca.Text
            };
            m.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void DgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMarcas.RowCount>0)
            {
                txtID.Text = DgvMarcas.CurrentRow.Cells["id"].Value.ToString();
                txtMarca.Text = DgvMarcas.CurrentRow.Cells["marca"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            m = new Marca()
            {
                id = int.Parse(txtID.Text),
                marca = txtMarca.Text
            };
            m.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            if (MessageBox.Show("Deseja excluir a marca?","Exclusão",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    id = int.Parse(txtID.Text)
                };
                m.Excluir();

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
