using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listamercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        double total = 0;
        private void btnInserir_Click(object sender, EventArgs e)
        {
                       
            //Entrada de dados 
            String produto = (txtProduto.Text);
            int quantidade = int.Parse(txtQtde.Text);
            double valor = double.Parse(txtValor.Text);

            //listbox
            lstProdutos.Items.Add(produto + " / " + quantidade + " / " + valor.ToString("C"));

            //total da venda
            double subtotal = quantidade * valor;
            total += subtotal;
            lblTotal.Text = total.ToString("C");

            //limpar campos
            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstProdutos.Items.Clear();
            txtProduto.Focus();
            lblTotal.Text = "R$ 0,00";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
