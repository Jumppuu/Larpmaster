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
    }
}
