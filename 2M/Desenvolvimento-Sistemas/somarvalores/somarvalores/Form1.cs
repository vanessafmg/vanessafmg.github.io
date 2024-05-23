using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somarvalores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Entrada de Dados
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            //Processamento
            int resultado = n1+n2;

            //Saída de dados
            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as caixas de texto através da função Clear
            txtN1.Clear();
            txtN2.Clear();

            //Move o texto zero para a label
            lblResultado.Text = "0";

            //Move o cursor para o textBox
            txtN1.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha o formulário
            Close();
        }
    }
}
