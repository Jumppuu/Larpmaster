namespace Larpmaster
{
    public partial class mainMenu : Form
    {


        public mainMenu(bool isgameMaster)
        {
            InitializeComponent();
            UpdateUI(isgameMaster);

        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUI(bool isgameMaster)
        {
            // Shows the gameMaster button if the user is a gameMaster
            gameMasterBtn.Visible = isgameMaster;
        }

        private void loadCharBtn_Click(object sender, EventArgs e) // Event handler method when user clicks "lataa hahmo" -button.
        {
            if (LoadCharFileDialog.ShowDialog() == DialogResult.OK) // Opens browse file dialog. If user has chosen a file and clicked "OK" (instead of closing dialog window or clicked cancel)
            {                                                       // Message box containing the chosen file's filepath is shown.
                MessageBox.Show(LoadCharFileDialog.FileName);
            }
        }

        private void newCharBtn_Click(object sender, EventArgs e)
        {
                NewCharacter newchar = new NewCharacter();

                newchar.ShowDialog();
        }

    }
}
