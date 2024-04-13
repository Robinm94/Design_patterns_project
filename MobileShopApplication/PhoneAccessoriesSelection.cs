using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopApplication
{
    public partial class PhoneAccessoriesSelection : Form
    {
        // The phone component selected by the user
        IPhoneComponent phoneComponent;

        // Constructor that takes a phone component
        public PhoneAccessoriesSelection(IPhoneComponent phoneComponent)
        {
            InitializeComponent();
            this.phoneComponent = phoneComponent;
            btnBack.Text = "\u2190 Back";
        }

        // Load event handler for the form
        private void PhoneAccessoriesSelection_Load(object sender, EventArgs e)
        {
            // If no phone component is selected, show a warning and close the form
            if (phoneComponent == null)
            {
                MessageBox.Show("Please select a phone model first.", "Phone Model Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            // Display the details of the selected phone component
            lblPhoneBrand.Text = phoneComponent.GetBrand();
            lblPhoneModel.Text = phoneComponent.GetModel();
            lblPhoneDetails.Text = phoneComponent.GetDetails();
            lblPhoneContents.Text = phoneComponent.Contents();
            lblWarranty.Text = phoneComponent.GetWarrantyDetails();
        }

        // Click event handler for the Clear button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Uncheck all the checkboxes
            chkCharger.Checked = false;
            chkCover.Checked = false;
            chkScreenGuard.Checked = false;
            chkEarphone.Checked = false;
        }

        // Click event handler for the Back button
        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Close the form and return to the previous form
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        // Click event handler for the Proceed button
        private void BtnProceed_Click(object sender, EventArgs e)
        {
            // If no accessories are selected, ask the user if they want to proceed
            if (!chkCharger.Checked && !chkCover.Checked && !chkScreenGuard.Checked && !chkEarphone.Checked)
            {
                DialogResult dialog = MessageBox.Show("Would you like to proceed without any accessories", "No accessory selected", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
            }
            // Add the selected accessories to the phone component
            IPhoneComponent phoneWithAccessories = phoneComponent;
            if (chkCharger.Checked)
            {
                phoneWithAccessories = new PhoneCharger(phoneWithAccessories);
            }
            if (chkCover.Checked)
            {
                phoneWithAccessories = new PhoneCover(phoneWithAccessories);
            }
            if (chkScreenGuard.Checked)
            {
                phoneWithAccessories = new ScreenGuard(phoneWithAccessories);
            }
            if (chkEarphone.Checked)
            {
                phoneWithAccessories = new Earphones(phoneWithAccessories);
            }
            // Show the PhoneExtendedWarranty form
            PhoneExtendedWarranty phoneExtendedWarranty = new PhoneExtendedWarranty(phoneWithAccessories);
            this.Hide();
            DialogResult result = phoneExtendedWarranty.ShowDialog();
            // If the user clicked Back in the PhoneExtendedWarranty form, show this form again
            if (result == DialogResult.Abort)
            {
                this.Show();
            }
            // Otherwise, close this form
            else
            {
                this.Close();
            }
        }
    }
}
