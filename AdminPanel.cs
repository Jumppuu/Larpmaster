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
    public partial class Pelinjohto : Form
    {
        public Pelinjohto(bool isGameMaster)
        {
            InitializeComponent();
            // Additional initialization code here
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // Load event handler code here
        }

        private void playerModeSelectionBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide admin panel
            mainMenu mainMenuForm = new mainMenu(true); // Back to player mode
            mainMenuForm.Show(); // Show the main menu
        }
    }
}
