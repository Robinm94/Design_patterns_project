namespace MobileShopApplication
{
    public partial class PhoneSelection : Form
    {
        // Store the selected phone model
        string phoneModel = string.Empty;

        // Text to display when a phone model is selected
        string selectedText = "You have selected:";

        // Text to display when no phone model is selected
        string notSelectedText = "You have not selected any phone model yet.";

        // Dictionary to map class names to display names
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

        public PhoneSelection()
        {
            InitializeComponent();
        }

        // Initialize the form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set initial text
            lblSelectedText.Text = notSelectedText;
            lblSelectionBrand.Text = string.Empty;
            lblSelectionModel.Text = string.Empty;
        }

        // Handle click event for phone PictureBoxes
        private void PBoxPhone_Click(object sender, EventArgs e)
        {
            // Get the clicked PictureBox
            PictureBox pBox = (PictureBox)sender;

            // Extract the phone model from the PictureBox's Tag
            phoneModel = pBox.Tag!.ToString()!.Split(',')[1].Trim();

            // Display the selected phone model and brand
            lblSelectionModel.Text = phoneModels.GetValueOrDefault(phoneModel, string.Empty);
            lblSelectionBrand.Text = pBox.Tag!.ToString()!.Split(',')[0].Trim();
            lblSelectedText.Text = selectedText;
        }

        // Handle click event for the exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Ask the user to confirm before exiting
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Handle click event for the clear button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Clear the selected phone model and reset the text
            phoneModel = string.Empty;
            lblSelectedText.Text = notSelectedText;
            lblSelectionModel.Text = string.Empty;
            lblSelectionBrand.Text = string.Empty;
        }

        // Handle click event for the proceed button
        private void BtnProceed_Click(object sender, EventArgs e)
        {
            // Check if a phone model is selected
            if (phoneModel == string.Empty)
            {
                MessageBox.Show("Please select a phone model first.", "No phone model selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Create the selected phone and ask the user to confirm
                SingletonPhoneFactory phoneFactory = SingletonPhoneFactory.GetInstance();
                IPhoneComponent phone = phoneFactory.CreatePhone((PhoneType)Enum.Parse(typeof(PhoneType), lblSelectionBrand.Text), phoneModel);
                DialogResult dialogResult = MessageBox.Show(phone.GetDetails() + "\n\n Would you like to proceed", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    // Proceed to the accessories selection form
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
