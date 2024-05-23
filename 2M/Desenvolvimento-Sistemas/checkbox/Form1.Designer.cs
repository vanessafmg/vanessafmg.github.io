namespace checkbox
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
            this.chkAdministracao = new System.Windows.Forms.CheckBox();
            this.chkDesenvolvimento = new System.Windows.Forms.CheckBox();
            this.chkNutricao = new System.Windows.Forms.CheckBox();
            this.chkLogistica = new System.Windows.Forms.CheckBox();
            this.chkEdificacoes = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAdministracao
            // 
            this.chkAdministracao.AutoSize = true;
            this.chkAdministracao.Location = new System.Drawing.Point(43, 34);
            this.chkAdministracao.Name = "chkAdministracao";
            this.chkAdministracao.Size = new System.Drawing.Size(92, 17);
            this.chkAdministracao.TabIndex = 0;
            this.chkAdministracao.Text = "Administração";
            this.chkAdministracao.UseVisualStyleBackColor = true;
            // 
            // chkDesenvolvimento
            // 
            this.chkDesenvolvimento.AutoSize = true;
            this.chkDesenvolvimento.Location = new System.Drawing.Point(43, 58);
            this.chkDesenvolvimento.Name = "chkDesenvolvimento";
            this.chkDesenvolvimento.Size = new System.Drawing.Size(108, 17);
            this.chkDesenvolvimento.TabIndex = 1;
            this.chkDesenvolvimento.Text = "Desenvolvimento";
            this.chkDesenvolvimento.UseVisualStyleBackColor = true;
            // 
            // chkNutricao
            // 
            this.chkNutricao.AutoSize = true;
            this.chkNutricao.Location = new System.Drawing.Point(43, 82);
            this.chkNutricao.Name = "chkNutricao";
            this.chkNutricao.Size = new System.Drawing.Size(66, 17);
            this.chkNutricao.TabIndex = 2;
            this.chkNutricao.Text = "Nutrição";
            this.chkNutricao.UseVisualStyleBackColor = true;
            // 
            // chkLogistica
            // 
            this.chkLogistica.AutoSize = true;
            this.chkLogistica.Location = new System.Drawing.Point(43, 106);
            this.chkLogistica.Name = "chkLogistica";
            this.chkLogistica.Size = new System.Drawing.Size(70, 17);
            this.chkLogistica.TabIndex = 3;
            this.chkLogistica.Text = "Logística";
            this.chkLogistica.UseVisualStyleBackColor = true;
            // 
            // chkEdificacoes
            // 
            this.chkEdificacoes.AutoSize = true;
            this.chkEdificacoes.Location = new System.Drawing.Point(43, 130);
            this.chkEdificacoes.Name = "chkEdificacoes";
            this.chkEdificacoes.Size = new System.Drawing.Size(81, 17);
            this.chkEdificacoes.TabIndex = 4;
            this.chkEdificacoes.Text = "Edificações";
            this.chkEdificacoes.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(43, 154);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 216);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkEdificacoes);
            this.Controls.Add(this.chkLogistica);
            this.Controls.Add(this.chkNutricao);
            this.Controls.Add(this.chkDesenvolvimento);
            this.Controls.Add(this.chkAdministracao);
            this.Name = "Form1";
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAdministracao;
        private System.Windows.Forms.CheckBox chkDesenvolvimento;
        private System.Windows.Forms.CheckBox chkNutricao;
        private System.Windows.Forms.CheckBox chkLogistica;
        private System.Windows.Forms.CheckBox chkEdificacoes;
        private System.Windows.Forms.Button btnOk;
    }
}

