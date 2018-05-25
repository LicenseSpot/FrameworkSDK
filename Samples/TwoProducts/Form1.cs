using LicenseSpot.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoProducts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateProduct1Button_Click(object sender, EventArgs e)
        {
            string licenseFolder = @"c:\ProgramData\IPManager\licenseProduct1.lic";
            if (File.Exists(licenseFolder))
            {
                LicenseValidationInfo info = new LicenseValidationInfo();
                info.LicenseFile = new LicenseFile(licenseFolder);

                ExtendedLicense license = ExtendedLicenseManager.GetLicense(typeof(Form1), this, info, "public key product 1");

                MessageBox.Show(license.Validate().ToString());
            }
        }

        private void ValidateProduct2Button_Click(object sender, EventArgs e)
        {
            string licenseFolder = @"c:\ProgramData\IPManager\licenseProduct2.lic";
            if (File.Exists(licenseFolder))
            {
                LicenseValidationInfo info = new LicenseValidationInfo();
                info.LicenseFile = new LicenseFile(licenseFolder);

                ExtendedLicense license = ExtendedLicenseManager.GetLicense(typeof(Form1), this, info, "public key product 2");

                MessageBox.Show(license.Validate().ToString());
            }
        }

        private void ActivateProduct1Button_Click(object sender, EventArgs e)
        {
            ExtendedLicense license = ExtendedLicenseManager.GetLicense(typeof(Form1), this, "public key product 1");
            license.Activate("serial number 1", true, "licenseProduct1.lic");

            

            MessageBox.Show("done");
            
        }

        private void ActivateProduct2Button_Click(object sender, EventArgs e)
        {
            ExtendedLicense license = ExtendedLicenseManager.GetLicense(typeof(Form1), this, "public key product 2");
            license.Activate("serial number 2", true, "licenseProduct2.lic");

            MessageBox.Show("done");
        }
    }
}
