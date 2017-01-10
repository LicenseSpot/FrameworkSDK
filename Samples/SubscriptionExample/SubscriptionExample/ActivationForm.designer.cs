namespace SubscriptionExample
{
    partial class ActivationForm
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
            this.ActivateButton = new System.Windows.Forms.Button();
            this.SerialNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActivateButton
            // 
            this.ActivateButton.Location = new System.Drawing.Point(152, 99);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(75, 23);
            this.ActivateButton.TabIndex = 0;
            this.ActivateButton.Text = "Activate";
            this.ActivateButton.UseVisualStyleBackColor = true;
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(95, 44);
            this.SerialNumberTextBox.Mask = ">AAAA-AAAA-AAAA-AAAA-AAAA-AAAA-AAAA";
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(213, 20);
            this.SerialNumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial Number:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ActivationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 140);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.ActivateButton);
            this.Name = "ActivationForm";
            this.ShowInTaskbar = false;
            this.Text = "Calculator Activation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActivateButton;
        private System.Windows.Forms.MaskedTextBox SerialNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}