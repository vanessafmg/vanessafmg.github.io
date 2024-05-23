using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _232017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double totalped;
        double totaldesp;
        double saldo;
        
        
        private void btnPedido_Click(object sender, EventArgs e)
        {
            //entrada de dados
            int pedido = int.Parse(txtPedido.Text);
            String cliente = txtCliente.Text;
            double valorped = double.Parse(txtValorP.Text);

            //inserir list
            lstPedidos.Items.Add(txtPedido.Text + " / " + txtCliente.Text + " / " + valorped.ToString("C"));

            //processamento
            totalped += valorped;

            //saída
            lblTotPedidos.Text= totalped.ToString("C");
            
            //limpa caixas para inserir novo pedido
            txtPedido.Clear();
            txtCliente.Clear();
            txtValorP.Clear();
            txtPedido.Focus();

            //saldo
            saldo = totalped - totaldesp;
            lblSaldo.Text= saldo.ToString("C");
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            //entrada de dados
            String despesa = txtDespesa.Text;
            double valordesp = double.Parse(txtValorD.Text);

            //inserir list
            lstDespesas.Items.Add(txtDespesa.Text + " / " + valordesp.ToString("C"));

            //processamento
            totaldesp += valordesp;

            //saída
            lblTotDespesas.Text = totaldesp.ToString("C");

            //limpar campos para nova despesa
            txtDespesa.Clear();
            txtValorD.Clear();
            txtDespesa.Focus();

            //saldo
            saldo = totalped - totaldesp;
            lblSaldo.Text = saldo.ToString("C");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //zerar totais
            totaldesp = 0;
            totalped = 0;
            saldo = 0;
            
            //limpar 
            lstPedidos.Items.Clear();
            lstDespesas.Items.Clear();
            lblSaldo.Text = "---";
            lblTotDespesas.Text = "---";
            lblTotPedidos.Text = "---";

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
