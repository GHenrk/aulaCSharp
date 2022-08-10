namespace ClasseHeranca
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
            this.lblCadastro = new System.Windows.Forms.Label();
            this.gpBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnAluno = new System.Windows.Forms.RadioButton();
            this.rdBtnProfessor = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbFilhos = new System.Windows.Forms.TextBox();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txbNota1 = new System.Windows.Forms.TextBox();
            this.txbNota2 = new System.Windows.Forms.TextBox();
            this.txbNota3 = new System.Windows.Forms.TextBox();
            this.txbMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txbCPF2 = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.gpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastro.Location = new System.Drawing.Point(242, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(115, 32);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastro";
            // 
            // gpBox1
            // 
            this.gpBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gpBox1.Controls.Add(this.rdBtnAluno);
            this.gpBox1.Controls.Add(this.rdBtnProfessor);
            this.gpBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpBox1.Location = new System.Drawing.Point(127, 67);
            this.gpBox1.Name = "gpBox1";
            this.gpBox1.Size = new System.Drawing.Size(360, 100);
            this.gpBox1.TabIndex = 1;
            this.gpBox1.TabStop = false;
            this.gpBox1.Text = "Quem você deseja cadastrar?";
            // 
            // rdBtnAluno
            // 
            this.rdBtnAluno.AutoSize = true;
            this.rdBtnAluno.Location = new System.Drawing.Point(206, 46);
            this.rdBtnAluno.Name = "rdBtnAluno";
            this.rdBtnAluno.Size = new System.Drawing.Size(74, 25);
            this.rdBtnAluno.TabIndex = 1;
            this.rdBtnAluno.TabStop = true;
            this.rdBtnAluno.Text = "Aluno";
            this.rdBtnAluno.UseVisualStyleBackColor = true;
            this.rdBtnAluno.CheckedChanged += new System.EventHandler(this.rdBtnAluno_CheckedChanged);
            // 
            // rdBtnProfessor
            // 
            this.rdBtnProfessor.AutoSize = true;
            this.rdBtnProfessor.Location = new System.Drawing.Point(60, 46);
            this.rdBtnProfessor.Name = "rdBtnProfessor";
            this.rdBtnProfessor.Size = new System.Drawing.Size(99, 25);
            this.rdBtnProfessor.TabIndex = 0;
            this.rdBtnProfessor.TabStop = true;
            this.rdBtnProfessor.Text = "Professor";
            this.rdBtnProfessor.UseVisualStyleBackColor = true;
            this.rdBtnProfessor.CheckedChanged += new System.EventHandler(this.rdBtnProfessor_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(78, 180);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 32);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatricula.Location = new System.Drawing.Point(76, 249);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(130, 32);
            this.lblMatricula.TabIndex = 3;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.Location = new System.Drawing.Point(388, 181);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(99, 32);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(127, 495);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(178, 54);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Efetuar Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(78, 216);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(264, 29);
            this.txbNome.TabIndex = 7;
            // 
            // txbMatricula
            // 
            this.txbMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMatricula.Location = new System.Drawing.Point(78, 285);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(258, 29);
            this.txbMatricula.TabIndex = 8;
            // 
            // txbSalario
            // 
            this.txbSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSalario.Location = new System.Drawing.Point(388, 216);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(136, 29);
            this.txbSalario.TabIndex = 10;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(311, 495);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(176, 54);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbFilhos
            // 
            this.txbFilhos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbFilhos.Location = new System.Drawing.Point(388, 292);
            this.txbFilhos.Name = "txbFilhos";
            this.txbFilhos.ReadOnly = true;
            this.txbFilhos.Size = new System.Drawing.Size(136, 29);
            this.txbFilhos.TabIndex = 13;
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilhos.Location = new System.Drawing.Point(388, 257);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(87, 32);
            this.lblFilhos.TabIndex = 12;
            this.lblFilhos.Text = "Filhos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "CPF:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.Location = new System.Drawing.Point(388, 335);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(102, 29);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.Location = new System.Drawing.Point(388, 370);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(102, 29);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNota1.Location = new System.Drawing.Point(389, 181);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(98, 32);
            this.lblNota1.TabIndex = 18;
            this.lblNota1.Text = "Nota 1:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNota2.Location = new System.Drawing.Point(389, 250);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(98, 32);
            this.lblNota2.TabIndex = 19;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNota3.Location = new System.Drawing.Point(386, 319);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(98, 32);
            this.lblNota3.TabIndex = 20;
            this.lblNota3.Text = "Nota 3:";
            // 
            // txbNota1
            // 
            this.txbNota1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota1.Location = new System.Drawing.Point(389, 217);
            this.txbNota1.Name = "txbNota1";
            this.txbNota1.Size = new System.Drawing.Size(103, 29);
            this.txbNota1.TabIndex = 21;
            // 
            // txbNota2
            // 
            this.txbNota2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota2.Location = new System.Drawing.Point(389, 286);
            this.txbNota2.Name = "txbNota2";
            this.txbNota2.Size = new System.Drawing.Size(103, 29);
            this.txbNota2.TabIndex = 22;
            // 
            // txbNota3
            // 
            this.txbNota3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota3.Location = new System.Drawing.Point(389, 355);
            this.txbNota3.Name = "txbNota3";
            this.txbNota3.Size = new System.Drawing.Size(103, 29);
            this.txbNota3.TabIndex = 23;
            // 
            // txbMedia
            // 
            this.txbMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMedia.Location = new System.Drawing.Point(389, 434);
            this.txbMedia.Name = "txbMedia";
            this.txbMedia.Size = new System.Drawing.Size(103, 29);
            this.txbMedia.TabIndex = 24;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedia.Location = new System.Drawing.Point(389, 399);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(92, 32);
            this.lblMedia.TabIndex = 25;
            this.lblMedia.Text = "Media:";
            // 
            // txbCPF2
            // 
            this.txbCPF2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCPF2.Location = new System.Drawing.Point(76, 354);
            this.txbCPF2.Name = "txbCPF2";
            this.txbCPF2.Size = new System.Drawing.Size(258, 29);
            this.txbCPF2.TabIndex = 27;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(78, 399);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(0, 19);
            this.lblCPF.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(616, 561);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbCPF2);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txbMedia);
            this.Controls.Add(this.txbNota3);
            this.Controls.Add(this.txbNota2);
            this.Controls.Add(this.txbNota1);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFilhos);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbSalario);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gpBox1);
            this.Controls.Add(this.lblCadastro);
            this.Name = "Form1";
            this.Text = "Herança de Pessoa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBox1.ResumeLayout(false);
            this.gpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCadastro;
        private GroupBox gpBox1;
        private RadioButton rdBtnAluno;
        private RadioButton rdBtnProfessor;
        private Label lblNome;
        private Label lblMatricula;
        private Label lblSalario;
        private Button btnCadastrar;
        private TextBox txbNome;
        private TextBox txbMatricula;
        private TextBox txbSalario;
        private Button btnLimpar;
        private TextBox txbFilhos;
        private Label lblFilhos;
        private Label label2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private TextBox txbNota1;
        private TextBox txbNota2;
        private TextBox txbNota3;
        private TextBox txbMedia;
        private Label lblMedia;
        private TextBox txbCPF2;
        private Label lblCPF;
    }
}