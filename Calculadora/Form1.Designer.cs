namespace Calculadora
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtbTela = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnDivisao = new System.Windows.Forms.Button();
            this.BtnMultiplicacao = new System.Windows.Forms.Button();
            this.BtnAdicao = new System.Windows.Forms.Button();
            this.BtnSubtracao = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btnigual = new System.Windows.Forms.Button();
            this.Btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtbTela
            // 
            this.TxtbTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtbTela.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbTela.ForeColor = System.Drawing.Color.White;
            this.TxtbTela.Location = new System.Drawing.Point(30, 23);
            this.TxtbTela.Multiline = true;
            this.TxtbTela.Name = "TxtbTela";
            this.TxtbTela.Size = new System.Drawing.Size(406, 65);
            this.TxtbTela.TabIndex = 0;
            this.TxtbTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtbTela.TextChanged += new System.EventHandler(this.TxtbTela_TextChanged);
            this.TxtbTela.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtbTela_KeyDown);
            this.TxtbTela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbTela_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.White;
            this.Btn7.Location = new System.Drawing.Point(30, 103);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(96, 85);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.Color.White;
            this.Btn9.Location = new System.Drawing.Point(234, 103);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(96, 85);
            this.Btn9.TabIndex = 3;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.White;
            this.Btn8.Location = new System.Drawing.Point(132, 103);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(96, 85);
            this.Btn8.TabIndex = 4;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.White;
            this.Btn5.Location = new System.Drawing.Point(132, 194);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(96, 85);
            this.Btn5.TabIndex = 7;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.White;
            this.Btn6.Location = new System.Drawing.Point(234, 194);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(96, 85);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.White;
            this.Btn4.Location = new System.Drawing.Point(30, 194);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(96, 85);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.White;
            this.Btn2.Location = new System.Drawing.Point(132, 285);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(96, 85);
            this.Btn2.TabIndex = 10;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.White;
            this.Btn3.Location = new System.Drawing.Point(234, 285);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(96, 85);
            this.Btn3.TabIndex = 9;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.Location = new System.Drawing.Point(30, 285);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(96, 85);
            this.Btn1.TabIndex = 8;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Numero_Click);
            // 
            // BtnDivisao
            // 
            this.BtnDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivisao.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivisao.ForeColor = System.Drawing.Color.White;
            this.BtnDivisao.Location = new System.Drawing.Point(336, 103);
            this.BtnDivisao.Name = "BtnDivisao";
            this.BtnDivisao.Size = new System.Drawing.Size(100, 42);
            this.BtnDivisao.TabIndex = 13;
            this.BtnDivisao.Text = "÷";
            this.BtnDivisao.UseVisualStyleBackColor = false;
            this.BtnDivisao.Click += new System.EventHandler(this.Operador_Click);
            // 
            // BtnMultiplicacao
            // 
            this.BtnMultiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplicacao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicacao.ForeColor = System.Drawing.Color.White;
            this.BtnMultiplicacao.Location = new System.Drawing.Point(336, 151);
            this.BtnMultiplicacao.Name = "BtnMultiplicacao";
            this.BtnMultiplicacao.Size = new System.Drawing.Size(100, 37);
            this.BtnMultiplicacao.TabIndex = 15;
            this.BtnMultiplicacao.Text = "x";
            this.BtnMultiplicacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMultiplicacao.UseVisualStyleBackColor = false;
            this.BtnMultiplicacao.Click += new System.EventHandler(this.Operador_Click);
            // 
            // BtnAdicao
            // 
            this.BtnAdicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicao.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicao.ForeColor = System.Drawing.Color.White;
            this.BtnAdicao.Location = new System.Drawing.Point(336, 242);
            this.BtnAdicao.Name = "BtnAdicao";
            this.BtnAdicao.Size = new System.Drawing.Size(100, 37);
            this.BtnAdicao.TabIndex = 17;
            this.BtnAdicao.Text = "+";
            this.BtnAdicao.UseVisualStyleBackColor = false;
            this.BtnAdicao.Click += new System.EventHandler(this.Operador_Click);
            // 
            // BtnSubtracao
            // 
            this.BtnSubtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtracao.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtracao.ForeColor = System.Drawing.Color.White;
            this.BtnSubtracao.Location = new System.Drawing.Point(336, 194);
            this.BtnSubtracao.Name = "BtnSubtracao";
            this.BtnSubtracao.Size = new System.Drawing.Size(100, 42);
            this.BtnSubtracao.TabIndex = 16;
            this.BtnSubtracao.Text = "-";
            this.BtnSubtracao.UseVisualStyleBackColor = false;
            this.BtnSubtracao.Click += new System.EventHandler(this.Operador_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.Color.White;
            this.Btn0.Location = new System.Drawing.Point(30, 376);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(198, 85);
            this.Btn0.TabIndex = 18;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Numero_Click);
            // 
            // Btnigual
            // 
            this.Btnigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnigual.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnigual.ForeColor = System.Drawing.Color.White;
            this.Btnigual.Location = new System.Drawing.Point(336, 285);
            this.Btnigual.Name = "Btnigual";
            this.Btnigual.Size = new System.Drawing.Size(96, 85);
            this.Btnigual.TabIndex = 19;
            this.Btnigual.Text = "=";
            this.Btnigual.UseVisualStyleBackColor = false;
            this.Btnigual.Click += new System.EventHandler(this.Btnigual_Click);
            // 
            // Btnlimpar
            // 
            this.Btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlimpar.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlimpar.ForeColor = System.Drawing.Color.White;
            this.Btnlimpar.Location = new System.Drawing.Point(238, 376);
            this.Btnlimpar.Name = "Btnlimpar";
            this.Btnlimpar.Size = new System.Drawing.Size(194, 85);
            this.Btnlimpar.TabIndex = 20;
            this.Btnlimpar.Text = "Limpar";
            this.Btnlimpar.UseVisualStyleBackColor = false;
            this.Btnlimpar.Click += new System.EventHandler(this.Btnlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(459, 487);
            this.Controls.Add(this.Btnlimpar);
            this.Controls.Add(this.Btnigual);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnAdicao);
            this.Controls.Add(this.BtnSubtracao);
            this.Controls.Add(this.BtnMultiplicacao);
            this.Controls.Add(this.BtnDivisao);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.TxtbTela);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbTela;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnDivisao;
        private System.Windows.Forms.Button BtnMultiplicacao;
        private System.Windows.Forms.Button BtnAdicao;
        private System.Windows.Forms.Button BtnSubtracao;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btnigual;
        private System.Windows.Forms.Button Btnlimpar;
    }
}

