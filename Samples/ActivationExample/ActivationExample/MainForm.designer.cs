namespace ActivationExample
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AllClearButton = new System.Windows.Forms.Button();
            this.MemorySubstractButton = new System.Windows.Forms.Button();
            this.MemoryAddButton = new System.Windows.Forms.Button();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryRecallButton = new System.Windows.Forms.Button();
            this.InvertSignButton = new System.Windows.Forms.Button();
            this.licenseGenuineTimer = new System.Windows.Forms.Timer(this.components);
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.CalculatorStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(230, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(12, 228);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(80, 30);
            this.ZeroButton.TabIndex = 3;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(12, 191);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(37, 31);
            this.OneButton.TabIndex = 4;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(55, 191);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(37, 31);
            this.TwoButton.TabIndex = 5;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(98, 191);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(37, 31);
            this.ThreeButton.TabIndex = 6;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(98, 228);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(37, 31);
            this.DotButton.TabIndex = 7;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(12, 154);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(37, 31);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(55, 154);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(37, 31);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(98, 154);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(37, 31);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(12, 117);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(37, 31);
            this.SevenButton.TabIndex = 11;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(55, 117);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(37, 31);
            this.EightButton.TabIndex = 12;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(98, 117);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(37, 31);
            this.NineButton.TabIndex = 13;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(141, 227);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(37, 31);
            this.PlusButton.TabIndex = 14;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(141, 190);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(37, 31);
            this.MinusButton.TabIndex = 15;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(141, 154);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(37, 31);
            this.MultiplyButton.TabIndex = 16;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionButton.Location = new System.Drawing.Point(141, 117);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(37, 31);
            this.DivisionButton.TabIndex = 17;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.Location = new System.Drawing.Point(184, 154);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(37, 104);
            this.EqualButton.TabIndex = 18;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ValueLabel.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(14, 35);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(204, 45);
            this.ValueLabel.TabIndex = 19;
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(141, 83);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(37, 31);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AllClearButton
            // 
            this.AllClearButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClearButton.Location = new System.Drawing.Point(184, 83);
            this.AllClearButton.Name = "AllClearButton";
            this.AllClearButton.Size = new System.Drawing.Size(37, 31);
            this.AllClearButton.TabIndex = 21;
            this.AllClearButton.Text = "AC";
            this.AllClearButton.UseVisualStyleBackColor = true;
            this.AllClearButton.Click += new System.EventHandler(this.AllClearButton_Click);
            // 
            // MemorySubstractButton
            // 
            this.MemorySubstractButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySubstractButton.Location = new System.Drawing.Point(98, 83);
            this.MemorySubstractButton.Name = "MemorySubstractButton";
            this.MemorySubstractButton.Size = new System.Drawing.Size(37, 31);
            this.MemorySubstractButton.TabIndex = 22;
            this.MemorySubstractButton.Text = "M-";
            this.MemorySubstractButton.UseVisualStyleBackColor = true;
            this.MemorySubstractButton.Click += new System.EventHandler(this.MemorySubstractButton_Click);
            // 
            // MemoryAddButton
            // 
            this.MemoryAddButton.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryAddButton.Location = new System.Drawing.Point(55, 83);
            this.MemoryAddButton.Name = "MemoryAddButton";
            this.MemoryAddButton.Size = new System.Drawing.Size(37, 31);
            this.MemoryAddButton.TabIndex = 23;
            this.MemoryAddButton.Text = "M+";
            this.MemoryAddButton.UseVisualStyleBackColor = true;
            this.MemoryAddButton.Click += new System.EventHandler(this.MemoryAddButton_Click);
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.MemoryLabel.Location = new System.Drawing.Point(16, 35);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(16, 13);
            this.MemoryLabel.TabIndex = 24;
            this.MemoryLabel.Text = "M";
            this.MemoryLabel.Visible = false;
            // 
            // MemoryRecallButton
            // 
            this.MemoryRecallButton.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryRecallButton.Location = new System.Drawing.Point(12, 83);
            this.MemoryRecallButton.Name = "MemoryRecallButton";
            this.MemoryRecallButton.Size = new System.Drawing.Size(37, 31);
            this.MemoryRecallButton.TabIndex = 25;
            this.MemoryRecallButton.Text = "MR";
            this.MemoryRecallButton.UseVisualStyleBackColor = true;
            this.MemoryRecallButton.Click += new System.EventHandler(this.MemoryRecallButton_Click);
            // 
            // InvertSignButton
            // 
            this.InvertSignButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvertSignButton.Location = new System.Drawing.Point(184, 120);
            this.InvertSignButton.Name = "InvertSignButton";
            this.InvertSignButton.Size = new System.Drawing.Size(37, 31);
            this.InvertSignButton.TabIndex = 26;
            this.InvertSignButton.Text = "+-";
            this.InvertSignButton.UseVisualStyleBackColor = true;
            this.InvertSignButton.Click += new System.EventHandler(this.InvertSignButton_Click);
            // 
            // licenseGenuineTimer
            // 
            this.licenseGenuineTimer.Interval = 5000;
            this.licenseGenuineTimer.Tick += new System.EventHandler(this.licenseGenuineTimer_Tick);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerToolStripMenuItem.Text = "Register...";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // CalculatorStatusStrip
            // 
            this.CalculatorStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.CalculatorStatusStrip.Location = new System.Drawing.Point(0, 267);
            this.CalculatorStatusStrip.Name = "CalculatorStatusStrip";
            this.CalculatorStatusStrip.Size = new System.Drawing.Size(230, 22);
            this.CalculatorStatusStrip.SizingGrip = false;
            this.CalculatorStatusStrip.TabIndex = 27;
            this.CalculatorStatusStrip.Text = "fsd";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 289);
            this.Controls.Add(this.CalculatorStatusStrip);
            this.Controls.Add(this.InvertSignButton);
            this.Controls.Add(this.MemoryRecallButton);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.MemoryAddButton);
            this.Controls.Add(this.MemorySubstractButton);
            this.Controls.Add(this.AllClearButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CalculatorStatusStrip.ResumeLayout(false);
            this.CalculatorStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AllClearButton;
        private System.Windows.Forms.Button MemorySubstractButton;
        private System.Windows.Forms.Button MemoryAddButton;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Button MemoryRecallButton;
        private System.Windows.Forms.Button InvertSignButton;
        private System.Windows.Forms.Timer licenseGenuineTimer;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip CalculatorStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

