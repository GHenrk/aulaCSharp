namespace Exemplo01
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ch = new System.Windows.Forms.Button();
            this.btn_cs = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chevetteHatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chevetteSedanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(115, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1071, 89);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-vindo ao Clube do Chevette";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Exemplo01.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(332, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_ch
            // 
            this.btn_ch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ch.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ch.Location = new System.Drawing.Point(332, 672);
            this.btn_ch.Name = "btn_ch";
            this.btn_ch.Size = new System.Drawing.Size(204, 47);
            this.btn_ch.TabIndex = 3;
            this.btn_ch.Text = "Chevette Hatch";
            this.btn_ch.UseVisualStyleBackColor = false;
            this.btn_ch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cs
            // 
            this.btn_cs.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_cs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cs.Location = new System.Drawing.Point(758, 672);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(204, 47);
            this.btn_cs.TabIndex = 4;
            this.btn_cs.Text = "Chevette Sedan";
            this.btn_cs.UseVisualStyleBackColor = false;
            this.btn_cs.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_fechar.Location = new System.Drawing.Point(758, 61);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(204, 47);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aplicativosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "Menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.chevetteHatchToolStripMenuItem,
            this.chevetteSedanToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // chevetteHatchToolStripMenuItem
            // 
            this.chevetteHatchToolStripMenuItem.Name = "chevetteHatchToolStripMenuItem";
            this.chevetteHatchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chevetteHatchToolStripMenuItem.Text = "Chevette Hatch";
            this.chevetteHatchToolStripMenuItem.Click += new System.EventHandler(this.chevetteHatchToolStripMenuItem_Click);
            // 
            // chevetteSedanToolStripMenuItem
            // 
            this.chevetteSedanToolStripMenuItem.Name = "chevetteSedanToolStripMenuItem";
            this.chevetteSedanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chevetteSedanToolStripMenuItem.Text = "Chevette Sedan";
            this.chevetteSedanToolStripMenuItem.Click += new System.EventHandler(this.chevetteSedanToolStripMenuItem_Click);
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blocoDeNotasToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            this.aplicativosToolStripMenuItem.Click += new System.EventHandler(this.aplicativosToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1264, 881);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.btn_ch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_ch;
        private Button btn_cs;
        private Button btn_fechar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private ToolStripMenuItem chevetteHatchToolStripMenuItem;
        private ToolStripMenuItem chevetteSedanToolStripMenuItem;
        private ToolStripMenuItem aplicativosToolStripMenuItem;
        private ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private ToolStripMenuItem paintToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
    }
}