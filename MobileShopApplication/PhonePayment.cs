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
    public partial class PhonePayment : Form
    {
        PhoneComponent phone;
        Dictionary<string, Image> phoneImages = new Dictionary<string, Image>
        {
            { "Apple iPhone 14 Pro Max", Properties.Resources.Apple_iPhone_14_Pro_Max },
            { "Apple iPhone 12", Properties.Resources.Apple_iPhone_12 },
            { "Apple iPhone 12 Pro", Properties.Resources.Apple_iPhone_12_Pro },
            { "Samsung Galaxy S21 Ultra", Properties.Resources.Samsung_Galaxy_S21_Ultra },
            { "Samsung Galaxy S21", Properties.Resources.Samsung_Galaxy_S21 },
            { "Samsung Galaxy Note20 Ultra", Properties.Resources.Samsung_Galaxy_Note_20_Ultra },
            { "Xiaomi Mi 11", Properties.Resources.Xiaomi_Mi_11 },
            { "Xiaomi Redmi Note 10", Properties.Resources.Xiaomi_Redmi_Note_10 },
            { "Xiaomi Poco X3", Properties.Resources.Xiaomi_Poco_X3_NFC },
            { "Oppo Find X3 Pro", Properties.Resources.OPPO_Find_X3_Pro },
            { "Oppo Reno5 Pro", Properties.Resources.OPPO_Reno5_Pro },
            { "Oppo A74", Properties.Resources.OPPO_A74_5G }
        };

        public PhonePayment(PhoneComponent phone)
        {
            InitializeComponent();
            this.phone = phone;
            btnBack.Text = "\u2190 Back";
        }

        private void PhonePayment_Load(object sender, EventArgs e)
        {
            if (phone == null)
            {
                MessageBox.Show("Please select a phone model first.", "Phone Model Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            lblPhoneBrand.Text = phone.GetBrand();
            lblPhoneModel.Text = phone.GetModel();
            lblPhoneDetails.Text = phone.GetDetails();
            lblPhoneContents.Text = phone.Contents();
            lblWarranty.Text = phone.GetWarrantyDetails();
            pBoxPhone.Image = phoneImages[phone.GetModel()];
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Would you like to proceed with the payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Payment successful!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
