using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larpmaster
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void playerBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the login form
            mainMenu mainMenuForm = new mainMenu(false); // Player role
            mainMenuForm.Show(); // Show the main menu
        }

        private void gameMasterBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the login form
            mainMenu mainMenuForm = new mainMenu(true); // Gamemaster role
            mainMenuForm.Show(); // Show the main menu

        }

        private void OpenMainMenu(bool isGameMaster)
        {
            this.Hide(); // Hide the LoginScreen

            mainMenu mainMenu = new mainMenu(isGameMaster);
            mainMenu.Show();

            // Close the LoginScreen after the MainMenu is shown
            mainMenu.FormClosed += (s, args) => this.Close();
        }

    }
}
