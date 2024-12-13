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
        private int yearsUsable;
        public CreatedCharacterSummary(int yearsUsable)
        {
            InitializeComponent();
            this.yearsUsable = yearsUsable;
        }

        private void CharSummary_Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Oletko varma, että haluat poistaa luomasi hahmon?", "Huomio!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                var MainMenu = new mainMenu(false);
                MainMenu.Show();
            }
        }

        private void CharSummary_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassSelection classSelection = new ClassSelection(yearsUsable);
            classSelection.Show();
        }
    }
}
