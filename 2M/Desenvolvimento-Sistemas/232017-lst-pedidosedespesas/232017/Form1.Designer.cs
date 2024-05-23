namespace _232017
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorP = new System.Windows.Forms.TextBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.lstPedidos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotPedidos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorD = new System.Windows.Forms.TextBox();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.lstDespesas = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotDespesas = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotPedidos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstPedidos);
            this.groupBox1.Controls.Add(this.btnPedido);
            this.groupBox1.Controls.Add(this.txtValorP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(66, 25);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(231, 20);
            this.txtPedido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(66, 51);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(231, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // txtValorP
            // 
            this.txtValorP.Location = new System.Drawing.Point(66, 77);
            this.txtValorP.Name = "txtValorP";
            this.txtValorP.Size = new System.Drawing.Size(231, 20);
            this.txtValorP.TabIndex = 5;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(98, 113);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(89, 25);
            this.btnPedido.TabIndex = 6;
            this.btnPedido.Text = "Inserir Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // lstPedidos
            // 
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.Location = new System.Drawing.Point(6, 153);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(291, 95);
            this.lstPedidos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total dos Pedidos:";
            // 
            // lblTotPedidos
            // 
            this.lblTotPedidos.AutoSize = true;
            this.lblTotPedidos.ForeColor = System.Drawing.Color.Blue;
            this.lblTotPedidos.Location = new System.Drawing.Point(234, 279);
            this.lblTotPedidos.Name = "lblTotPedidos";
            this.lblTotPedidos.Size = new System.Drawing.Size(19, 13);
            this.lblTotPedidos.TabIndex = 9;
            this.lblTotPedidos.Text = "----";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotDespesas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lstDespesas);
            this.groupBox2.Controls.Add(this.btnDespesa);
            this.groupBox2.Controls.Add(this.txtValorD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDespesa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Despesas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Despesa:";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(81, 25);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(216, 20);
            this.txtDespesa.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor:";
            // 
            // txtValorD
            // 
            this.txtValorD.Location = new System.Drawing.Point(81, 51);
            this.txtValorD.Name = "txtValorD";
            this.txtValorD.Size = new System.Drawing.Size(216, 20);
            this.txtValorD.TabIndex = 3;
            // 
            // btnDespesa
            // 
            this.btnDespesa.Location = new System.Drawing.Point(101, 113);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(94, 25);
            this.btnDespesa.TabIndex = 4;
            this.btnDespesa.Text = "Inserir Despesa";
            this.btnDespesa.UseVisualStyleBackColor = true;
            this.btnDespesa.Click += new System.EventHandler(this.btnDespesa_Click);
            // 
            // lstDespesas
            // 
            this.lstDespesas.FormattingEnabled = true;
            this.lstDespesas.Location = new System.Drawing.Point(7, 153);
            this.lstDespesas.Name = "lstDespesas";
            this.lstDespesas.Size = new System.Drawing.Size(290, 95);
            this.lstDespesas.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total das Despesas:";
            // 
            // lblTotDespesas
            // 
            this.lblTotDespesas.AutoSize = true;
            this.lblTotDespesas.ForeColor = System.Drawing.Color.Red;
            this.lblTotDespesas.Location = new System.Drawing.Point(240, 279);
            this.lblTotDespesas.Name = "lblTotDespesas";
            this.lblTotDespesas.Size = new System.Drawing.Size(22, 13);
            this.lblTotDespesas.TabIndex = 7;
            this.lblTotDespesas.Text = "-----";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFechar);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.lblSaldo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saldo da Empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Blue;
            this.lblSaldo.Location = new System.Drawing.Point(79, 32);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(22, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "-----";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(390, 26);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 24);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Novo Lançamento";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(500, 26);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 24);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Finalizar Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Fabrica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.Label lblTotPedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.ListBox lstDespesas;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Label lblTotDespesas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

