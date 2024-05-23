using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using _232017.Models;

namespace _232017.Views
{
    public partial class FrmClientes : Form
    {
        Cidade ci;
        Cliente cl;

        public FrmClientes()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }
        void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            DgvClientes.DataSource = cl.Consultar();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //cria um objeto do tipo cidade e alimenta o comboBox
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            //deixa invisível colunas do grid
            DgvClientes.Columns["idCidade"].Visible = false;
            DgvClientes.Columns["foto"].Visible = false;
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/clientes/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;

            cl = new Cliente()
            {
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked
            };
            cl.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClientes.RowCount > 0)
            {
                txtID.Text = DgvClientes.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = DgvClientes.CurrentRow.Cells["nome"].Value.ToString();
                cboCidades.Text = DgvClientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtUF.Text = DgvClientes.CurrentRow.Cells["uf"].Value.ToString();
                chkVenda.Checked = (bool)DgvClientes.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = DgvClientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtpDataNasc.Text = DgvClientes.CurrentRow.Cells["dataNasc"].Value.ToString();
                txtRenda.Text = DgvClientes.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.ImageLocation = DgvClientes.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            cl = new Cliente()
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked
            };
            cl.Alterar();

            limpaControles();
            carregarGrid("");
        }
    } 
}
