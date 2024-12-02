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
    public partial class GenderSelection : Form
    {
        private string selectedRace;

        public GenderSelection(string race)
        {
            InitializeComponent();
            selectedRace = race;
        }

        private void MaleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var charStats = new StatSelection(selectedRace, "Male");
            charStats.Show();
        }

        private void FemaleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var charStats = new StatSelection(selectedRace, "Female");
            charStats.Show();
        }

        private void BackButton_GenderSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCharacter newCharacter = new NewCharacter();
            newCharacter.Show();
        }
    }
}
