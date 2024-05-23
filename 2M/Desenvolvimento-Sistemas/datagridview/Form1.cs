using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //Adciona o conteúdo das caixas de texto nas colunas correspondentes
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);
            //Limpa as caixas de texto
            txtNome.Clear();
            txtCurso.Clear();
            //Exibe uma mensagem ao usuáro de inclusão com sucesso
            MessageBox.Show("Aluno incluido com sucesso", "Inclusão",MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            //Exibe na label o contador de linhas do GridView atualizado após a inserção
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Verifica a existência de linhas no Grid
            if (dgvAlunos.Rows.Count > 0)
            {
                //Remove a linha selecionada do Grid
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                //Exibe uma mensagem ao usuário de exclusão com sucesso
                MessageBox.Show("Aluno Excluído com sucesso", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Exibe na label o contador de linhas do GridView atualizado após a remoção
                lblTotal.Text = dgvAlunos.RowCount.ToString();
            }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica a existência de linhas no Grid
            if (dgvAlunos.RowCount > 0)
            {
                //move o conteúdo da primeira célula da linha selecionada para a caixa de texto
                txtAlteracao.Text = dgvAlunos.CurrentRow.Cells["nome"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlteracao.Text != "")
            {
                //move o novo valor da caixa de texto alteração para a célula selecionada
                dgvAlunos.CurrentRow.Cells["nome"].Value = txtAlteracao.Text;
                //exibe a mensagem de alteração com sucesso
                MessageBox.Show("Aluno Alterado com Sucesso", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtAlteracaoc.Text != "")
            {
                //move o novo valor da caixa de texto alteração para a célula selecionada
                dgvAlunos.CurrentRow.Cells["curso"].Value = txtAlteracaoc.Text;
                //exibe a mensagem de alteração com sucesso
                MessageBox.Show("Curso Alterado com Sucesso", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //zera as linhas do grid, removendo as existentes
            dgvAlunos.RowCount = 0;
            //exibe na label o contador de linhas do gridview após ser zerado
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
