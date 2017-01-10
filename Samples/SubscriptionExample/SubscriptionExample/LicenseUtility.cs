using System;
using System.Collections.Generic;
using System.Text;
using LicenseSpot.Framework;
namespace SubscriptionExample
{
    public class LicenseUtility
    {
        private ExtendedLicense license;
        private static LicenseUtility instance;

        public static LicenseUtility Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LicenseUtility();
                }
                return instance;
            }
        }
        public ExtendedLicense License
        {
            get
            {
                if (license == null)
                {
                    //LicenseFile licenseFile = new LicenseFile();
                    //licenseFile.Load(System.Reflection.Assembly.GetExecutingAssembly().Location + @"\license.lic");

                    //LicenseValidationInfo info = new LicenseValidationInfo();
                    //info.LicenseFile = licenseFile;

                    license = ExtendedLicenseManager.GetLicense(typeof(MainForm), this, "your public key");
                }
                return license;
            }
        }
        public bool Activate(string serialNumber)
        {
            

            if (!this.License.IsActivated)
            {
                this.License.Activate(serialNumber);
                                
                

                license = null;

                return this.License.IsActivated;
            }

            return false;
        }
        public void Reset()
        {
            license = null;
        }
    }
}
