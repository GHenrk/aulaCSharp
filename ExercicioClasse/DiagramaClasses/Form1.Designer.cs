namespace DiagramaClasses
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
            this.gpOpcoes = new System.Windows.Forms.GroupBox();
            this.rdAqua = new System.Windows.Forms.RadioButton();
            this.rdTerrestre = new System.Windows.Forms.RadioButton();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.gpOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Veículos";
            // 
            // gpOpcoes
            // 
            this.gpOpcoes.Controls.Add(this.rdAqua);
            this.gpOpcoes.Controls.Add(this.rdTerrestre);
            this.gpOpcoes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpOpcoes.Location = new System.Drawing.Point(124, 167);
            this.gpOpcoes.Name = "gpOpcoes";
            this.gpOpcoes.Size = new System.Drawing.Size(520, 115);
            this.gpOpcoes.TabIndex = 1;
            this.gpOpcoes.TabStop = false;
            this.gpOpcoes.Text = "Tipo de Veículo:";
            // 
            // rdAqua
            // 
            this.rdAqua.AutoSize = true;
            this.rdAqua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdAqua.Location = new System.Drawing.Point(297, 48);
            this.rdAqua.Name = "rdAqua";
            this.rdAqua.Size = new System.Drawing.Size(105, 29);
            this.rdAqua.TabIndex = 1;
            this.rdAqua.TabStop = true;
            this.rdAqua.Text = "Aquático";
            this.rdAqua.UseVisualStyleBackColor = true;
            this.rdAqua.CheckedChanged += new System.EventHandler(this.rdAqua_CheckedChanged);
            // 
            // rdTerrestre
            // 
            this.rdTerrestre.AutoSize = true;
            this.rdTerrestre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdTerrestre.Location = new System.Drawing.Point(103, 48);
            this.rdTerrestre.Name = "rdTerrestre";
            this.rdTerrestre.Size = new System.Drawing.Size(103, 29);
            this.rdTerrestre.TabIndex = 0;
            this.rdTerrestre.TabStop = true;
            this.rdTerrestre.Text = "Terrestre";
            this.rdTerrestre.UseVisualStyleBackColor = true;
            this.rdTerrestre.CheckedChanged += new System.EventHandler(this.rdTerrestre_CheckedChanged);
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(333, 317);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(210, 33);
            this.cbOpcoes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(236, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veículo:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(205, 423);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(177, 40);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Efetuar Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(388, 423);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(167, 40);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVisualize
            // 
            this.btnVisualize.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVisualize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualize.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnVisualize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnVisualize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualize.Location = new System.Drawing.Point(205, 475);
            this.btnVisualize.Margin = new System.Windows.Forms.Padding(6);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(350, 40);
            this.btnVisualize.TabIndex = 13;
            this.btnVisualize.Text = "Visualizar Veículos Cadastrados";
            this.btnVisualize.UseVisualStyleBackColor = false;
            this.btnVisualize.Click += new System.EventHandler(this.btnVisualize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVisualize);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOpcoes);
            this.Controls.Add(this.gpOpcoes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Veículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpOpcoes.ResumeLayout(false);
            this.gpOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox gpOpcoes;
        private RadioButton rdAqua;
        private RadioButton rdTerrestre;
        private ComboBox cbOpcoes;
        private Label label2;
        private Button btnCadastrar;
        private Button btnSair;
        private Button btnVisualize;
    }
}