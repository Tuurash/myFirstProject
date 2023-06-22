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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.CalculatorPanel = new System.Windows.Forms.Panel();
            this.ClearPanel = new System.Windows.Forms.Panel();
            this.ClearAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.History = new System.Windows.Forms.Label();
            this.CalculationTxt = new System.Windows.Forms.TextBox();
            this.SignPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Devide = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.NumPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.CalculatorPanel.SuspendLayout();
            this.ClearPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SignPanel.SuspendLayout();
            this.NumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorPanel
            // 
            this.CalculatorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CalculatorPanel.Controls.Add(this.ClearPanel);
            this.CalculatorPanel.Controls.Add(this.panel1);
            this.CalculatorPanel.Controls.Add(this.SignPanel);
            this.CalculatorPanel.Controls.Add(this.NumPanel);
            this.CalculatorPanel.Controls.Add(this.HeadPanel);
            this.CalculatorPanel.Location = new System.Drawing.Point(-2, -2);
            this.CalculatorPanel.Name = "CalculatorPanel";
            this.CalculatorPanel.Size = new System.Drawing.Size(279, 412);
            this.CalculatorPanel.TabIndex = 0;
            this.CalculatorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // ClearPanel
            // 
            this.ClearPanel.Controls.Add(this.ClearAll);
            this.ClearPanel.Location = new System.Drawing.Point(6, 357);
            this.ClearPanel.Name = "ClearPanel";
            this.ClearPanel.Size = new System.Drawing.Size(195, 52);
            this.ClearPanel.TabIndex = 8;
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.ForeColor = System.Drawing.Color.White;
            this.ClearAll.Location = new System.Drawing.Point(0, 0);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(195, 52);
            this.ClearAll.TabIndex = 0;
            this.ClearAll.TabStop = false;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.History);
            this.panel1.Controls.Add(this.CalculationTxt);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 128);
            this.panel1.TabIndex = 7;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.BackColor = System.Drawing.Color.White;
            this.History.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.History.Location = new System.Drawing.Point(9, 87);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(25, 23);
            this.History.TabIndex = 1;
            this.History.Text = "->";
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // CalculationTxt
            // 
            this.CalculationTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.CalculationTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalculationTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CalculationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationTxt.Location = new System.Drawing.Point(0, 14);
            this.CalculationTxt.Multiline = true;
            this.CalculationTxt.Name = "CalculationTxt";
            this.CalculationTxt.ReadOnly = true;
            this.CalculationTxt.Size = new System.Drawing.Size(276, 114);
            this.CalculationTxt.TabIndex = 0;
            this.CalculationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CalculationTxt.TextChanged += new System.EventHandler(this.CalculationTxt_TextChanged_1);
            // 
            // SignPanel
            // 
            this.SignPanel.ColumnCount = 1;
            this.SignPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SignPanel.Controls.Add(this.Devide, 0, 0);
            this.SignPanel.Controls.Add(this.Mult, 0, 1);
            this.SignPanel.Controls.Add(this.Sub, 0, 2);
            this.SignPanel.Controls.Add(this.Addition, 0, 3);
            this.SignPanel.Location = new System.Drawing.Point(203, 134);
            this.SignPanel.Name = "SignPanel";
            this.SignPanel.RowCount = 4;
            this.SignPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SignPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SignPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SignPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.SignPanel.Size = new System.Drawing.Size(73, 279);
            this.SignPanel.TabIndex = 6;
            // 
            // Devide
            // 
            this.Devide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Devide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Devide.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devide.ForeColor = System.Drawing.Color.White;
            this.Devide.Location = new System.Drawing.Point(3, 3);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(67, 49);
            this.Devide.TabIndex = 0;
            this.Devide.TabStop = false;
            this.Devide.Text = "÷";
            this.Devide.UseVisualStyleBackColor = false;
            this.Devide.Click += new System.EventHandler(this.OperatorClick);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Mult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.ForeColor = System.Drawing.Color.White;
            this.Mult.Location = new System.Drawing.Point(3, 58);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(67, 49);
            this.Mult.TabIndex = 1;
            this.Mult.TabStop = false;
            this.Mult.Text = "X";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.OperatorClick);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Sub.ForeColor = System.Drawing.Color.White;
            this.Sub.Location = new System.Drawing.Point(3, 113);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(67, 49);
            this.Sub.TabIndex = 2;
            this.Sub.TabStop = false;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.OperatorClick);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Addition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.ForeColor = System.Drawing.Color.White;
            this.Addition.Location = new System.Drawing.Point(3, 168);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(67, 108);
            this.Addition.TabIndex = 3;
            this.Addition.TabStop = false;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.OperatorClick);
            // 
            // NumPanel
            // 
            this.NumPanel.ColumnCount = 3;
            this.NumPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumPanel.Controls.Add(this.Num7, 0, 0);
            this.NumPanel.Controls.Add(this.Num8, 1, 0);
            this.NumPanel.Controls.Add(this.Num9, 2, 0);
            this.NumPanel.Controls.Add(this.Num4, 0, 1);
            this.NumPanel.Controls.Add(this.Num5, 1, 1);
            this.NumPanel.Controls.Add(this.Num6, 2, 1);
            this.NumPanel.Controls.Add(this.Num1, 0, 2);
            this.NumPanel.Controls.Add(this.Num2, 1, 2);
            this.NumPanel.Controls.Add(this.Num3, 2, 2);
            this.NumPanel.Controls.Add(this.Point, 0, 3);
            this.NumPanel.Controls.Add(this.Num0, 1, 3);
            this.NumPanel.Controls.Add(this.EqualBtn, 2, 3);
            this.NumPanel.Location = new System.Drawing.Point(3, 134);
            this.NumPanel.Name = "NumPanel";
            this.NumPanel.RowCount = 4;
            this.NumPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumPanel.Size = new System.Drawing.Size(198, 220);
            this.NumPanel.TabIndex = 5;
            this.NumPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Num7
            // 
            this.Num7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.ForeColor = System.Drawing.Color.White;
            this.Num7.Location = new System.Drawing.Point(3, 3);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(60, 49);
            this.Num7.TabIndex = 0;
            this.Num7.TabStop = false;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = false;
            this.Num7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num8
            // 
            this.Num8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num8.ForeColor = System.Drawing.Color.White;
            this.Num8.Location = new System.Drawing.Point(69, 3);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(60, 49);
            this.Num8.TabIndex = 1;
            this.Num8.TabStop = false;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = false;
            this.Num8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num9
            // 
            this.Num9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num9.ForeColor = System.Drawing.Color.White;
            this.Num9.Location = new System.Drawing.Point(135, 3);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(60, 49);
            this.Num9.TabIndex = 2;
            this.Num9.TabStop = false;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = false;
            this.Num9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num4.ForeColor = System.Drawing.Color.White;
            this.Num4.Location = new System.Drawing.Point(3, 58);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(60, 49);
            this.Num4.TabIndex = 3;
            this.Num4.TabStop = false;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = false;
            this.Num4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num5.ForeColor = System.Drawing.Color.White;
            this.Num5.Location = new System.Drawing.Point(69, 58);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(60, 49);
            this.Num5.TabIndex = 4;
            this.Num5.TabStop = false;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = false;
            this.Num5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num6.ForeColor = System.Drawing.Color.White;
            this.Num6.Location = new System.Drawing.Point(135, 58);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(60, 49);
            this.Num6.TabIndex = 5;
            this.Num6.TabStop = false;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = false;
            this.Num6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num1.ForeColor = System.Drawing.Color.White;
            this.Num1.Location = new System.Drawing.Point(3, 113);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(60, 49);
            this.Num1.TabIndex = 6;
            this.Num1.TabStop = false;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = false;
            this.Num1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num2.ForeColor = System.Drawing.Color.White;
            this.Num2.Location = new System.Drawing.Point(69, 113);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(60, 49);
            this.Num2.TabIndex = 7;
            this.Num2.TabStop = false;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = false;
            this.Num2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num3.ForeColor = System.Drawing.Color.White;
            this.Num3.Location = new System.Drawing.Point(135, 113);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(60, 49);
            this.Num3.TabIndex = 8;
            this.Num3.TabStop = false;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = false;
            this.Num3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Point.ForeColor = System.Drawing.Color.White;
            this.Point.Location = new System.Drawing.Point(3, 168);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(60, 49);
            this.Point.TabIndex = 15;
            this.Point.TabStop = false;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = false;
            this.Point.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Num0
            // 
            this.Num0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Num0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Num0.ForeColor = System.Drawing.Color.White;
            this.Num0.Location = new System.Drawing.Point(69, 168);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(60, 49);
            this.Num0.TabIndex = 16;
            this.Num0.TabStop = false;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = false;
            this.Num0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // EqualBtn
            // 
            this.EqualBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EqualBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.EqualBtn.ForeColor = System.Drawing.Color.White;
            this.EqualBtn.Location = new System.Drawing.Point(135, 168);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(60, 49);
            this.EqualBtn.TabIndex = 17;
            this.EqualBtn.TabStop = false;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = false;
            this.EqualBtn.Click += new System.EventHandler(this.Equals_Click);
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.LightGray;
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(279, 38);
            this.HeadPanel.TabIndex = 0;
            // 
            // Calculator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(270, 407);
            this.Controls.Add(this.CalculatorPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator v.1.2";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.CalculatorPanel.ResumeLayout(false);
            this.ClearPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SignPanel.ResumeLayout(false);
            this.NumPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CalculatorPanel;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.TableLayoutPanel NumPanel;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.TableLayoutPanel SignPanel;
        private System.Windows.Forms.Button Devide;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Panel ClearPanel;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.TextBox CalculationTxt;
    }
}

