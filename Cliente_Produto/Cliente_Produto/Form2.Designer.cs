namespace Cliente_Produto
{
    partial class Form2
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
            this.txbNome1 = new System.Windows.Forms.TextBox();
            this.txbEndereco1 = new System.Windows.Forms.TextBox();
            this.txbContato1 = new System.Windows.Forms.TextBox();
            this.txbLimite1 = new System.Windows.Forms.TextBox();
            this.txbNumCartao1 = new System.Windows.Forms.TextBox();
            this.DtNasc = new System.Windows.Forms.DateTimePicker();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revise os Dados Cadastrados";
            // 
            // txbNome1
            // 
            this.txbNome1.BackColor = System.Drawing.Color.Teal;
            this.txbNome1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNome1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome1.Location = new System.Drawing.Point(107, 133);
            this.txbNome1.Name = "txbNome1";
            this.txbNome1.ReadOnly = true;
            this.txbNome1.Size = new System.Drawing.Size(362, 27);
            this.txbNome1.TabIndex = 1;
            this.txbNome1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbEndereco1
            // 
            this.txbEndereco1.BackColor = System.Drawing.Color.Teal;
            this.txbEndereco1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEndereco1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEndereco1.Location = new System.Drawing.Point(107, 178);
            this.txbEndereco1.Name = "txbEndereco1";
            this.txbEndereco1.ReadOnly = true;
            this.txbEndereco1.Size = new System.Drawing.Size(362, 27);
            this.txbEndereco1.TabIndex = 2;
            this.txbEndereco1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbContato1
            // 
            this.txbContato1.BackColor = System.Drawing.Color.Teal;
            this.txbContato1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContato1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContato1.Location = new System.Drawing.Point(107, 223);
            this.txbContato1.Name = "txbContato1";
            this.txbContato1.ReadOnly = true;
            this.txbContato1.Size = new System.Drawing.Size(362, 27);
            this.txbContato1.TabIndex = 3;
            this.txbContato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbLimite1
            // 
            this.txbLimite1.BackColor = System.Drawing.Color.Teal;
            this.txbLimite1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLimite1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLimite1.Location = new System.Drawing.Point(107, 313);
            this.txbLimite1.Name = "txbLimite1";
            this.txbLimite1.ReadOnly = true;
            this.txbLimite1.Size = new System.Drawing.Size(362, 27);
            this.txbLimite1.TabIndex = 5;
            this.txbLimite1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNumCartao1
            // 
            this.txbNumCartao1.BackColor = System.Drawing.Color.Teal;
            this.txbNumCartao1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumCartao1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumCartao1.Location = new System.Drawing.Point(107, 358);
            this.txbNumCartao1.Name = "txbNumCartao1";
            this.txbNumCartao1.ReadOnly = true;
            this.txbNumCartao1.Size = new System.Drawing.Size(362, 27);
            this.txbNumCartao1.TabIndex = 6;
            this.txbNumCartao1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DtNasc
            // 
            this.DtNasc.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtNasc.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.DtNasc.Location = new System.Drawing.Point(107, 274);
            this.DtNasc.Name = "DtNasc";
            this.DtNasc.Size = new System.Drawing.Size(362, 23);
            this.DtNasc.TabIndex = 7;
            this.DtNasc.ValueChanged += new System.EventHandler(this.DtNasc_ValueChanged);
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.Black;
            this.txbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbStatus.Location = new System.Drawing.Point(212, 547);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(236, 22);
            this.txbStatus.TabIndex = 8;
            this.txbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(140, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "STATUS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(254, 594);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 43);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(607, 649);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.DtNasc);
            this.Controls.Add(this.txbNumCartao1);
            this.Controls.Add(this.txbLimite1);
            this.Controls.Add(this.txbContato1);
            this.Controls.Add(this.txbEndereco1);
            this.Controls.Add(this.txbNome1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbNome1;
        private TextBox txbEndereco1;
        private TextBox txbContato1;
        private TextBox txbLimite1;
        private TextBox txbNumCartao1;
        private DateTimePicker DtNasc;
        private TextBox txbStatus;
        private Label label2;
        private Button btnOk;
    }
}