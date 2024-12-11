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

            if (MessageBox.Show("Oletko varma, että haluat poistaa luomasi hahmon?", "Huomio!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                mainMenu MainMenu = new mainMenu(false);
                MainMenu.Show();
            }



        }

        private void CharSummary_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassSelection classSelection = new ClassSelection();
            classSelection.Show();
        }

        
    }
}
