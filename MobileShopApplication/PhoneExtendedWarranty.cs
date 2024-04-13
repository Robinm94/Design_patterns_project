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
    public partial class PhoneExtendedWarranty : Form
    {
        // The phone component selected by the user
        IPhoneComponent phoneComponent;

        // Constructor that takes a phone component
        public PhoneExtendedWarranty(IPhoneComponent phoneComponent)
        {
            InitializeComponent();
            this.phoneComponent = phoneComponent;
            btnBack.Text = "\u2190 Back";
        }

        // Load event handler for the form
        private void PhoneExtendedWarranty_Load(object sender, EventArgs e)
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

        // Click event handler for the Back button
        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Close the form and return to the previous form
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        // Click event handler for the Clear button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Uncheck all the radio buttons
            rdoBtnSixMonths.Checked = false;
            rdoBtnOneYear.Checked = false;
            rdoBtnTwoYears.Checked = false;
            rdoBtnThreeYears.Checked = false;
        }

        // Click event handler for the Proceed button
        private void BtnProceed_Click(object sender, EventArgs e)
        {
            // If no warranty is selected, ask the user if they want to proceed
            if (!rdoBtnSixMonths.Checked && !rdoBtnOneYear.Checked && !rdoBtnTwoYears.Checked && !rdoBtnThreeYears.Checked)
            {
                DialogResult dialog = MessageBox.Show("Would you like to proceed without any warranty", "No warranty selected", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                // Add the selected warranty to the phone component
                PhoneComponent phoneWithWarranty = (PhoneComponent)phoneComponent;
                if (rdoBtnSixMonths.Checked)
                {
                    phoneWithWarranty.SetExtendedWarranty(new SixMonthsExtendedWarranty());
                }
                else if (rdoBtnOneYear.Checked)
                {
                    phoneWithWarranty.SetExtendedWarranty(new OneYearExtendedWarranty());
                }
                else if (rdoBtnTwoYears.Checked)
                {
                    phoneWithWarranty.SetExtendedWarranty(new TwoYearExtendedWarranty());
                }
                else if (rdoBtnThreeYears.Checked)
                {
                    phoneWithWarranty.SetExtendedWarranty(new ThreeYearExtendedWarranty());
                }
                // Show the PhonePayment form
                PhonePayment phonePayment = new PhonePayment(phoneWithWarranty);
                this.Hide();
                DialogResult result = phonePayment.ShowDialog();
                // If the user clicked Back in the PhonePayment form, show this form again
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
}
