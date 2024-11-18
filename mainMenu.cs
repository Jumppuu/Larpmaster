namespace Larpmaster
{
    public partial class mainMenu : Form
    {


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
            if (LoadCharFileDialog.ShowDialog() == DialogResult.OK) // Opens browse file dialog. If user has chosen a file and clicked "OK" (instead of closing dialog window or clicked cancel)
            {                                                       // Message box containing the chosen file's filepath is shown.
                MessageBox.Show(LoadCharFileDialog.FileName);
            }
        }

        private void gameMasterBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the main menu
            Pelinjohto adminPanelForm = new Pelinjohto(true); // Gamemaster role
            adminPanelForm.Show(); // Show the admin panel
        }


        private void newCharBtn_Click(object sender, EventArgs e)
        {
            NewCharacter newchar = new NewCharacter();

            newchar.ShowDialog();
        }

        private void titleLbl_Click(object sender, EventArgs e)
        {

        }
    }

}
