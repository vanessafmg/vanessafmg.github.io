using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double media;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Entrada de dados
            double n1 = double.Parse(txtNota1.Text);
            double n2 = double.Parse(txtNota2.Text);
            double n3 = double.Parse(txtNota3.Text);

            //Processamento
            media = (n1 + n2 + n3) / 3;

            //Saída de dados
            lblMedia.Text = media.ToString();
        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            if (media >= 7)
            {
                lblSituacao.Text = "Aprovado";
                lblSituacao.ForeColor = Color.Green;
            }
            else if (media >= 4)
            {
                lblSituacao.Text = "Recuperação";
                lblSituacao.ForeColor = Color.Coral;
            }

            else
            {
                lblSituacao.Text = "Retido";
                lblSituacao.ForeColor = Color.Red;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar campos
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            media = 0;

            //Move texto --- para situação
            lblMedia.Text = "0";
            lblSituacao.Text = "----";


            //Move o cursor para o textbox inicial
            txtNota1.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar form
            Close();
        }
    }
}
