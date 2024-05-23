using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aula de C#","Segundo módulo",MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aula de C#","Segundo Módulo",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aula de C#", "Segundo Módulo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você gosta da aula de C#?", "Segundo Módulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
