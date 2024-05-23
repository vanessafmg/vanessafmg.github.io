namespace _232017_prjmessagebox
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(323, 27);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Pergunta - (Sim/Não) - Primeiro Botão";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 45);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(323, 26);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Crítica - (Ok)";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 77);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(323, 28);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Crítica - (Abortar/Repetir/Ignorar) - Segundo Botão";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 112);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(323, 28);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Afirmação - (Ok)";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(12, 147);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(323, 30);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Informação - (Ok/Cancelar) - Segundo Botão";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(12, 184);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(323, 28);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "Crítica - (Ok/Cancelar) - Segundo Botão";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 219);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(322, 28);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "Pergunta - (Repetir/Cancelar) - Segundo Botão";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(13, 254);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(322, 27);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "Crítica - (Sim/Não) - Segundo Botão";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(13, 288);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(322, 28);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "Pergunta - (Abortar/Repetir/Ignorar) - Terceiro Botão";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(13, 323);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(322, 30);
            this.btn10.TabIndex = 9;
            this.btn10.Text = "Informação - (Ok/Cancelar) - Segundo Botão";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 365);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "232017 - Exercícios - Message Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
    }
}

