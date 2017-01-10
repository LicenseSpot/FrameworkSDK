using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LicenseSpot.Framework;
namespace SubscriptionExample
{
    public partial class ActivationForm : Form
    {
        private string serialNumber;
        public string SerialNumber
        {
            get { return serialNumber; }
        }
	
        public ActivationForm()
        {
            InitializeComponent();
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SerialNumberTextBox.Text))
            {
                MessageBox.Show("Serial Number is required");
                return;
            }
            this.serialNumber = SerialNumberTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
                
            
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}