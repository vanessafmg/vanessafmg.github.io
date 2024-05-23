using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double total = 0;
        String pizza;        
        String borda;        
        String refrigerante;               
        String suco;
        
        

        private void btnFatura_Click(object sender, EventArgs e)
        {
            if (rdbModa.Checked)
            {
                total += 17.50;
                pizza = rdbModa.Text + " = " + lblModa.Text;
            }
            else if (rdbAtum.Checked)
            {
                total += 17.85;
                pizza = rdbAtum.Text + " = " + lblAtum.Text;
            }
            else if (rdbBaiana.Checked)
            {
                total += 16.10;
                pizza = rdbBaiana.Text + " = " + lblBaiana.Text;
            }
            else if (rdbBrocolis.Checked)
            {
                total += 12.00;
                pizza = rdbBrocolis.Text + " = " + lblBrocolis.Text;
            }
            else if (rdbCalabresa.Checked)
            {
                total += 20.50;
                pizza = rdbCalabresa.Text + " = " + lblCalabresa.Text;
            }
            else if (rdbMussarela.Checked)
            {
                total += 16.70;
                pizza = rdbMussarela.Text + " = " + lblMussarela.Text;
            }
            else if (rdb4Queijos.Checked)
            {
                total += 15.50;
                pizza = rdb4Queijos.Text + " = " + lbl4Queijos.Text;
            }
            else if (rdbStrogonoff.Checked)             
            {
                total += 22.75;
                pizza = rdbStrogonoff.Text + " = " + lblStrogonoff.Text;
            }


            if (rdbSem.Checked)
            {
                borda = "Borda: ---";
            }
            else if (rdbCatupiry.Checked)
            {
                total += 3.45;
                borda = rdbCatupiry.Text + " = " + lblCatupiry.Text;
            }
            else if (rdbCheddar.Checked) 
            {
                total += 4.65;
                borda = rdbCheddar.Text + " = " + lblCheddar.Text;
            }

            if (chkCervejag.Checked)
            {
                total += 5.5;
                refrigerante += chkCervejag.Text + " = " + lblCervejag.Text + "\n";
            }
            if (chkCervejal.Checked)
            {
                total += 4.0;
                refrigerante += chkCervejal.Text + " = " + lblCervejal.Text + "\n";
            }
            if (chkCocalata.Checked)
            {
                total += 3.5;
                refrigerante += chkCocalata.Text + " = " + lblCocalata.Text + "\n";
            }
            if (chkCocalitro.Checked)
            {
                total += 5.1;
                refrigerante += chkCocalitro.Text + " = " + lblCocalitro.Text + "\n";
            }
            if (chkGuaranalata.Checked)
            {
                total += 2.85;
                refrigerante += chkGuaranalata.Text + " = " + lblGuaranalata.Text + "\n";
            }
            if (chkGuaranalitro.Checked)
            {
                total += 3.5;
                refrigerante += chkGuaranalitro.Text + " = " + lblGuaranalitro.Text + "\n";
            }

            if (chkAbacaxic.Checked)
            {
                total += 4.2;
                suco += chkAbacaxic.Text + " = " + lblAbacaxic.Text + "\n";
            }

            if (chkAbacaxij.Checked)
            {
                total += 6.05;
                suco += chkAbacaxij.Text + " = " + lblAbacaxij.Text + "\n";
            }
            if (chkLaranjac.Checked)
            {
                total += 4.25;
                suco += chkLaranjac.Text + " = " + lblLaranjac.Text + "\n";
            }
            if (chkLaranjaj.Checked)
            {
                total += 6.3;
                suco += chkLaranjaj.Text + " = " + lblLaranjaj.Text + "\n";
            }
            if (chkMaracujac.Checked)
            {
                total += 4.1;
                suco += chkMaracujac.Text + " = " + lblMaracujac.Text + "\n";
            }
            if (chkMaracujaj.Checked)
            {
                total += 6.5;
                suco += chkMaracujaj.Text + " = " + lblMaracujaj.Text + "\n";
                
            }

            MessageBox.Show("Cliente: " + txtCliente.Text + "\nPizza: " + pizza + "\nBorda: " +
                borda + "\nBebida: " + refrigerante + "Suco: " + suco +
                "\nTotal da Fatura: " + total.ToString("C"), "PIZZARIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtCliente.Select();
           
            rdbModa.Checked = false;
            rdbAtum.Checked = false;
            rdbBaiana.Checked = false;
            rdbBrocolis.Checked = false;
            rdbCalabresa.Checked = false;
            rdbMussarela.Checked = false;
            rdb4Queijos.Checked = false;
            rdbStrogonoff.Checked = false;
            rdbSem.Checked = false;
            rdbCatupiry.Checked = false;
            rdbCheddar.Checked = false;

            chkCervejag.Checked = false;
            chkCervejal.Checked = false;
            chkCocalata.Checked = false;
            chkCocalitro.Checked = false;
            chkGuaranalata.Checked = false;
            chkGuaranalitro.Checked = false;
            chkAbacaxic.Checked = false;
            chkAbacaxij.Checked = false;
            chkLaranjac.Checked = false;
            chkLaranjaj.Checked = false;
            chkMaracujac.Checked = false;
            chkMaracujaj.Checked = false;

        }
    }
}
