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
        IPhoneComponent phoneComponent;
        public PhoneAccessoriesSelection(IPhoneComponent phoneComponent)
        {
            InitializeComponent();
            this.phoneComponent = phoneComponent;
            btnBack.Text = "\u2190 Back";
        }

        private void PhoneAccessoriesSelection_Load(object sender, EventArgs e)
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            chkCharger.Checked = false;
            chkCover.Checked = false;
            chkScreenGuard.Checked = false;
            chkEarphone.Checked = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (!chkCharger.Checked && !chkCover.Checked && !chkScreenGuard.Checked && !chkEarphone.Checked)
            {
                DialogResult dialog = MessageBox.Show("Would you like to proceed without any accessories", "No accessory selected", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
            }
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
            PhoneExtendedWarranty phoneExtendedWarranty = new PhoneExtendedWarranty(phoneWithAccessories);
            this.Hide();
            DialogResult result = phoneExtendedWarranty.ShowDialog();
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
