namespace MobileShopApplication
{
    public partial class Form1 : Form
    {
        string phoneModel = string.Empty;
        string selectedText = "You have selected:";
        string notSelectedText = "You have not selected any phone model yet.";

        Dictionary<string, string> phoneModels = new Dictionary<string, string>
        {
            { "IPhone12", "iPhone 12" },
            { "IPhone12Pro", "iPhone 12 Pro" },
            { "IPhone14ProMax", "iPhone 14 Pro Max" },
            { "A74", "A74" },
            { "FindX3Pro", "Find X3 Pro" },
            { "Reno5Pro", "Reno5 Pro" },
            { "GalaxyNote20Ultra", "Galaxy Note20 Ultra" },
            { "GalaxyS21", "Galaxy S21" },
            { "GalaxyS21Ultra", "Galaxy S21 Ultra" },
            { "Mi11", "Mi 11" },
            { "PocoX3", "Poco X3" },
            { "RedmiNote10", "Redmi Note 10" }
        };

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSelectedText.Text = notSelectedText;
            lblSelectionBrand.Text = string.Empty;
            lblSelectionModel.Text = string.Empty;
        }

        private void PBoxPhone_Click(object sender, EventArgs e)
        {
            PictureBox pBox = (PictureBox)sender;
            phoneModel = pBox.Tag!.ToString()!.Split(',')[1].Trim();
            lblSelectionModel.Text = phoneModels.GetValueOrDefault(phoneModel, string.Empty);
            lblSelectionBrand.Text = pBox.Tag!.ToString()!.Split(',')[0].Trim();
            lblSelectedText.Text = selectedText;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            phoneModel = string.Empty;
            lblSelectedText.Text = notSelectedText;
            lblSelectionModel.Text = string.Empty;
            lblSelectionBrand.Text = string.Empty;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (phoneModel == string.Empty)
            {
                MessageBox.Show("Please select a phone model first.", "No phone model selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SingletonPhoneFactory phoneFactory = SingletonPhoneFactory.GetInstance();
                IPhoneComponent phone = phoneFactory.CreatePhone((PhoneType)Enum.Parse(typeof(PhoneType), lblSelectionBrand.Text), phoneModel);
                DialogResult dialogResult = MessageBox.Show(phone.GetDetails() + "\n\n Would you like to proceed", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    PhoneAccessoriesSelection phoneAccessoriesSelection = new PhoneAccessoriesSelection(phone);
                    this.Hide();
                    DialogResult result = phoneAccessoriesSelection.ShowDialog();
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
}
