namespace TwoProducts
{
    partial class Form1
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
            this.ValidateProduct1Button = new System.Windows.Forms.Button();
            this.ValidateProduct2Button = new System.Windows.Forms.Button();
            this.ActivateProduct1Button = new System.Windows.Forms.Button();
            this.ActivateProduct2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValidateProduct1Button
            // 
            this.ValidateProduct1Button.Location = new System.Drawing.Point(70, 50);
            this.ValidateProduct1Button.Name = "ValidateProduct1Button";
            this.ValidateProduct1Button.Size = new System.Drawing.Size(90, 45);
            this.ValidateProduct1Button.TabIndex = 0;
            this.ValidateProduct1Button.Text = "Validate Product 1";
            this.ValidateProduct1Button.UseVisualStyleBackColor = true;
            this.ValidateProduct1Button.Click += new System.EventHandler(this.ValidateProduct1Button_Click);
            // 
            // ValidateProduct2Button
            // 
            this.ValidateProduct2Button.Location = new System.Drawing.Point(185, 50);
            this.ValidateProduct2Button.Name = "ValidateProduct2Button";
            this.ValidateProduct2Button.Size = new System.Drawing.Size(90, 45);
            this.ValidateProduct2Button.TabIndex = 1;
            this.ValidateProduct2Button.Text = "Validate Product 2";
            this.ValidateProduct2Button.UseVisualStyleBackColor = true;
            this.ValidateProduct2Button.Click += new System.EventHandler(this.ValidateProduct2Button_Click);
            // 
            // ActivateProduct1Button
            // 
            this.ActivateProduct1Button.Location = new System.Drawing.Point(70, 117);
            this.ActivateProduct1Button.Name = "ActivateProduct1Button";
            this.ActivateProduct1Button.Size = new System.Drawing.Size(90, 45);
            this.ActivateProduct1Button.TabIndex = 2;
            this.ActivateProduct1Button.Text = "Activate Product 1";
            this.ActivateProduct1Button.UseVisualStyleBackColor = true;
            this.ActivateProduct1Button.Click += new System.EventHandler(this.ActivateProduct1Button_Click);
            // 
            // ActivateProduct2Button
            // 
            this.ActivateProduct2Button.Location = new System.Drawing.Point(185, 117);
            this.ActivateProduct2Button.Name = "ActivateProduct2Button";
            this.ActivateProduct2Button.Size = new System.Drawing.Size(90, 45);
            this.ActivateProduct2Button.TabIndex = 3;
            this.ActivateProduct2Button.Text = "Activate Product 2";
            this.ActivateProduct2Button.UseVisualStyleBackColor = true;
            this.ActivateProduct2Button.Click += new System.EventHandler(this.ActivateProduct2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 293);
            this.Controls.Add(this.ActivateProduct2Button);
            this.Controls.Add(this.ActivateProduct1Button);
            this.Controls.Add(this.ValidateProduct2Button);
            this.Controls.Add(this.ValidateProduct1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValidateProduct1Button;
        private System.Windows.Forms.Button ValidateProduct2Button;
        private System.Windows.Forms.Button ActivateProduct1Button;
        private System.Windows.Forms.Button ActivateProduct2Button;
    }
}

