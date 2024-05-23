namespace radiobutton
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
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.btnSexo = new System.Windows.Forms.Button();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbDivorciado = new System.Windows.Forms.RadioButton();
            this.rdbViuvo = new System.Windows.Forms.RadioButton();
            this.btnEstado = new System.Windows.Forms.Button();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.grbEstado = new System.Windows.Forms.GroupBox();
            this.grbSexo.SuspendLayout();
            this.grbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(66, 23);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(66, 60);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // btnSexo
            // 
            this.btnSexo.Location = new System.Drawing.Point(44, 101);
            this.btnSexo.Name = "btnSexo";
            this.btnSexo.Size = new System.Drawing.Size(112, 31);
            this.btnSexo.TabIndex = 2;
            this.btnSexo.Text = "Escolha o Sexo";
            this.btnSexo.UseVisualStyleBackColor = true;
            this.btnSexo.Click += new System.EventHandler(this.btnSexo_Click);
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(66, 23);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbSolteiro.TabIndex = 3;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(66, 46);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbCasado.TabIndex = 4;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbDivorciado
            // 
            this.rdbDivorciado.AutoSize = true;
            this.rdbDivorciado.Location = new System.Drawing.Point(66, 69);
            this.rdbDivorciado.Name = "rdbDivorciado";
            this.rdbDivorciado.Size = new System.Drawing.Size(76, 17);
            this.rdbDivorciado.TabIndex = 5;
            this.rdbDivorciado.TabStop = true;
            this.rdbDivorciado.Text = "Divorciado";
            this.rdbDivorciado.UseVisualStyleBackColor = true;
            // 
            // rdbViuvo
            // 
            this.rdbViuvo.AutoSize = true;
            this.rdbViuvo.Location = new System.Drawing.Point(66, 92);
            this.rdbViuvo.Name = "rdbViuvo";
            this.rdbViuvo.Size = new System.Drawing.Size(52, 17);
            this.rdbViuvo.TabIndex = 6;
            this.rdbViuvo.TabStop = true;
            this.rdbViuvo.Text = "Viúvo";
            this.rdbViuvo.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(43, 115);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(122, 30);
            this.btnEstado.TabIndex = 7;
            this.btnEstado.Text = "Escolha o Estado Civil";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.btnSexo);
            this.grbSexo.Controls.Add(this.rdbFeminino);
            this.grbSexo.Controls.Add(this.rdbMasculino);
            this.grbSexo.Location = new System.Drawing.Point(14, 31);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(185, 158);
            this.grbSexo.TabIndex = 8;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // grbEstado
            // 
            this.grbEstado.Controls.Add(this.btnEstado);
            this.grbEstado.Controls.Add(this.rdbViuvo);
            this.grbEstado.Controls.Add(this.rdbDivorciado);
            this.grbEstado.Controls.Add(this.rdbCasado);
            this.grbEstado.Controls.Add(this.rdbSolteiro);
            this.grbEstado.Location = new System.Drawing.Point(224, 31);
            this.grbEstado.Name = "grbEstado";
            this.grbEstado.Size = new System.Drawing.Size(193, 167);
            this.grbEstado.TabIndex = 9;
            this.grbEstado.TabStop = false;
            this.grbEstado.Text = "Estado Civil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 237);
            this.Controls.Add(this.grbEstado);
            this.Controls.Add(this.grbSexo);
            this.Name = "Form1";
            this.Text = "Radio Button";
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.grbEstado.ResumeLayout(false);
            this.grbEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Button btnSexo;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbDivorciado;
        private System.Windows.Forms.RadioButton rdbViuvo;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.GroupBox grbEstado;
    }
}

