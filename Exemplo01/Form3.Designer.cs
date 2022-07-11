namespace Exemplo01
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sairJanela = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_ch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exemplo01.Properties.Resources.chevettao;
            this.pictureBox1.Location = new System.Drawing.Point(339, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(414, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 89);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chevette Sedan";
            // 
            // btn_sairJanela
            // 
            this.btn_sairJanela.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_sairJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sairJanela.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sairJanela.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sairJanela.Location = new System.Drawing.Point(765, 39);
            this.btn_sairJanela.Name = "btn_sairJanela";
            this.btn_sairJanela.Size = new System.Drawing.Size(204, 47);
            this.btn_sairJanela.TabIndex = 3;
            this.btn_sairJanela.Text = "Fechar";
            this.btn_sairJanela.UseVisualStyleBackColor = false;
            this.btn_sairJanela.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_home.Location = new System.Drawing.Point(339, 578);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(204, 47);
            this.btn_home.TabIndex = 8;
            this.btn_home.TabStop = false;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_ch
            // 
            this.btn_ch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ch.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ch.Location = new System.Drawing.Point(765, 578);
            this.btn_ch.Name = "btn_ch";
            this.btn_ch.Size = new System.Drawing.Size(204, 47);
            this.btn_ch.TabIndex = 9;
            this.btn_ch.Text = "Chevette Hatch";
            this.btn_ch.UseVisualStyleBackColor = false;
            this.btn_ch.Click += new System.EventHandler(this.btn_ch_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_ch);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sairJanela);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_sairJanela;
        private Button btn_home;
        private Button btn_ch;
    }
}