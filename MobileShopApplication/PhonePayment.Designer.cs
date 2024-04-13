namespace MobileShopApplication
{
    partial class PhonePayment
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
            lblDetailsText = new Label();
            pBoxPhone = new PictureBox();
            btnPayment = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxPhone).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(17, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 20;
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
            panel1.Location = new Point(12, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 478);
            panel1.TabIndex = 19;
            // 
            // lblWarrantyText
            // 
            lblWarrantyText.AutoSize = true;
            lblWarrantyText.Font = new Font("Segoe UI", 10F);
            lblWarrantyText.Location = new Point(4, 359);
            lblWarrantyText.Name = "lblWarrantyText";
            lblWarrantyText.Size = new Size(137, 23);
            lblWarrantyText.TabIndex = 27;
            lblWarrantyText.Text = "Phone Warranty:";
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Font = new Font("Segoe UI", 10F);
            lblContents.Location = new Point(4, 251);
            lblContents.Name = "lblContents";
            lblContents.Size = new Size(137, 23);
            lblContents.TabIndex = 26;
            lblContents.Text = "Phone Contents:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 10F);
            lblDetails.Location = new Point(4, 144);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(119, 23);
            lblDetails.TabIndex = 25;
            lblDetails.Text = "Phone Details:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 10F);
            lblModel.Location = new Point(4, 75);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(62, 23);
            lblModel.TabIndex = 24;
            lblModel.Text = "Model:";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 10F);
            lblBrand.Location = new Point(3, 10);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(59, 23);
            lblBrand.TabIndex = 23;
            lblBrand.Text = "Brand:";
            // 
            // lblWarranty
            // 
            lblWarranty.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWarranty.Location = new Point(3, 382);
            lblWarranty.Name = "lblWarranty";
            lblWarranty.Size = new Size(560, 75);
            lblWarranty.TabIndex = 6;
            lblWarranty.Text = "PhoneWarranty";
            // 
            // lblPhoneContents
            // 
            lblPhoneContents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhoneContents.Location = new Point(3, 274);
            lblPhoneContents.Name = "lblPhoneContents";
            lblPhoneContents.Size = new Size(560, 75);
            lblPhoneContents.TabIndex = 5;
            lblPhoneContents.Text = "PhoneContents";
            // 
            // lblPhoneModel
            // 
            lblPhoneModel.AutoSize = true;
            lblPhoneModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhoneModel.Location = new Point(4, 98);
            lblPhoneModel.Name = "lblPhoneModel";
            lblPhoneModel.Size = new Size(131, 28);
            lblPhoneModel.TabIndex = 4;
            lblPhoneModel.Text = "PhoneModel";
            // 
            // lblPhoneDetails
            // 
            lblPhoneDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhoneDetails.Location = new Point(3, 167);
            lblPhoneDetails.Name = "lblPhoneDetails";
            lblPhoneDetails.Size = new Size(560, 75);
            lblPhoneDetails.TabIndex = 3;
            lblPhoneDetails.Text = "PhoneDetails";
            // 
            // lblPhoneBrand
            // 
            lblPhoneBrand.AutoSize = true;
            lblPhoneBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhoneBrand.Location = new Point(4, 33);
            lblPhoneBrand.Name = "lblPhoneBrand";
            lblPhoneBrand.Size = new Size(127, 28);
            lblPhoneBrand.TabIndex = 2;
            lblPhoneBrand.Text = "PhoneBrand";
            // 
            // lblDetailsText
            // 
            lblDetailsText.AutoSize = true;
            lblDetailsText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailsText.Location = new Point(12, 54);
            lblDetailsText.Name = "lblDetailsText";
            lblDetailsText.Size = new Size(244, 28);
            lblDetailsText.TabIndex = 18;
            lblDetailsText.Text = "Selected phone's details:";
            // 
            // pBoxPhone
            // 
            pBoxPhone.Location = new Point(616, 17);
            pBoxPhone.Name = "pBoxPhone";
            pBoxPhone.Size = new Size(350, 455);
            pBoxPhone.TabIndex = 21;
            pBoxPhone.TabStop = false;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 16F);
            btnPayment.Location = new Point(636, 496);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(310, 60);
            btnPayment.TabIndex = 22;
            btnPayment.Text = "&Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += BtnPayment_Click;
            // 
            // PhonePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(1002, 603);
            Controls.Add(btnPayment);
            Controls.Add(pBoxPhone);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(lblDetailsText);
            Name = "PhonePayment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Payment And Confirmation";
            Load += PhonePayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxPhone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Panel panel1;
        private Label lblWarranty;
        private Label lblPhoneContents;
        private Label lblPhoneModel;
        private Label lblPhoneDetails;
        private Label lblPhoneBrand;
        private Label lblDetailsText;
        private PictureBox pBoxPhone;
        private Button btnPayment;
        private Label lblContents;
        private Label lblDetails;
        private Label lblModel;
        private Label lblBrand;
        private Label lblWarrantyText;
    }
}