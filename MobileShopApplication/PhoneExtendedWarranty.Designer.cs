namespace MobileShopApplication
{
    partial class PhoneExtendedWarranty
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
            btnBack = new Button();
            lblDetailsText = new Label();
            btnProceed = new Button();
            btnClear = new Button();
            grpExtendedWarranty = new GroupBox();
            rdoBtnOneYear = new RadioButton();
            rdoBtnThreeYears = new RadioButton();
            rdoBtnTwoYears = new RadioButton();
            rdoBtnSixMonths = new RadioButton();
            lblExtendedWarrantyText = new Label();
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
            grpExtendedWarranty.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(32, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // lblDetailsText
            // 
            lblDetailsText.AutoSize = true;
            lblDetailsText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailsText.Location = new Point(27, 58);
            lblDetailsText.Name = "lblDetailsText";
            lblDetailsText.Size = new Size(244, 28);
            lblDetailsText.TabIndex = 15;
            lblDetailsText.Text = "Selected phone's details:";
            // 
            // btnProceed
            // 
            btnProceed.Font = new Font("Segoe UI", 10F);
            btnProceed.Location = new Point(814, 500);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(120, 60);
            btnProceed.TabIndex = 19;
            btnProceed.Text = "&Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += BtnProceed_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(662, 500);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 18;
            btnClear.Text = "&Clear Selection";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // grpExtendedWarranty
            // 
            grpExtendedWarranty.Controls.Add(rdoBtnOneYear);
            grpExtendedWarranty.Controls.Add(rdoBtnThreeYears);
            grpExtendedWarranty.Controls.Add(rdoBtnTwoYears);
            grpExtendedWarranty.Controls.Add(rdoBtnSixMonths);
            grpExtendedWarranty.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpExtendedWarranty.Location = new Point(601, 103);
            grpExtendedWarranty.Name = "grpExtendedWarranty";
            grpExtendedWarranty.Size = new Size(389, 344);
            grpExtendedWarranty.TabIndex = 20;
            grpExtendedWarranty.TabStop = false;
            grpExtendedWarranty.Text = "Phone's Extended Warranty";
            // 
            // rdoBtnOneYear
            // 
            rdoBtnOneYear.Location = new Point(31, 115);
            rdoBtnOneYear.Name = "rdoBtnOneYear";
            rdoBtnOneYear.Size = new Size(350, 70);
            rdoBtnOneYear.TabIndex = 4;
            rdoBtnOneYear.TabStop = true;
            rdoBtnOneYear.Text = "1 Year Extended Warranty";
            rdoBtnOneYear.UseVisualStyleBackColor = true;
            // 
            // rdoBtnThreeYears
            // 
            rdoBtnThreeYears.Location = new Point(31, 267);
            rdoBtnThreeYears.Name = "rdoBtnThreeYears";
            rdoBtnThreeYears.Size = new Size(350, 70);
            rdoBtnThreeYears.TabIndex = 3;
            rdoBtnThreeYears.TabStop = true;
            rdoBtnThreeYears.Text = "3 Years Extended Warranty";
            rdoBtnThreeYears.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTwoYears
            // 
            rdoBtnTwoYears.Location = new Point(31, 191);
            rdoBtnTwoYears.Name = "rdoBtnTwoYears";
            rdoBtnTwoYears.Size = new Size(350, 70);
            rdoBtnTwoYears.TabIndex = 2;
            rdoBtnTwoYears.TabStop = true;
            rdoBtnTwoYears.Text = "2 Years Extended Warranty";
            rdoBtnTwoYears.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSixMonths
            // 
            rdoBtnSixMonths.Location = new Point(31, 39);
            rdoBtnSixMonths.Name = "rdoBtnSixMonths";
            rdoBtnSixMonths.Size = new Size(350, 70);
            rdoBtnSixMonths.TabIndex = 0;
            rdoBtnSixMonths.TabStop = true;
            rdoBtnSixMonths.Text = "6 months Extended Warranty";
            rdoBtnSixMonths.UseVisualStyleBackColor = true;
            // 
            // lblExtendedWarrantyText
            // 
            lblExtendedWarrantyText.AutoSize = true;
            lblExtendedWarrantyText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblExtendedWarrantyText.Location = new Point(601, 58);
            lblExtendedWarrantyText.Name = "lblExtendedWarrantyText";
            lblExtendedWarrantyText.Size = new Size(360, 28);
            lblExtendedWarrantyText.TabIndex = 21;
            lblExtendedWarrantyText.Text = "Selected phone's extended warranty:";
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
            panel1.Location = new Point(27, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 478);
            panel1.TabIndex = 22;
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
            // PhoneExtendedWarranty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 603);
            Controls.Add(panel1);
            Controls.Add(lblExtendedWarrantyText);
            Controls.Add(grpExtendedWarranty);
            Controls.Add(btnProceed);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(lblDetailsText);
            Name = "PhoneExtendedWarranty";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Extended Warranty Selection";
            Load += PhoneExtendedWarranty_Load;
            grpExtendedWarranty.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblDetailsText;
        private Button btnProceed;
        private Button btnClear;
        private GroupBox grpExtendedWarranty;
        private RadioButton rdoBtnSixMonths;
        private RadioButton rdoBtnTwoYears;
        private RadioButton rdoBtnOneYear;
        private RadioButton rdoBtnThreeYears;
        private Label lblExtendedWarrantyText;
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