namespace ExerciciosClaudia
{
    partial class Form1
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
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNum3 = new System.Windows.Forms.TextBox();
            this.txbMaior = new System.Windows.Forms.TextBox();
            this.txbMenor = new System.Windows.Forms.TextBox();
            this.btnConferir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNum1
            // 
            this.txbNum1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNum1.Location = new System.Drawing.Point(306, 34);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(100, 29);
            this.txbNum1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbNum2
            // 
            this.txbNum2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNum2.Location = new System.Drawing.Point(306, 90);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(100, 29);
            this.txbNum2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(216, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero 3:";
            // 
            // txbNum3
            // 
            this.txbNum3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNum3.Location = new System.Drawing.Point(306, 147);
            this.txbNum3.Name = "txbNum3";
            this.txbNum3.Size = new System.Drawing.Size(100, 29);
            this.txbNum3.TabIndex = 4;
            // 
            // txbMaior
            // 
            this.txbMaior.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txbMaior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaior.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMaior.Location = new System.Drawing.Point(177, 230);
            this.txbMaior.Name = "txbMaior";
            this.txbMaior.Size = new System.Drawing.Size(327, 27);
            this.txbMaior.TabIndex = 6;
            this.txbMaior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbMenor
            // 
            this.txbMenor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txbMenor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMenor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMenor.Location = new System.Drawing.Point(177, 295);
            this.txbMenor.Name = "txbMenor";
            this.txbMenor.Size = new System.Drawing.Size(327, 27);
            this.txbMenor.TabIndex = 7;
            this.txbMenor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(496, 153);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(75, 23);
            this.btnConferir.TabIndex = 8;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(496, 112);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(663, 352);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.txbMenor);
            this.Controls.Add(this.txbMaior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNum3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNum1;
        private Label label1;
        private Label label2;
        private TextBox txbNum2;
        private Label label3;
        private TextBox txbNum3;
        private TextBox txbMaior;
        private TextBox txbMenor;
        private Button btnConferir;
        private Button btnLimpar;
    }
}