using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (chkAdministracao.Checked)
                MessageBox.Show("Você já cursou Administração");
            else
                MessageBox.Show("Você não cursou Administração");

            if (chkDesenvolvimento.Checked)
                MessageBox.Show("Você já cursou Desenvolvimento");
            else
                MessageBox.Show("Você não cursou Desenvolvimento");

            if (chkEdificacoes.Checked)
                MessageBox.Show("Você já cursou Edificações");
            else
                MessageBox.Show("Você não cursou Edificações");

            if (chkLogistica.Checked)
                MessageBox.Show("Você já cursou Logística");
            else
                MessageBox.Show("Você não cursou Logística");

            if (chkNutricao.Checked)
                MessageBox.Show("Você já cursou Nutrição");
            else
                MessageBox.Show("Você não cursou Nutrição");

        }
    }
}
