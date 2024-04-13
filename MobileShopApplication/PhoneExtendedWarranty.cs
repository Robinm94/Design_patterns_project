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
        IPhoneComponent phoneComponent;

        public PhoneExtendedWarranty(IPhoneComponent phoneComponent)
        {
            InitializeComponent();
            this.phoneComponent = phoneComponent;
            btnBack.Text = "\u2190 Back";
        }

        private void PhoneExtendedWarranty_Load(object sender, EventArgs e)
        {
            if (phoneComponent == null)
            {
                MessageBox.Show("Please select a phone model first.", "Phone Model Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            lblPhoneBrand.Text = phoneComponent.GetBrand();
            lblPhoneModel.Text = phoneComponent.GetModel();
            lblPhoneDetails.Text = phoneComponent.GetDetails();
            lblPhoneContents.Text = phoneComponent.Contents();
            lblWarranty.Text = phoneComponent.GetWarrantyDetails();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            rdoBtnSixMonths.Checked = false;
            rdoBtnOneYear.Checked = false;
            rdoBtnTwoYears.Checked = false;
            rdoBtnThreeYears.Checked = false;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if(!rdoBtnSixMonths.Checked && !rdoBtnOneYear.Checked && !rdoBtnTwoYears.Checked && !rdoBtnThreeYears.Checked)
            {
                DialogResult dialog = MessageBox.Show("Would you like to proceed without any warranty", "No warranty selected", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
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
                PhonePayment phonePayment = new PhonePayment(phoneWithWarranty);
                this.Hide();
                DialogResult result = phonePayment.ShowDialog();
                if (result == DialogResult.Abort)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
