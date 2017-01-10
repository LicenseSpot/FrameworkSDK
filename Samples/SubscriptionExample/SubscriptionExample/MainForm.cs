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
    public partial class MainForm : Form
    {
        private Calculator calculator;
        private ExtendedLicense license;

        public MainForm()
        {
            InitializeComponent();
            this.license = ExtendedLicenseManager.GetLicense(typeof(MainForm), this, "your public key");

            this.calculator = new Calculator();
            this.calculator.CalculatorValueChanged += new Calculator.CalculatorValueChangedEventHandler(calculator_CalculatorValueChanged);
        }
        #region Calculator
        void calculator_CalculatorValueChanged(object sender, CalculatorChangedEventArgs e)
        {
            if (e.HasError)
                ValueLabel.Text = "err";
            else if (e.OperationType == OperationType.Calculation)
            {
                UpdateValueLabel(e.Result, false);
                ValueLabel.Tag = null;
            }
            else if (e.OperationType == OperationType.Accumulation)
            {
                ValueLabel.Tag = null;
            }
        }
        private void AppendValue(string valueText)
        {
            string textValue = ValueLabel.Tag as string;

            if (textValue == null)
            {
                textValue = "0";
                
            }

            bool hasPoint = false;
            if (valueText == ".")
            {
                if (textValue.IndexOf(".") < 0)
                {
                    textValue += ".";
                    hasPoint = true;
                }
            }
            else
            {
                textValue += valueText;
            }

            decimal value;
            if (decimal.TryParse(textValue, out value))
            {
                UpdateValueLabel(value, hasPoint);
            }
        }
        
        private void UpdateValueLabel(decimal value, bool hasPoint)
        {
            if (value > 999999999m)
            {
                ValueLabel.Text = value.ToString("e");
                ValueLabel.Tag = value.ToString();
            }
            else if (hasPoint)
            {
                ValueLabel.Text += ".";
                ValueLabel.Tag += ".";
            }
            else
            {
                ValueLabel.Text = value.ToString();
                ValueLabel.Tag = value.ToString();
            }

            
        }
        private decimal? GetCurrentValue()
        {
            decimal value;
            if (decimal.TryParse(ValueLabel.Tag as string ?? ValueLabel.Text, out value))
            {
                return value;
            }
            return null;
            
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            calculator.Calculate(this.GetCurrentValue());
            ValueLabel.Tag = null;
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            this.AppendValue(((Button)sender).Text);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            calculator.ApplyOperation(this.GetCurrentValue(), new Sum());
           
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            calculator.ApplyOperation(this.GetCurrentValue(), new Subtract());
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            calculator.ApplyOperation(this.GetCurrentValue(), new Multiply());

        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            calculator.ApplyOperation(this.GetCurrentValue(), new Divide());
        }
        private void Clear()
        {
            ValueLabel.Text = "0";
            ValueLabel.Tag = null;
            calculator.Clear();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AllClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            MemoryLabel.Visible = false;
            calculator.AllClear();
        }

        private void MemorySubstractButton_Click(object sender, EventArgs e)
        {
            calculator.ApplyOperation(this.GetCurrentValue(), new MemorySubtract());
            MemoryLabel.Visible = true;
        }

        private void MemoryAddButton_Click(object sender, EventArgs e)
        {
            calculator.ApplyOperation(this.GetCurrentValue(), new MemoryAdd());
            MemoryLabel.Visible = true;
        }

        private void MemoryRecallButton_Click(object sender, EventArgs e)
        {
            Clear();
            UpdateValueLabel(calculator.Memory ?? 0,false);
        }

        private void InvertSignButton_Click(object sender, EventArgs e)
        {
            calculator.ApplyOperation(this.GetCurrentValue(), new InvertSign());
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(ValueLabel.Text, true);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(DataFormats.Text))
            {
                string value = (string)data.GetData(DataFormats.Text);
                decimal res = 0;
                if (decimal.TryParse(value, out res))
                {
                    this.AppendValue(value);
                }
            }

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm dialog = new AboutForm();
            dialog.ShowDialog();
        }
        #endregion



        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivationForm dialog = new ActivationForm();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    license.Activate(dialog.SerialNumber);

                    license = ExtendedLicenseManager.GetLicense(typeof(MainForm), this, "your public key");
                    MessageBox.Show("The application has been activated.");
                    toolStripStatusLabel.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (license.Validate())
            {
                //MessageBox.Show("License is valid");
            }
            else
            {
                DialogResult activateResult = MessageBox.Show(this, "The calculator was unable to find a valid license", "Calculator", MessageBoxButtons.OK);
                toolStripStatusLabel.Text = "License is invalid";
                
            }

            licenseGenuineTimer.Start();
        }

        

        private void licenseGenuineTimer_Tick(object sender, EventArgs e)
        {
            //Timer is checking if the license subscription is active every 5 seconds just for demo purposes. You could check for this when the main form loads.
            try
            {
                if (license.IsSubscriptionActive)
                {
                     toolStripStatusLabel.Text = "Subscription is active. It was validated against the server.";
                }
                else
                {
                    toolStripStatusLabel.Text = "Subscription validation failed.";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = ex.Message;
            }
        }



       

       
    }
}