namespace MobileShopApplication
{
    partial class PhoneAccessoriesSelection
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
            lblDetailsText = new Label();
            grpAccessories = new GroupBox();
            chkEarphone = new CheckBox();
            chkScreenGuard = new CheckBox();
            chkCover = new CheckBox();
            chkCharger = new CheckBox();
            lblAccessoriesText = new Label();
            btnProceed = new Button();
            btnClear = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            lblWarrantyText = new Label();
            lblContents = new Label();
            lblDetails = new Label();
            lblModel = new Label();
            lblBrand = new Label();
            lblWarranty = new Label();
            lblPhoneContents = new Label();
            lblPhoneModel = new Label();
            lblPhoneDetails = new Label();
            lblPhoneBrand = new Label();
            grpAccessories.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDetailsText
            // 
            lblDetailsText.AutoSize = true;
            lblDetailsText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailsText.Location = new Point(26, 62);
            lblDetailsText.Name = "lblDetailsText";
            lblDetailsText.Size = new Size(244, 28);
            lblDetailsText.TabIndex = 0;
            lblDetailsText.Text = "Selected phone's details:";
            // 
            // grpAccessories
            // 
            grpAccessories.Controls.Add(chkEarphone);
            grpAccessories.Controls.Add(chkScreenGuard);
            grpAccessories.Controls.Add(chkCover);
            grpAccessories.Controls.Add(chkCharger);
            grpAccessories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpAccessories.Location = new Point(611, 107);
            grpAccessories.Name = "grpAccessories";
            grpAccessories.Size = new Size(330, 297);
            grpAccessories.TabIndex = 6;
            grpAccessories.TabStop = false;
            grpAccessories.Text = "Accessories";
            // 
            // chkEarphone
            // 
            chkEarphone.AutoSize = true;
            chkEarphone.Location = new Point(58, 219);
            chkEarphone.Name = "chkEarphone";
            chkEarphone.Size = new Size(123, 32);
            chkEarphone.TabIndex = 3;
            chkEarphone.Text = "Earphone";
            chkEarphone.UseVisualStyleBackColor = true;
            // 
            // chkScreenGuard
            // 
            chkScreenGuard.AutoSize = true;
            chkScreenGuard.Location = new Point(58, 161);
            chkScreenGuard.Name = "chkScreenGuard";
            chkScreenGuard.Size = new Size(160, 32);
            chkScreenGuard.TabIndex = 2;
            chkScreenGuard.Text = "Screen Guard";
            chkScreenGuard.UseVisualStyleBackColor = true;
            // 
            // chkCover
            // 
            chkCover.AutoSize = true;
            chkCover.Location = new Point(58, 107);
            chkCover.Name = "chkCover";
            chkCover.Size = new Size(153, 32);
            chkCover.TabIndex = 1;
            chkCover.Text = "Phone Cover";
            chkCover.UseVisualStyleBackColor = true;
            // 
            // chkCharger
            // 
            chkCharger.AutoSize = true;
            chkCharger.Location = new Point(58, 53);
            chkCharger.Name = "chkCharger";
            chkCharger.Size = new Size(173, 32);
            chkCharger.TabIndex = 0;
            chkCharger.Text = "Phone Charger";
            chkCharger.UseVisualStyleBackColor = true;
            // 
            // lblAccessoriesText
            // 
            lblAccessoriesText.AutoSize = true;
            lblAccessoriesText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccessoriesText.Location = new Point(611, 62);
            lblAccessoriesText.Name = "lblAccessoriesText";
            lblAccessoriesText.Size = new Size(264, 28);
            lblAccessoriesText.TabIndex = 7;
            lblAccessoriesText.Text = "Select phone's accessories:";
            // 
            // btnProceed
            // 
            btnProceed.Font = new Font("Segoe UI", 10F);
            btnProceed.Location = new Point(802, 452);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(120, 60);
            btnProceed.TabIndex = 13;
            btnProceed.Text = "&Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += BtnProceed_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(649, 452);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 11;
            btnClear.Text = "&Clear Selection";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(31, 19);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblWarrantyText);
            panel1.Controls.Add(lblContents);
            panel1.Controls.Add(lblDetails);
            panel1.Controls.Add(lblModel);
            panel1.Controls.Add(lblBrand);
            panel1.Controls.Add(lblWarranty);
            panel1.Controls.Add(lblPhoneContents);
            panel1.Controls.Add(lblPhoneModel);
            panel1.Controls.Add(lblPhoneDetails);
            panel1.Controls.Add(lblPhoneBrand);
            panel1.Location = new Point(26, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 478);
            panel1.TabIndex = 23;
            // 
            // lblWarrantyText
            // 
            lblWarrantyText.AutoSize = true;
            lblWarrantyText.Font = new Font("Segoe UI", 10F);
            lblWarrantyText.Location = new Point(4, 362);
            lblWarrantyText.Name = "lblWarrantyText";
            lblWarrantyText.Size = new Size(137, 23);
            lblWarrantyText.TabIndex = 27;
            lblWarrantyText.Text = "Phone Warranty:";
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Font = new Font("Segoe UI", 10F);
            lblContents.Location = new Point(4, 254);
            lblContents.Name = "lblContents";
            lblContents.Size = new Size(137, 23);
            lblContents.TabIndex = 26;
            lblContents.Text = "Phone Contents:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 10F);
            lblDetails.Location = new Point(4, 147);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(119, 23);
            lblDetails.TabIndex = 25;
            lblDetails.Text = "Phone Details:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 10F);
            lblModel.Location = new Point(4, 78);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(62, 23);
            lblModel.TabIndex = 24;
            lblModel.Text = "Model:";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 10F);
            lblBrand.Location = new Point(3, 13);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(59, 23);
            lblBrand.TabIndex = 23;
            lblBrand.Text = "Brand:";
            // 
            // lblWarranty
            // 
            lblWarranty.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWarranty.Location = new Point(3, 385);
            lblWarranty.Name = "lblWarranty";
            lblWarranty.Size = new Size(560, 75);
            lblWarranty.TabIndex = 6;
            lblWarranty.Text = "PhoneWarranty";
            // 
            // lblPhoneContents
            // 
            lblPhoneContents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhoneContents.Location = new Point(3, 277);
            lblPhoneContents.Name = "lblPhoneContents";
            lblPhoneContents.Size = new Size(560, 75);
            lblPhoneContents.TabIndex = 5;
            lblPhoneContents.Text = "PhoneContents";
            // 
            // lblPhoneModel
            // 
            lblPhoneModel.AutoSize = true;
            lblPhoneModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhoneModel.Location = new Point(4, 101);
            lblPhoneModel.Name = "lblPhoneModel";
            lblPhoneModel.Size = new Size(131, 28);
            lblPhoneModel.TabIndex = 4;
            lblPhoneModel.Text = "PhoneModel";
            // 
            // lblPhoneDetails
            // 
            lblPhoneDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhoneDetails.Location = new Point(3, 170);
            lblPhoneDetails.Name = "lblPhoneDetails";
            lblPhoneDetails.Size = new Size(560, 75);
            lblPhoneDetails.TabIndex = 3;
            lblPhoneDetails.Text = "PhoneDetails";
            // 
            // lblPhoneBrand
            // 
            lblPhoneBrand.AutoSize = true;
            lblPhoneBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhoneBrand.Location = new Point(4, 36);
            lblPhoneBrand.Name = "lblPhoneBrand";
            lblPhoneBrand.Size = new Size(127, 28);
            lblPhoneBrand.TabIndex = 2;
            lblPhoneBrand.Text = "PhoneBrand";
            // 
            // PhoneAccessoriesSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(1002, 603);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnProceed);
            Controls.Add(btnClear);
            Controls.Add(lblAccessoriesText);
            Controls.Add(grpAccessories);
            Controls.Add(lblDetailsText);
            Name = "PhoneAccessoriesSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Accessories Selection";
            Load += PhoneAccessoriesSelection_Load;
            grpAccessories.ResumeLayout(false);
            grpAccessories.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetailsText;
        private GroupBox grpAccessories;
        private CheckBox chkCharger;
        private CheckBox chkEarphone;
        private CheckBox chkScreenGuard;
        private CheckBox chkCover;
        private Label lblAccessoriesText;
        private Button btnProceed;
        private Button btnClear;
        private Button btnBack;
        private Panel panel1;
        private Label lblWarrantyText;
        private Label lblContents;
        private Label lblDetails;
        private Label lblModel;
        private Label lblBrand;
        private Label lblWarranty;
        private Label lblPhoneContents;
        private Label lblPhoneModel;
        private Label lblPhoneDetails;
        private Label lblPhoneBrand;
    }
}