namespace Larpmaster
{
    public partial class mainMenu : Form
    {
        private bool isCharacterLoaded = false; // Flag to indicate if a character is loaded
        private string loadedCharacterFilePath = string.Empty; // Store the loaded character file path

        public mainMenu(bool isgameMaster)
        {
            InitializeComponent();
            UpdateUI(isgameMaster);

            // Subscribe to the FormClosed event
            this.FormClosed += new FormClosedEventHandler(MainMenu_FormClosed);
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUI(bool isgameMaster)
        {
            // Shows the gameMaster button if the user is a gameMaster
            gameMasterBtn.Visible = isgameMaster;
        }

        // Handle the FormClosed event to exit the application
        private void MainMenu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadCharBtn_Click(object sender, EventArgs e) // Event handler method when user clicks "lataa hahmo" -button.
        {
            if (LoadCharFileDialog.ShowDialog() == DialogResult.OK) // Opens browse file dialog. 
            {
                string filePath = LoadCharFileDialog.FileName;
                string characterName = GetCharacterNameFromFileName(filePath);

                if (!string.IsNullOrEmpty(characterName))
                {
                    MessageBox.Show($"Hahmo {characterName} ladattu");
                }
                else
                {
                    MessageBox.Show("Hahmo ladattu onnistuneesti.");
                }

                isCharacterLoaded = true; // Set the flag to true when a character is loaded
                loadedCharacterFilePath = filePath; // Store the file path
            }
        }

        private string GetCharacterNameFromFileName(string filePath)
        {
            // Extract the file name from the file path
            string fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);

            // Find the index of the underscore
            int underscoreIndex = fileName.IndexOf('_');

            if (underscoreIndex > 0)
            {
                // Extract the character name before the underscore
                return fileName.Substring(0, underscoreIndex);
            }

            return string.Empty;
        }

        private void gameMasterBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the main menu
            Pelinjohto adminPanelForm = new Pelinjohto(true); // Gamemaster role
            adminPanelForm.Show(); // Show the admin panel
        }

        private void newCharBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionManager.Instance.ClearSelections();
            NewCharacter newchar = new NewCharacter();
            newchar.Show();
        }

        private void charInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalSummaryAndSave finalSummary = new FinalSummaryAndSave(showSaveButton: false, loadedCharacterFilePath);
            finalSummary.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }
    }
}
