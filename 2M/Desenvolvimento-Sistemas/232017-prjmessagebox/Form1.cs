using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _232017_prjmessagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoje foi um dia bom?", "Questão cotidiana",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beba água!", "Evite pedra nos rins",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou no botão errado", "Foco no foco",
             MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você é lindo(a)!", "Olá!",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você está cadastrado para concorrer a 1 MILHÃO!", "Pronto",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você se descadastrou", "Sentiremos sua falta",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja refazer o módulo 1? ", "ETEC",
             MessageBoxButtons.RetryCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verifique se você confia neste link", "LINK SUSPEITO",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Que tal diminuir a temperatura do ar condicionado?", "Calor",
             MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botões criados", "Segundou",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }
    }
}
