namespace prjcombobox
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(102, 35);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(349, 20);
            this.txtTexto.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(144, 74);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(110, 28);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir no Combo";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(301, 74);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(112, 28);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar o Combo";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista:";
            // 
            // cboLista
            // 
            this.cboLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(102, 123);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(349, 21);
            this.cboLista.TabIndex = 5;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(220, 165);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(124, 27);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover do Combo";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade de Itens:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.ForeColor = System.Drawing.Color.Blue;
            this.lblQtde.Location = new System.Drawing.Point(174, 231);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(13, 13);
            this.lblQtde.TabIndex = 8;
            this.lblQtde.Text = "0";
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(220, 270);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(124, 27);
            this.btnExibir.TabIndex = 9;
            this.btnExibir.Text = "Exibir dados do Combo";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Índice do Combo:";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(102, 333);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(349, 20);
            this.txtIndice.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Texto do Combo:";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(102, 368);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(349, 20);
            this.txtConteudo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 426);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConteudo;
    }
}

