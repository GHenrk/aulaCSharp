namespace DiagramaClasses
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
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoFab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnMoto = new System.Windows.Forms.Button();
            this.btnBarcos = new System.Windows.Forms.Button();
            this.btnJet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marca,
            this.modelo,
            this.proprietario,
            this.valor,
            this.anoFab});
            this.dtGrid.Location = new System.Drawing.Point(12, 88);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.RowTemplate.Height = 25;
            this.dtGrid.Size = new System.Drawing.Size(744, 350);
            this.dtGrid.TabIndex = 16;
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca:";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo:";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 150;
            // 
            // proprietario
            // 
            this.proprietario.HeaderText = "Proprietário:";
            this.proprietario.Name = "proprietario";
            this.proprietario.ReadOnly = true;
            this.proprietario.Width = 200;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor:";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 150;
            // 
            // anoFab
            // 
            this.anoFab.HeaderText = "Ano Fab.";
            this.anoFab.Name = "anoFab";
            this.anoFab.ReadOnly = true;
            // 
            // btnCarro
            // 
            this.btnCarro.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarro.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarro.Location = new System.Drawing.Point(15, 27);
            this.btnCarro.Margin = new System.Windows.Forms.Padding(6);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(167, 40);
            this.btnCarro.TabIndex = 17;
            this.btnCarro.Text = "Carros";
            this.btnCarro.UseVisualStyleBackColor = false;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // btnMoto
            // 
            this.btnMoto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoto.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMoto.Location = new System.Drawing.Point(194, 27);
            this.btnMoto.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoto.Name = "btnMoto";
            this.btnMoto.Size = new System.Drawing.Size(167, 40);
            this.btnMoto.TabIndex = 18;
            this.btnMoto.Text = "Motos";
            this.btnMoto.UseVisualStyleBackColor = false;
            // 
            // btnBarcos
            // 
            this.btnBarcos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBarcos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarcos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBarcos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnBarcos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBarcos.Location = new System.Drawing.Point(373, 27);
            this.btnBarcos.Margin = new System.Windows.Forms.Padding(6);
            this.btnBarcos.Name = "btnBarcos";
            this.btnBarcos.Size = new System.Drawing.Size(167, 40);
            this.btnBarcos.TabIndex = 19;
            this.btnBarcos.Text = "Barcos";
            this.btnBarcos.UseVisualStyleBackColor = false;
            // 
            // btnJet
            // 
            this.btnJet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnJet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJet.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnJet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnJet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJet.Location = new System.Drawing.Point(552, 27);
            this.btnJet.Margin = new System.Windows.Forms.Padding(6);
            this.btnJet.Name = "btnJet";
            this.btnJet.Size = new System.Drawing.Size(167, 40);
            this.btnJet.TabIndex = 20;
            this.btnJet.Text = "JetSkis";
            this.btnJet.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJet);
            this.Controls.Add(this.btnBarcos);
            this.Controls.Add(this.btnMoto);
            this.Controls.Add(this.btnCarro);
            this.Controls.Add(this.dtGrid);
            this.Name = "Form3";
            this.Text = "Visualizar Cadastros";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dtGrid;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn proprietario;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn anoFab;
        private Button btnCarro;
        private Button btnMoto;
        private Button btnBarcos;
        private Button btnJet;
    }
}