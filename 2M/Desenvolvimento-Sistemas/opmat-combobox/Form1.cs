using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opmat_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            double n1, n2, resultado = 0;

            //verifica se todos os campos estão preenchidos
            if (cboOperacao.SelectedIndex == -1 ||
                txtN1.Text == String.Empty ||
                txtN2.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //para o código, retorna para o usuário
            }

            //variáveis recebem os valores digitados pelo usuário
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);

            if (cboOperacao.SelectedItem.ToString() == "Adição")
                resultado = n1 + n2;
            else if (cboOperacao.SelectedItem.ToString() == "Subtração")
                resultado = n1 - n2;
            else if (cboOperacao.SelectedItem.ToString() == "Multiplicação")
                resultado = n1 * n2;
            else
                resultado = n1 / n2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblResultado.Text = "---";
            cboOperacao.SelectedIndex = -1;
            
            
        }
    }
}
