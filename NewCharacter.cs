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
            OpenStatSelection("Human");
        }

        private void RaceBtn_Elf_Click(object sender, EventArgs e)
        {
            OpenStatSelection("Elf");
        }

        private void RaceBtn_HalfElf_Click(object sender, EventArgs e)
        {
            OpenStatSelection("HalfElf");
        }
        private void RaceBtn_Peikko_Click(object sender, EventArgs e)
        {
            OpenStatSelection("Peikko");
        }

        private void OpenStatSelection(string race)
        {
            this.Hide();
            GenderSelection CharSex = new GenderSelection(race);
            CharSex.Show();
        }

        private void NewCharacter_Load(object sender, EventArgs e)
        {

        }

        
    }
}
