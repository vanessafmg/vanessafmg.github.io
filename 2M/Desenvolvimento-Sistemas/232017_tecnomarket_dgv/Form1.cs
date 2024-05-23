using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _232017_tecnomarket_dgv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total = 0;
        double totalparcial = 0;
        int cont = 1;

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //adicionar itens na coluna
            dgvVendas.Rows.Add(txtDescricao.Text,txtQntd.Text,txtUnit.Text);
            
            //soma itens no total
            int qntd = int.Parse(txtQntd.Text);
            double valor = double.Parse(txtUnit.Text);
            totalparcial = qntd * valor;
            total += totalparcial;
            lblTotal.Text = total.ToString("C");                    

            //inclusao com sucesso
            MessageBox.Show("Item incluso com sucesso!", "Inclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar existencia de itens
            if (dgvVendas.Rows.Count > 0)
            {
                txtItens.Text= dgvVendas.CurrentRow.Cells["quantidade"].Value.ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verifica a existencia de linhas no grid
            if (dgvVendas.Rows.Count > 0)
            {
                dgvVendas.Rows.RemoveAt(dgvVendas.CurrentRow.Index);

                total -= totalparcial;
                lblTotal.Text = total.ToString("C");

                //removido com sucesso
                MessageBox.Show("Item removido com sucesso!", "Remover",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtItens.Text != "")
            {
                //move o novo valor para a celula selecionada
                dgvVendas.CurrentRow.Cells["quantidade"].Value = txtItens.Text;
                
                int qntd = int.Parse(txtQntd.Text);
                int itens = int.Parse(txtItens.Text);
                double valor = double.Parse(txtUnit.Text);

                totalparcial = (itens - qntd) * valor;
                total += totalparcial;

                lblTotal.Text = total.ToString("C");

                //alterado com sucesso
                MessageBox.Show("Item alterado com sucesso!", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtVenda.Clear();
            txtDescricao.Clear();
            txtQntd.Clear();
            txtUnit.Clear();
            txtItens.Clear();
            dgvVendas.RowCount = 0;
            lblTotal.Text = "R$ 0,00";
            total = 0;
            totalparcial = 0;
            

            MessageBox.Show("Venda cancelada com sucesso!", "Cancelar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            txtVenda.Clear();
            txtDescricao.Clear();
            txtQntd.Clear();
            txtUnit.Clear();
            txtItens.Clear();
            dgvVendas.RowCount = 0;
            lblTotal.Text = "R$ 0,00";
            total = 0;
            totalparcial = 0;
            cont++;
            txtVenda.Text = cont.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
