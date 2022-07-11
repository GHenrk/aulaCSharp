namespace Exemplo01
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cs = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_sairJanela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exemplo01.Properties.Resources.chevette_hatch;
            this.pictureBox1.Location = new System.Drawing.Point(351, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(448, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 89);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chevette Hatch";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cs
            // 
            this.btn_cs.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_cs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cs.Location = new System.Drawing.Point(777, 582);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(204, 47);
            this.btn_cs.TabIndex = 7;
            this.btn_cs.TabStop = false;
            this.btn_cs.Text = "Chevette Sedan";
            this.btn_cs.UseVisualStyleBackColor = false;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_home.Location = new System.Drawing.Point(351, 582);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(204, 47);
            this.btn_home.TabIndex = 6;
            this.btn_home.TabStop = false;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_ch_Click);
            // 
            // btn_sairJanela
            // 
            this.btn_sairJanela.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_sairJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sairJanela.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sairJanela.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sairJanela.Location = new System.Drawing.Point(777, 33);
            this.btn_sairJanela.Name = "btn_sairJanela";
            this.btn_sairJanela.Size = new System.Drawing.Size(204, 47);
            this.btn_sairJanela.TabIndex = 8;
            this.btn_sairJanela.Text = "Fechar";
            this.btn_sairJanela.UseVisualStyleBackColor = false;
            this.btn_sairJanela.Click += new System.EventHandler(this.btn_sairJanela_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_sairJanela);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_cs;
        private Button btn_home;
        private Button btn_sairJanela;
    }
}