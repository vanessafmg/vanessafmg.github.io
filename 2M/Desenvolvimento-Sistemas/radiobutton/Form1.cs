using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSexo_Click(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
                MessageBox.Show("Sexo Masculino");
            else
                MessageBox.Show("Sexo Feminino");
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (rdbSolteiro.Checked)
                MessageBox.Show("Solteiro");
            else if (rdbCasado.Checked)
                MessageBox.Show("Casado");
            else if (rdbDivorciado.Checked)
                MessageBox.Show("Divorciado");
            else
                MessageBox.Show("Viúvo");
        }

    }
}
