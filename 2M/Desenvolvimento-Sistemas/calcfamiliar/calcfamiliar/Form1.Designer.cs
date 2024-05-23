namespace calcfamiliar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.grbGastos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlimentacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grbGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renda Familiar:";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(112, 35);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(209, 20);
            this.txtRenda.TabIndex = 1;
            // 
            // grbGastos
            // 
            this.grbGastos.Controls.Add(this.txtOutros);
            this.grbGastos.Controls.Add(this.label6);
            this.grbGastos.Controls.Add(this.txtAlimentacao);
            this.grbGastos.Controls.Add(this.label5);
            this.grbGastos.Controls.Add(this.txtTV);
            this.grbGastos.Controls.Add(this.label4);
            this.grbGastos.Controls.Add(this.txtAgua);
            this.grbGastos.Controls.Add(this.label3);
            this.grbGastos.Controls.Add(this.txtEnergia);
            this.grbGastos.Controls.Add(this.label2);
            this.grbGastos.Location = new System.Drawing.Point(12, 97);
            this.grbGastos.Name = "grbGastos";
            this.grbGastos.Size = new System.Drawing.Size(327, 213);
            this.grbGastos.TabIndex = 2;
            this.grbGastos.TabStop = false;
            this.grbGastos.Text = "Gastos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Água:";
            // 
            // txtEnergia
            // 
            this.txtEnergia.Location = new System.Drawing.Point(118, 27);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(191, 20);
            this.txtEnergia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Energia Elétrica:";
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(118, 63);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(191, 20);
            this.txtAgua.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TV / Fone / Internet:";
            // 
            // txtTV
            // 
            this.txtTV.Location = new System.Drawing.Point(118, 95);
            this.txtTV.Name = "txtTV";
            this.txtTV.Size = new System.Drawing.Size(191, 20);
            this.txtTV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alimentação:";
            // 
            // txtAlimentacao
            // 
            this.txtAlimentacao.Location = new System.Drawing.Point(118, 129);
            this.txtAlimentacao.Name = "txtAlimentacao";
            this.txtAlimentacao.Size = new System.Drawing.Size(191, 20);
            this.txtAlimentacao.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Outros Gastos:";
            // 
            // txtOutros
            // 
            this.txtOutros.Location = new System.Drawing.Point(118, 162);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(190, 20);
            this.txtOutros.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 337);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 40);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(130, 337);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 40);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Novo Cálculo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(256, 337);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(83, 40);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total dos Gastos:";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.ForeColor = System.Drawing.Color.Blue;
            this.lblGastos.Location = new System.Drawing.Point(196, 453);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(45, 13);
            this.lblGastos.TabIndex = 8;
            this.lblGastos.Text = "R$ 0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.ForeColor = System.Drawing.Color.Blue;
            this.lblSaldo.Location = new System.Drawing.Point(196, 478);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(45, 13);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "R$ 0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 604);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbGastos);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora Familiar";
            this.grbGastos.ResumeLayout(false);
            this.grbGastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.GroupBox grbGastos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnergia;
        private System.Windows.Forms.TextBox txtTV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlimentacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSaldo;
    }
}

