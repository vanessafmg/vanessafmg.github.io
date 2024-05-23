using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _232017_avaliativa
{
    public partial class Form1 : Form
    {
        int ID = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //iniciar contador do ID
            txtID.Text = ID.ToString();
            dgvAtendimentos.RowCount = 0;
           
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //entrada de atendimentos
            dgvAtendimentos.Rows.Add(txtID.Text,txtCliente.Text,txtServico.Text,txtValor.Text,txtPgto.Text);
            
            //limpar caixas e mover cursor
            txtCliente.Clear();
            txtServico.Clear();
            txtValor.Clear();
            txtPgto.Clear();
            txtCliente.Focus();

            //contar id
            ID += 1;
            txtID.Text = ID.ToString();
        }

        private void dgvAtendimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar existência de atendimentos no grid
            if (dgvAtendimentos.RowCount > 0)
            {
                txtCliente.Text = dgvAtendimentos.CurrentRow.Cells["cliente"].Value.ToString();
                txtServico.Text = dgvAtendimentos.CurrentRow.Cells["servico"].Value.ToString();
                txtValor.Text = dgvAtendimentos.CurrentRow.Cells["valor"].Value.ToString();
                txtPgto.Text = dgvAtendimentos.CurrentRow.Cells["pgto"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvAtendimentos.RowCount > 0)
            {
                dgvAtendimentos.CurrentRow.Cells["cliente"].Value = txtCliente.Text;
                dgvAtendimentos.CurrentRow.Cells["servico"].Value = txtServico.Text;
                dgvAtendimentos.CurrentRow.Cells["valor"].Value = txtValor.Text;
                dgvAtendimentos.CurrentRow.Cells["pgto"].Value = txtPgto.Text;
            }

            //limpar caixas e mover cursor
            txtCliente.Clear();
            txtServico.Clear();
            txtValor.Clear();
            txtPgto.Clear();
            txtCliente.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAtendimentos.RowCount>0)
            {
                dgvAtendimentos.Rows.RemoveAt(dgvAtendimentos.CurrentCell.RowIndex);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //finalizar aplicação
            Application.Exit();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.ToLower(); 

            foreach (DataGridViewRow row in dgvAtendimentos.Rows)
            {
                // Verificar se o cliente contém a pesquisa
                if (row.Cells["cliente"].Value.ToString().ToLower().Contains(pesquisa))
                {
                    row.DefaultCellStyle.BackColor = Color.Aquamarine;
                    continue; // Ir para a próxima linha após encontrar uma correspondência
                }

                // Verificar se o serviço contém a pesquisa
                if (row.Cells["servico"].Value.ToString().ToLower().Contains(pesquisa))
                {
                    row.DefaultCellStyle.BackColor = Color.Aquamarine;
                    continue;
                }

                // Verificar se o valor contém a pesquisa
                if (row.Cells["valor"].Value.ToString().ToLower().Contains(pesquisa))
                {
                    row.DefaultCellStyle.BackColor = Color.Aquamarine;
                    continue;
                }

                // Verificar se a forma de pagamento contém a pesquisa
                if (row.Cells["pgto"].Value.ToString().ToLower().Contains(pesquisa))
                {
                    row.DefaultCellStyle.BackColor = Color.Aquamarine;
                    continue;
                }

                // Se nenhum dos critérios anteriores corresponder, definir a cor de fundo como branca
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtCliente.Focus();
        }
    }
}
