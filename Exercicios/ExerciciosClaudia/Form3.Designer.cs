namespace ExerciciosClaudia
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSequencia = new System.Windows.Forms.ListBox();
            this.btnSequencia = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstNegativos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstPares = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstMultiplos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbInicial
            // 
            this.txbInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbInicial.Location = new System.Drawing.Point(255, 83);
            this.txbInicial.Name = "txbInicial";
            this.txbInicial.Size = new System.Drawing.Size(100, 29);
            this.txbInicial.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe o valor inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(416, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o valor final:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbFinal
            // 
            this.txbFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbFinal.Location = new System.Drawing.Point(586, 86);
            this.txbFinal.Name = "txbFinal";
            this.txbFinal.Size = new System.Drawing.Size(100, 29);
            this.txbFinal.TabIndex = 3;
            this.txbFinal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(306, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEQUENCIOMETRO";
            // 
            // lstSequencia
            // 
            this.lstSequencia.FormattingEnabled = true;
            this.lstSequencia.ItemHeight = 15;
            this.lstSequencia.Location = new System.Drawing.Point(59, 199);
            this.lstSequencia.Name = "lstSequencia";
            this.lstSequencia.Size = new System.Drawing.Size(156, 229);
            this.lstSequencia.TabIndex = 6;
            // 
            // btnSequencia
            // 
            this.btnSequencia.Location = new System.Drawing.Point(209, 138);
            this.btnSequencia.Name = "btnSequencia";
            this.btnSequencia.Size = new System.Drawing.Size(158, 23);
            this.btnSequencia.TabIndex = 7;
            this.btnSequencia.Text = "Gerar Sequencia";
            this.btnSequencia.UseVisualStyleBackColor = true;
            this.btnSequencia.Click += new System.EventHandler(this.btnSequencia_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(424, 138);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(158, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstNegativos
            // 
            this.lstNegativos.FormattingEnabled = true;
            this.lstNegativos.ItemHeight = 15;
            this.lstNegativos.Location = new System.Drawing.Point(229, 199);
            this.lstNegativos.Name = "lstNegativos";
            this.lstNegativos.Size = new System.Drawing.Size(156, 229);
            this.lstNegativos.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sequência";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numeros Negativos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numeros Pares";
            // 
            // lstPares
            // 
            this.lstPares.FormattingEnabled = true;
            this.lstPares.ItemHeight = 15;
            this.lstPares.Location = new System.Drawing.Point(403, 199);
            this.lstPares.Name = "lstPares";
            this.lstPares.Size = new System.Drawing.Size(156, 229);
            this.lstPares.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = " Multiplos de 7";
            // 
            // lstMultiplos
            // 
            this.lstMultiplos.FormattingEnabled = true;
            this.lstMultiplos.ItemHeight = 15;
            this.lstMultiplos.Location = new System.Drawing.Point(575, 199);
            this.lstMultiplos.Name = "lstMultiplos";
            this.lstMultiplos.Size = new System.Drawing.Size(156, 229);
            this.lstMultiplos.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstMultiplos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstPares);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstNegativos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSequencia);
            this.Controls.Add(this.lstSequencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbInicial);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbInicial;
        private Label label2;
        private Label label1;
        private TextBox txbFinal;
        private Label label3;
        private ListBox lstSequencia;
        private Button btnSequencia;
        private Button btnLimpar;
        private ListBox lstNegativos;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lstPares;
        private Label label7;
        private ListBox lstMultiplos;
    }
}