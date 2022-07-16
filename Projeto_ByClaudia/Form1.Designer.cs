namespace Projeto_ByClaudia
{
    partial class PrimeiroExemplo
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
            this.TituloPrincipal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.txbAcesso = new System.Windows.Forms.TextBox();
            this.lbl_Acesso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloPrincipal
            // 
            this.TituloPrincipal.AutoSize = true;
            this.TituloPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.TituloPrincipal.Font = new System.Drawing.Font("Stencil", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TituloPrincipal.ForeColor = System.Drawing.Color.OliveDrab;
            this.TituloPrincipal.Location = new System.Drawing.Point(58, 90);
            this.TituloPrincipal.Name = "TituloPrincipal";
            this.TituloPrincipal.Size = new System.Drawing.Size(637, 56);
            this.TituloPrincipal.TabIndex = 0;
            this.TituloPrincipal.Text = "Clube dos chevetteiros";
            this.TituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TituloPrincipal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(155, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(159, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano de nascimento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(251, 241);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(437, 29);
            this.txbNome.TabIndex = 3;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbNumero
            // 
            this.txbNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumero.Location = new System.Drawing.Point(407, 291);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(281, 29);
            this.txbNumero.TabIndex = 4;
            this.txbNumero.TextChanged += new System.EventHandler(this.txbNumero_TextChanged);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.Location = new System.Drawing.Point(120, 548);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(162, 51);
            this.btn_confirmar.TabIndex = 5;
            this.btn_confirmar.Text = "&Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ByClaudia.Properties.Resources.chevettao;
            this.pictureBox1.Location = new System.Drawing.Point(701, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_verificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_verificar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verificar.Location = new System.Drawing.Point(288, 548);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(162, 51);
            this.btn_verificar.TabIndex = 9;
            this.btn_verificar.Text = "&Verificar";
            this.btn_verificar.UseVisualStyleBackColor = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.DarkGray;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.Location = new System.Drawing.Point(624, 548);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(162, 51);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(456, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "&Idade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Enabled = false;
            this.btn_limpar.Location = new System.Drawing.Point(407, 507);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbIdade
            // 
            this.txbIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbIdade.Location = new System.Drawing.Point(456, 364);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(113, 29);
            this.txbIdade.TabIndex = 14;
            this.txbIdade.Visible = false;
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Idade.Location = new System.Drawing.Point(365, 361);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(85, 32);
            this.lbl_Idade.TabIndex = 13;
            this.lbl_Idade.Text = "Idade:";
            this.lbl_Idade.Visible = false;
            // 
            // txbAcesso
            // 
            this.txbAcesso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbAcesso.Location = new System.Drawing.Point(456, 461);
            this.txbAcesso.Name = "txbAcesso";
            this.txbAcesso.Size = new System.Drawing.Size(162, 29);
            this.txbAcesso.TabIndex = 16;
            this.txbAcesso.Visible = false;
            this.txbAcesso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Acesso
            // 
            this.lbl_Acesso.AutoSize = true;
            this.lbl_Acesso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Acesso.Location = new System.Drawing.Point(350, 455);
            this.lbl_Acesso.Name = "lbl_Acesso";
            this.lbl_Acesso.Size = new System.Drawing.Size(100, 32);
            this.lbl_Acesso.TabIndex = 15;
            this.lbl_Acesso.Text = "Acesso:";
            this.lbl_Acesso.Visible = false;
            this.lbl_Acesso.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // PrimeiroExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(937, 634);
            this.Controls.Add(this.txbAcesso);
            this.Controls.Add(this.lbl_Acesso);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TituloPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PrimeiroExemplo";
            this.Text = "Clube dos Chevetteiros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TituloPrincipal;
        private Label label2;
        private Label label3;
        private TextBox txbNome;
        private TextBox txbNumero;
        private Button btn_confirmar;
        private PictureBox pictureBox1;
        private Button btn_verificar;
        private Button btn_sair;
        private Button button1;
        private Button btn_limpar;
        private TextBox txbIdade;
        private Label lbl_Idade;
        private TextBox txbAcesso;
        private Label lbl_Acesso;
    }
}