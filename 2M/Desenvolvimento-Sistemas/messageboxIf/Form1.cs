using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageboxIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExemplo1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você gostou da aula?", "Caixa de Mensagem", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                txtSelecao.Text = "SIM";
            else
                txtSelecao.Text = "NÃO";
        }

        private void btnExemplo2_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Outro exemplo", "Caixa de Mensagem",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

            if (resp == DialogResult.Abort) txtSelecao.Text = "ANULAR";
            else if (resp == DialogResult.Retry) txtSelecao.Text = "REPETIR";
            else txtSelecao.Text = "IGNORAR";
        }
    }
}
