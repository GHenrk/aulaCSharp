namespace Cliente_Produto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.txbLimite = new System.Windows.Forms.TextBox();
            this.txbNumCartao = new System.Windows.Forms.TextBox();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classe Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Limite de crédito:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(48, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nº do cartão:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(115, 132);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(308, 23);
            this.txbNome.TabIndex = 7;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(139, 184);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(284, 23);
            this.txbEndereco.TabIndex = 8;
            // 
            // txbContato
            // 
            this.txbContato.Location = new System.Drawing.Point(129, 236);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(294, 23);
            this.txbContato.TabIndex = 9;
            // 
            // txbLimite
            // 
            this.txbLimite.Location = new System.Drawing.Point(197, 340);
            this.txbLimite.Name = "txbLimite";
            this.txbLimite.Size = new System.Drawing.Size(226, 23);
            this.txbLimite.TabIndex = 11;
            // 
            // txbNumCartao
            // 
            this.txbNumCartao.Location = new System.Drawing.Point(164, 392);
            this.txbNumCartao.Name = "txbNumCartao";
            this.txbNumCartao.Size = new System.Drawing.Size(259, 23);
            this.txbNumCartao.TabIndex = 12;
            // 
            // dtNasc
            // 
            this.dtNasc.Location = new System.Drawing.Point(223, 286);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(200, 23);
            this.dtNasc.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(139, 451);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(177, 43);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Efetuar cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(482, 651);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.txbNumCartao);
            this.Controls.Add(this.txbLimite);
            this.Controls.Add(this.txbContato);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txbNome;
        private TextBox txbEndereco;
        private TextBox txbContato;
        private TextBox txbLimite;
        private TextBox txbNumCartao;
        private DateTimePicker dtNasc;
        private Button btnCadastrar;
    }
}