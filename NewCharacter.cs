using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larpmaster
{
    public partial class NewCharacter : Form
    {
        public NewCharacter()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RaceBtn_Human_Click(object sender, EventArgs e)
        {
            OpenGenderSelection("Ihminen");
            SelectionManager.Instance.Selections.Race = "Ihminen";
        }

        private void RaceBtn_Elf_Click(object sender, EventArgs e)
        {
            OpenGenderSelection("Haltija");
            SelectionManager.Instance.Selections.Race = "Haltija";
        }

        private void RaceBtn_HalfElf_Click(object sender, EventArgs e)
        {
            OpenGenderSelection("Puolihaltija");
            SelectionManager.Instance.Selections.Race = "Puolihaltija";
        }
        private void RaceBtn_Peikko_Click(object sender, EventArgs e)
        {
            OpenGenderSelection("Peikko");
        }

        private void OpenGenderSelection(string race)
        {
            this.Hide();
            var genderSelection = new GenderSelection(race);
            genderSelection.Show();
        }
        


        private void BackButton_NewChar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu MainMenu = new mainMenu(false);
            MainMenu.Show();
        }
    }
}
