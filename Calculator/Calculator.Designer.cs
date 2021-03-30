using System;
using CalculatorLibrary;

namespace Calculator
{
    partial class Calculator
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
            this.Background = new System.Windows.Forms.PictureBox();
            this.Display = new CalculatorLibrary.MyTextBox();
            this.Logo = new System.Windows.Forms.TextBox();
            this.ChargingCell_0 = new System.Windows.Forms.PictureBox();
            this.ChargingCell_1 = new System.Windows.Forms.PictureBox();
            this.ChargingCell_2 = new System.Windows.Forms.PictureBox();
            this.ChargingCell_3 = new System.Windows.Forms.PictureBox();
            this.ChargingCell_4 = new System.Windows.Forms.PictureBox();
            this.ClearAction = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.DecimalPoint = new System.Windows.Forms.Button();
            this.Solve = new System.Windows.Forms.Button();
            this.Seven = new CalculatorLibrary.MyButton();
            this.Eight = new CalculatorLibrary.MyButton();
            this.Nine = new CalculatorLibrary.MyButton();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Four = new CalculatorLibrary.MyButton();
            this.Five = new CalculatorLibrary.MyButton();
            this.Six = new CalculatorLibrary.MyButton();
            this.Addition = new System.Windows.Forms.Button();
            this.One = new CalculatorLibrary.MyButton();
            this.Two = new CalculatorLibrary.MyButton();
            this.Three = new CalculatorLibrary.MyButton();
            this.Subtraction = new System.Windows.Forms.Button();
            this.SignChange = new System.Windows.Forms.Button();
            this.Zero = new CalculatorLibrary.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_4)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Background.Location = new System.Drawing.Point(4, 3);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(300, 432);
            this.Background.TabIndex = 1;
            this.Background.TabStop = false;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.Location = new System.Drawing.Point(13, 24);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(279, 38);
            this.Display.TabIndex = 2;
            this.Display.Text = "0 ";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display.Value_Result = this.Display.Value_Tmp;
            this.Display.Value_Tmp = 0D;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Logo.Location = new System.Drawing.Point(15, 68);
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Size = new System.Drawing.Size(83, 23);
            this.Logo.TabIndex = 3;
            this.Logo.Text = "ZLoo ZL-001";
            this.Logo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ChargingCell_0
            // 
            this.ChargingCell_0.BackColor = System.Drawing.Color.BurlyWood;
            this.ChargingCell_0.Location = new System.Drawing.Point(168, 68);
            this.ChargingCell_0.Margin = new System.Windows.Forms.Padding(1);
            this.ChargingCell_0.Name = "ChargingCell_0";
            this.ChargingCell_0.Size = new System.Drawing.Size(23, 23);
            this.ChargingCell_0.TabIndex = 4;
            this.ChargingCell_0.TabStop = false;
            // 
            // ChargingCell_1
            // 
            this.ChargingCell_1.BackColor = System.Drawing.Color.BurlyWood;
            this.ChargingCell_1.Location = new System.Drawing.Point(193, 68);
            this.ChargingCell_1.Margin = new System.Windows.Forms.Padding(1);
            this.ChargingCell_1.Name = "ChargingCell_1";
            this.ChargingCell_1.Size = new System.Drawing.Size(23, 23);
            this.ChargingCell_1.TabIndex = 5;
            this.ChargingCell_1.TabStop = false;
            // 
            // ChargingCell_2
            // 
            this.ChargingCell_2.BackColor = System.Drawing.Color.BurlyWood;
            this.ChargingCell_2.Location = new System.Drawing.Point(218, 68);
            this.ChargingCell_2.Margin = new System.Windows.Forms.Padding(1);
            this.ChargingCell_2.Name = "ChargingCell_2";
            this.ChargingCell_2.Size = new System.Drawing.Size(23, 23);
            this.ChargingCell_2.TabIndex = 6;
            this.ChargingCell_2.TabStop = false;
            // 
            // ChargingCell_3
            // 
            this.ChargingCell_3.BackColor = System.Drawing.Color.BurlyWood;
            this.ChargingCell_3.Location = new System.Drawing.Point(243, 68);
            this.ChargingCell_3.Margin = new System.Windows.Forms.Padding(1);
            this.ChargingCell_3.Name = "ChargingCell_3";
            this.ChargingCell_3.Size = new System.Drawing.Size(23, 23);
            this.ChargingCell_3.TabIndex = 7;
            this.ChargingCell_3.TabStop = false;
            // 
            // ChargingCell_4
            // 
            this.ChargingCell_4.BackColor = System.Drawing.Color.BurlyWood;
            this.ChargingCell_4.Location = new System.Drawing.Point(268, 68);
            this.ChargingCell_4.Margin = new System.Windows.Forms.Padding(1);
            this.ChargingCell_4.Name = "ChargingCell_4";
            this.ChargingCell_4.Size = new System.Drawing.Size(23, 23);
            this.ChargingCell_4.TabIndex = 8;
            this.ChargingCell_4.TabStop = false;
            // 
            // ClearAction
            // 
            this.ClearAction.BackColor = System.Drawing.Color.Brown;
            this.ClearAction.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.ClearAction.FlatAppearance.BorderSize = 3;
            this.ClearAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearAction.Location = new System.Drawing.Point(26, 100);
            this.ClearAction.Name = "ClearAction";
            this.ClearAction.Size = new System.Drawing.Size(60, 60);
            this.ClearAction.TabIndex = 9;
            this.ClearAction.Text = "CE";
            this.ClearAction.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Brown;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.Clear.FlatAppearance.BorderSize = 3;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Location = new System.Drawing.Point(92, 100);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(60, 60);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.Color.Brown;
            this.Backspace.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.Backspace.FlatAppearance.BorderSize = 3;
            this.Backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Backspace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Backspace.Location = new System.Drawing.Point(158, 100);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(60, 60);
            this.Backspace.TabIndex = 11;
            this.Backspace.Text = "⌫";
            this.Backspace.UseVisualStyleBackColor = false;
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Division.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Division.FlatAppearance.BorderSize = 3;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Division.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Division.Location = new System.Drawing.Point(224, 100);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(60, 60);
            this.Division.TabIndex = 12;
            this.Division.Text = "÷";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // DecimalPoint
            // 
            this.DecimalPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DecimalPoint.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.DecimalPoint.FlatAppearance.BorderSize = 3;
            this.DecimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecimalPoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DecimalPoint.Location = new System.Drawing.Point(158, 364);
            this.DecimalPoint.Name = "DecimalPoint";
            this.DecimalPoint.Size = new System.Drawing.Size(60, 60);
            this.DecimalPoint.TabIndex = 17;
            this.DecimalPoint.Text = ",";
            this.DecimalPoint.UseVisualStyleBackColor = false;
            this.DecimalPoint.Click += new System.EventHandler(this.DecimalPoint_Click);
            // 
            // Solve
            // 
            this.Solve.BackColor = System.Drawing.Color.Aqua;
            this.Solve.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.Solve.FlatAppearance.BorderSize = 3;
            this.Solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Solve.Location = new System.Drawing.Point(224, 364);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(60, 60);
            this.Solve.TabIndex = 18;
            this.Solve.Text = "=";
            this.Solve.UseVisualStyleBackColor = false;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Seven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Seven.FlatAppearance.BorderSize = 3;
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Seven.Location = new System.Drawing.Point(26, 166);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(60, 60);
            this.Seven.TabIndex = 22;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Value = 7D;
            this.Seven.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Eight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Eight.FlatAppearance.BorderSize = 3;
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Eight.Location = new System.Drawing.Point(92, 166);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(60, 60);
            this.Eight.TabIndex = 21;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Value = 8D;
            this.Eight.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Nine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Nine.FlatAppearance.BorderSize = 3;
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nine.Location = new System.Drawing.Point(158, 166);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(60, 60);
            this.Nine.TabIndex = 20;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Value = 9D;
            this.Nine.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Multiplication.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Multiplication.FlatAppearance.BorderSize = 3;
            this.Multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiplication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Multiplication.Location = new System.Drawing.Point(224, 166);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(60, 60);
            this.Multiplication.TabIndex = 13;
            this.Multiplication.Text = "×";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Four.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Four.FlatAppearance.BorderSize = 3;
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Four.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Four.Location = new System.Drawing.Point(26, 232);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(60, 60);
            this.Four.TabIndex = 25;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Value = 4D;
            this.Four.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Five.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Five.FlatAppearance.BorderSize = 3;
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Five.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Five.Location = new System.Drawing.Point(92, 232);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(60, 60);
            this.Five.TabIndex = 24;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Value = 5D;
            this.Five.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Six.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Six.FlatAppearance.BorderSize = 3;
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Six.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Six.Location = new System.Drawing.Point(158, 232);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(60, 60);
            this.Six.TabIndex = 23;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Value = 6D;
            this.Six.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Addition.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Addition.FlatAppearance.BorderSize = 3;
            this.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addition.Location = new System.Drawing.Point(224, 232);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(60, 60);
            this.Addition.TabIndex = 14;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.One.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.One.FlatAppearance.BorderSize = 3;
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.One.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.One.Location = new System.Drawing.Point(26, 298);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(60, 60);
            this.One.TabIndex = 28;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Value = 1D;
            this.One.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Two.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Two.FlatAppearance.BorderSize = 3;
            this.Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Two.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Two.Location = new System.Drawing.Point(92, 298);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(60, 60);
            this.Two.TabIndex = 27;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Value = 2D;
            this.Two.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Three.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Three.FlatAppearance.BorderSize = 3;
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Three.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Three.Location = new System.Drawing.Point(158, 298);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(60, 60);
            this.Three.TabIndex = 26;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Value = 3D;
            this.Three.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Subtraction.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Subtraction.FlatAppearance.BorderSize = 3;
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtraction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Subtraction.Location = new System.Drawing.Point(224, 298);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(60, 60);
            this.Subtraction.TabIndex = 15;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // SignChange
            // 
            this.SignChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SignChange.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.SignChange.FlatAppearance.BorderSize = 3;
            this.SignChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignChange.Location = new System.Drawing.Point(26, 364);
            this.SignChange.Name = "SignChange";
            this.SignChange.Size = new System.Drawing.Size(60, 60);
            this.SignChange.TabIndex = 16;
            this.SignChange.Text = "±";
            this.SignChange.UseVisualStyleBackColor = false;
            this.SignChange.Click += new System.EventHandler(this.SignChange_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Zero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Zero.FlatAppearance.BorderSize = 3;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Zero.Location = new System.Drawing.Point(92, 364);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(60, 60);
            this.Zero.TabIndex = 19;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Value = 0D;
            this.Zero.Click += new System.EventHandler(this.Number_button_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(308, 439);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ChargingCell_0);
            this.Controls.Add(this.ChargingCell_1);
            this.Controls.Add(this.ChargingCell_4);
            this.Controls.Add(this.ChargingCell_3);
            this.Controls.Add(this.ChargingCell_2);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.DecimalPoint);
            this.Controls.Add(this.SignChange);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.ClearAction);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Background);
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargingCell_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion
            
            
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.TextBox Logo;
        private System.Windows.Forms.PictureBox ChargingCell_0;
        private System.Windows.Forms.PictureBox ChargingCell_1;
        private System.Windows.Forms.PictureBox ChargingCell_2;
        private System.Windows.Forms.PictureBox ChargingCell_3;
        private System.Windows.Forms.PictureBox ChargingCell_4;
        private System.Windows.Forms.Button ClearAction;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button Division;
        private MyButton Seven;
        private MyButton Eight;
        private MyButton Nine;
        private System.Windows.Forms.Button Multiplication;
        private MyButton Four;
        private MyButton Five;
        private MyButton Six;
        private System.Windows.Forms.Button Addition;
        private MyButton One;
        private MyButton Two;
        private MyButton Three;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button SignChange;
        private MyButton Zero;
        private System.Windows.Forms.Button DecimalPoint;
        private System.Windows.Forms.Button Solve;
        private MyTextBox Display;
    }
}