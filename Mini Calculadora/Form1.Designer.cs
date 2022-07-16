namespace Mini_Calculadora
{
    partial class MiniCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniCalc));
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.txbResultado1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbNum1
            // 
            this.txbNum1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNum1.Location = new System.Drawing.Point(297, 111);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(100, 34);
            this.txbNum1.TabIndex = 0;
            this.txbNum1.TextChanged += new System.EventHandler(this.txbNum1_TextChanged);
            this.txbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNum1_KeyPress);
            // 
            // txbNum2
            // 
            this.txbNum2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNum2.Location = new System.Drawing.Point(297, 181);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(100, 34);
            this.txbNum2.TabIndex = 1;
            this.txbNum2.TextChanged += new System.EventHandler(this.txbNum2_TextChanged);
            this.txbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNum2_KeyPress);
            // 
            // txbResultado
            // 
            this.txbResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbResultado.Location = new System.Drawing.Point(297, 399);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(100, 34);
            this.txbResultado.TabIndex = 2;
            this.txbResultado.TextChanged += new System.EventHandler(this.txbResultado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(141, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número um:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(141, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número dois:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(141, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(149, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mini Calculadora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(217, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Operações:";
            // 
            // btnMais
            // 
            this.btnMais.Enabled = false;
            this.btnMais.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMais.Location = new System.Drawing.Point(176, 312);
            this.btnMais.Margin = new System.Windows.Forms.Padding(8);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(35, 35);
            this.btnMais.TabIndex = 8;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Enabled = false;
            this.btnMenos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.Location = new System.Drawing.Point(227, 312);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(8);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(35, 35);
            this.btnMenos.TabIndex = 9;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Enabled = false;
            this.btnMultiplicar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(278, 312);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(8);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(35, 35);
            this.btnMultiplicar.TabIndex = 10;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Enabled = false;
            this.btnDividir.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.Location = new System.Drawing.Point(329, 312);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(8);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(35, 35);
            this.btnDividir.TabIndex = 11;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(149, 551);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(322, 551);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.LightGreen;
            this.lblData.Location = new System.Drawing.Point(149, 509);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 15);
            this.lblData.TabIndex = 15;
            this.lblData.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbResultado1
            // 
            this.txbResultado1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbResultado1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbResultado1.ForeColor = System.Drawing.Color.LightGreen;
            this.txbResultado1.Location = new System.Drawing.Point(149, 456);
            this.txbResultado1.Name = "txbResultado1";
            this.txbResultado1.ReadOnly = true;
            this.txbResultado1.Size = new System.Drawing.Size(248, 16);
            this.txbResultado1.TabIndex = 19;
            this.txbResultado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MiniCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(561, 631);
            this.Controls.Add(this.txbResultado1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.txbNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiniCalc";
            this.Text = "Operações Básicas";
            this.Load += new System.EventHandler(this.MiniCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNum1;
        private TextBox txbNum2;
        private TextBox txbResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnMais;
        private Button btnMenos;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnLimpar;
        private Button btnSair;
        private Label lblData;
        private TextBox txbResultado1;
    }
}