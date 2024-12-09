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
    public partial class CreatedCharacterSummary : Form
    {
        public CreatedCharacterSummary()
        {
            InitializeComponent();
        }

        private void CharSummary_Delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu MainMenu = new mainMenu(false);
            MainMenu.Show();
        }
    }
}
