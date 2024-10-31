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
            // Assuming you have a button named specialButton
            gameMasterBtn.Visible = isgameMaster;
        }
    }
}
