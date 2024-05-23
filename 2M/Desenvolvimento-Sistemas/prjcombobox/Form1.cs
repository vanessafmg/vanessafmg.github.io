using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjcombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //adciona itens manualmente
            cboLista.Items.Add(txtTexto.Text);
            //exibe a quantidade de itens do ComboBox
            lblQtde.Text = cboLista.Items.Count.ToString();
            //limpa a caixa de texto
            txtTexto.Clear();
            //move o foco para a caixa de texto
            txtTexto.Select();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //ativa a propriedade para ordenar a lista no combo em ordem alfábetica
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //remove o item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                //exibe a quantidade de itens do ComboBox
                lblQtde.Text = cboLista.Items.Count.ToString();
                //limpa o texto da combo
                cboLista.ResetText();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //exibe o conteúdo (texto do combo)
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                //exibe o índice (posição) do item no combo
                txtIndice.Text = cboLista.SelectedIndex.ToString();
            }

        }
    }
}
