using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcfamiliar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Entrada de dados
            double renda = double.Parse(txtRenda.Text);
            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtTV.Text);
            double alimentacao = double.Parse(txtAlimentacao.Text);
            double outros = double.Parse(txtOutros.Text);

            //Processamento
            double totalgasto = energia + agua + tv + alimentacao + outros;
            double saldo = renda - totalgasto;

            //Saída de dados
            lblGastos.Text = totalgasto.ToString("C");
            lblSaldo.Text = saldo.ToString("C");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar caixas de texto
            txtRenda.Clear();
            txtEnergia.Clear();
            txtAgua.Clear();
            txtTV.Clear();
            txtAlimentacao.Clear();
            txtOutros.Clear();

            //Retornar texto Zero
            lblGastos.Text = "R$ 0,00";
            lblSaldo.Text = "R$ 0,00";

            //Mover cursor
            txtRenda.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar o formulário
            Close();
        }
    }
}
