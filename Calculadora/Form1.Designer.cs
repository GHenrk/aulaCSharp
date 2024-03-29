﻿namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.btn_maisOuMenos = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_virgula = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_porcentagem = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_raizQuadrada = new System.Windows.Forms.Button();
            this.btn_elevado = new System.Windows.Forms.Button();
            this.btn_numeroInverso = new System.Windows.Forms.Button();
            this.txbSecundario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbResultado
            // 
            this.txbResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbResultado.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbResultado.Location = new System.Drawing.Point(18, 145);
            this.txbResultado.Margin = new System.Windows.Forms.Padding(5);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(299, 45);
            this.txbResultado.TabIndex = 0;
            this.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_maisOuMenos
            // 
            this.btn_maisOuMenos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_maisOuMenos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_maisOuMenos.FlatAppearance.BorderSize = 0;
            this.btn_maisOuMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maisOuMenos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_maisOuMenos.Location = new System.Drawing.Point(5, 464);
            this.btn_maisOuMenos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_maisOuMenos.Name = "btn_maisOuMenos";
            this.btn_maisOuMenos.Size = new System.Drawing.Size(75, 50);
            this.btn_maisOuMenos.TabIndex = 1;
            this.btn_maisOuMenos.Text = "+/-";
            this.btn_maisOuMenos.UseMnemonic = false;
            this.btn_maisOuMenos.UseVisualStyleBackColor = false;
            this.btn_maisOuMenos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_zero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_zero.FlatAppearance.BorderSize = 0;
            this.btn_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_zero.Location = new System.Drawing.Point(84, 464);
            this.btn_zero.Margin = new System.Windows.Forms.Padding(2);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(75, 50);
            this.btn_zero.TabIndex = 2;
            this.btn_zero.Text = "0";
            this.btn_zero.UseMnemonic = false;
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_virgula
            // 
            this.btn_virgula.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_virgula.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_virgula.FlatAppearance.BorderSize = 0;
            this.btn_virgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_virgula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_virgula.Location = new System.Drawing.Point(163, 464);
            this.btn_virgula.Margin = new System.Windows.Forms.Padding(2);
            this.btn_virgula.Name = "btn_virgula";
            this.btn_virgula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_virgula.Size = new System.Drawing.Size(75, 50);
            this.btn_virgula.TabIndex = 3;
            this.btn_virgula.Text = ",";
            this.btn_virgula.UseMnemonic = false;
            this.btn_virgula.UseVisualStyleBackColor = false;
            this.btn_virgula.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_igual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_igual.FlatAppearance.BorderSize = 0;
            this.btn_igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_igual.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_igual.Location = new System.Drawing.Point(242, 464);
            this.btn_igual.Margin = new System.Windows.Forms.Padding(2);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(75, 50);
            this.btn_igual.TabIndex = 4;
            this.btn_igual.Text = "=";
            this.btn_igual.UseMnemonic = false;
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_mais
            // 
            this.btn_mais.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_mais.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_mais.FlatAppearance.BorderSize = 0;
            this.btn_mais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mais.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_mais.Location = new System.Drawing.Point(242, 410);
            this.btn_mais.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(75, 50);
            this.btn_mais.TabIndex = 8;
            this.btn_mais.Text = "+";
            this.btn_mais.UseMnemonic = false;
            this.btn_mais.UseVisualStyleBackColor = false;
            this.btn_mais.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(163, 410);
            this.btn_3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 50);
            this.btn_3.TabIndex = 7;
            this.btn_3.Text = "3";
            this.btn_3.UseMnemonic = false;
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(84, 410);
            this.btn_2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 50);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "2";
            this.btn_2.UseMnemonic = false;
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(5, 410);
            this.btn_1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 50);
            this.btn_1.TabIndex = 5;
            this.btn_1.Text = "1";
            this.btn_1.UseMnemonic = false;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_multi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_multi.FlatAppearance.BorderSize = 0;
            this.btn_multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_multi.Location = new System.Drawing.Point(242, 303);
            this.btn_multi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(75, 50);
            this.btn_multi.TabIndex = 16;
            this.btn_multi.Text = "X";
            this.btn_multi.UseMnemonic = false;
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(163, 303);
            this.btn_9.Margin = new System.Windows.Forms.Padding(2);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 50);
            this.btn_9.TabIndex = 15;
            this.btn_9.Text = "9";
            this.btn_9.UseMnemonic = false;
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(84, 303);
            this.btn_8.Margin = new System.Windows.Forms.Padding(2);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 50);
            this.btn_8.TabIndex = 14;
            this.btn_8.Text = "8";
            this.btn_8.UseMnemonic = false;
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(5, 303);
            this.btn_7.Margin = new System.Windows.Forms.Padding(2);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 50);
            this.btn_7.TabIndex = 13;
            this.btn_7.Text = "7";
            this.btn_7.UseMnemonic = false;
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_menos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menos.FlatAppearance.BorderSize = 0;
            this.btn_menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_menos.Location = new System.Drawing.Point(242, 357);
            this.btn_menos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(75, 50);
            this.btn_menos.TabIndex = 12;
            this.btn_menos.Text = "-";
            this.btn_menos.UseMnemonic = false;
            this.btn_menos.UseVisualStyleBackColor = false;
            this.btn_menos.Click += new System.EventHandler(this.btn_menos_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(163, 357);
            this.btn_6.Margin = new System.Windows.Forms.Padding(2);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 50);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseMnemonic = false;
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(84, 357);
            this.btn_5.Margin = new System.Windows.Forms.Padding(2);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 50);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseMnemonic = false;
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(5, 357);
            this.btn_4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 50);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseMnemonic = false;
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.button16_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_backspace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_backspace.FlatAppearance.BorderSize = 0;
            this.btn_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backspace.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_backspace.Location = new System.Drawing.Point(242, 197);
            this.btn_backspace.Margin = new System.Windows.Forms.Padding(2);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(75, 50);
            this.btn_backspace.TabIndex = 24;
            this.btn_backspace.Text = "⌫";
            this.btn_backspace.UseMnemonic = false;
            this.btn_backspace.UseVisualStyleBackColor = false;
            this.btn_backspace.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gainsboro;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.Location = new System.Drawing.Point(163, 197);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 50);
            this.button18.TabIndex = 23;
            this.button18.Text = "C";
            this.button18.UseMnemonic = false;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ce.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ce.FlatAppearance.BorderSize = 0;
            this.btn_ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ce.Location = new System.Drawing.Point(84, 197);
            this.btn_ce.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(75, 50);
            this.btn_ce.TabIndex = 22;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseMnemonic = false;
            this.btn_ce.UseVisualStyleBackColor = false;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // btn_porcentagem
            // 
            this.btn_porcentagem.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_porcentagem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_porcentagem.FlatAppearance.BorderSize = 0;
            this.btn_porcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_porcentagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_porcentagem.Location = new System.Drawing.Point(5, 197);
            this.btn_porcentagem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_porcentagem.Name = "btn_porcentagem";
            this.btn_porcentagem.Size = new System.Drawing.Size(75, 50);
            this.btn_porcentagem.TabIndex = 21;
            this.btn_porcentagem.Text = "%";
            this.btn_porcentagem.UseMnemonic = false;
            this.btn_porcentagem.UseVisualStyleBackColor = false;
            this.btn_porcentagem.Click += new System.EventHandler(this.btn_porcentagem_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_div.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_div.FlatAppearance.BorderSize = 0;
            this.btn_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_div.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_div.Location = new System.Drawing.Point(242, 251);
            this.btn_div.Margin = new System.Windows.Forms.Padding(2);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 50);
            this.btn_div.TabIndex = 20;
            this.btn_div.Text = "÷";
            this.btn_div.UseMnemonic = false;
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_raizQuadrada
            // 
            this.btn_raizQuadrada.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_raizQuadrada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_raizQuadrada.FlatAppearance.BorderSize = 0;
            this.btn_raizQuadrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raizQuadrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_raizQuadrada.Location = new System.Drawing.Point(163, 251);
            this.btn_raizQuadrada.Margin = new System.Windows.Forms.Padding(2);
            this.btn_raizQuadrada.Name = "btn_raizQuadrada";
            this.btn_raizQuadrada.Size = new System.Drawing.Size(75, 50);
            this.btn_raizQuadrada.TabIndex = 19;
            this.btn_raizQuadrada.Text = "²√x";
            this.btn_raizQuadrada.UseMnemonic = false;
            this.btn_raizQuadrada.UseVisualStyleBackColor = false;
            this.btn_raizQuadrada.Click += new System.EventHandler(this.button22_Click);
            // 
            // btn_elevado
            // 
            this.btn_elevado.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_elevado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_elevado.FlatAppearance.BorderSize = 0;
            this.btn_elevado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elevado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_elevado.Location = new System.Drawing.Point(84, 251);
            this.btn_elevado.Margin = new System.Windows.Forms.Padding(2);
            this.btn_elevado.Name = "btn_elevado";
            this.btn_elevado.Size = new System.Drawing.Size(75, 50);
            this.btn_elevado.TabIndex = 18;
            this.btn_elevado.Text = "x²";
            this.btn_elevado.UseMnemonic = false;
            this.btn_elevado.UseVisualStyleBackColor = false;
            this.btn_elevado.Click += new System.EventHandler(this.button23_Click);
            // 
            // btn_numeroInverso
            // 
            this.btn_numeroInverso.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_numeroInverso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_numeroInverso.FlatAppearance.BorderSize = 0;
            this.btn_numeroInverso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_numeroInverso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_numeroInverso.Location = new System.Drawing.Point(5, 251);
            this.btn_numeroInverso.Margin = new System.Windows.Forms.Padding(2);
            this.btn_numeroInverso.Name = "btn_numeroInverso";
            this.btn_numeroInverso.Size = new System.Drawing.Size(75, 50);
            this.btn_numeroInverso.TabIndex = 17;
            this.btn_numeroInverso.Text = "¹/x";
            this.btn_numeroInverso.UseMnemonic = false;
            this.btn_numeroInverso.UseVisualStyleBackColor = false;
            this.btn_numeroInverso.Click += new System.EventHandler(this.button24_Click);
            // 
            // txbSecundario
            // 
            this.txbSecundario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbSecundario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSecundario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSecundario.Location = new System.Drawing.Point(138, 108);
            this.txbSecundario.Margin = new System.Windows.Forms.Padding(5);
            this.txbSecundario.Name = "txbSecundario";
            this.txbSecundario.Size = new System.Drawing.Size(179, 27);
            this.txbSecundario.TabIndex = 25;
            this.txbSecundario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(323, 525);
            this.Controls.Add(this.txbSecundario);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_porcentagem);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_raizQuadrada);
            this.Controls.Add(this.btn_elevado);
            this.Controls.Add(this.btn_numeroInverso);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_mais);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_virgula);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_maisOuMenos);
            this.Controls.Add(this.txbResultado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbResultado;
        private Button btn_maisOuMenos;
        private Button btn_zero;
        private Button btn_virgula;
        private Button btn_igual;
        private Button btn_mais;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_multi;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_menos;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_backspace;
        private Button button18;
        private Button btn_ce;
        private Button btn_porcentagem;
        private Button btn_div;
        private Button btn_raizQuadrada;
        private Button btn_elevado;
        private Button btn_numeroInverso;
        private TextBox txbSecundario;
    }
}