namespace ExerciciosClaudia
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.rdbtn2 = new System.Windows.Forms.RadioButton();
            this.rdbtn3 = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Conversão";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(272, 196);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(29, 21);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "R$";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(269, 313);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(31, 21);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "U$";
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(311, 196);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(108, 23);
            this.txbValor1.TabIndex = 4;
            // 
            // txbValor2
            // 
            this.txbValor2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbValor2.Location = new System.Drawing.Point(306, 311);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.ReadOnly = true;
            this.txbValor2.Size = new System.Drawing.Size(113, 23);
            this.txbValor2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(318, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtn1.Location = new System.Drawing.Point(306, 56);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(81, 25);
            this.rdbtn1.TabIndex = 9;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "R$ - U$";
            this.rdbtn1.UseVisualStyleBackColor = true;
            this.rdbtn1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtn2
            // 
            this.rdbtn2.AutoSize = true;
            this.rdbtn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtn2.Location = new System.Drawing.Point(262, 87);
            this.rdbtn2.Name = "rdbtn2";
            this.rdbtn2.Size = new System.Drawing.Size(169, 25);
            this.rdbtn2.TabIndex = 10;
            this.rdbtn2.TabStop = true;
            this.rdbtn2.Text = "Metros - Centímetro";
            this.rdbtn2.UseVisualStyleBackColor = true;
            this.rdbtn2.CheckedChanged += new System.EventHandler(this.rdbtn2_CheckedChanged);
            // 
            // rdbtn3
            // 
            this.rdbtn3.AutoSize = true;
            this.rdbtn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtn3.Location = new System.Drawing.Point(309, 118);
            this.rdbtn3.Name = "rdbtn3";
            this.rdbtn3.Size = new System.Drawing.Size(74, 25);
            this.rdbtn3.TabIndex = 11;
            this.rdbtn3.TabStop = true;
            this.rdbtn3.Text = "Cº - Fº";
            this.rdbtn3.UseVisualStyleBackColor = true;
            this.rdbtn3.CheckedChanged += new System.EventHandler(this.rdbtn3_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(192, 392);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 46);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(394, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 46);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInvert.Location = new System.Drawing.Point(269, 244);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(43, 49);
            this.btnInvert.TabIndex = 14;
            this.btnInvert.Text = " ↓ ↑";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.rdbtn3);
            this.Controls.Add(this.rdbtn2);
            this.Controls.Add(this.rdbtn1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.txbValor1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Calculadora de Conversão";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl1;
        private Label lbl2;
        private TextBox txbValor1;
        private TextBox txbValor2;
        private Button button1;
        private RadioButton rdbtn1;
        private RadioButton rdbtn2;
        private RadioButton rdbtn3;
        private Button btnLimpar;
        private Button btnSair;
        private Button btnInvert;
    }
}