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
        private void CreatedCharacterSummary_Load(object sender, EventArgs e)
        {
            if (SavedStats.CharStats.ContainsKey("Int"))

                IntValue.Text = $"{SavedStats.CharStats["Int"]}";

            if (SavedStats.CharStats.ContainsKey("Wis"))
                WisValue.Text = $"{SavedStats.CharStats["Wis"]}";

            if (SavedStats.CharStats.ContainsKey("Str"))
                StrValue.Text = $"{SavedStats.CharStats["Str"]}";

            if (SavedStats.CharStats.ContainsKey("Dex"))
                DexValue.Text = $"{SavedStats.CharStats["Dex"]}";

            if (SavedStats.CharStats.ContainsKey("Con"))
                ConValue.Text = $"{SavedStats.CharStats["Con"]}";

            if (SavedStats.CharStats.ContainsKey("Agi"))
                AgiValue.Text = $"{SavedStats.CharStats["Agi"]}";

            if (SavedStats.CharStats.ContainsKey("Cha"))
                ChaValue.Text = $"{SavedStats.CharStats["Cha"]}";

            if (SavedStats.CharStats.ContainsKey("Age"))
            
               AgeValue.Text = $"{SavedStats.CharStats["Age"]}";
            
            ConPercentage.Text = CalculatePhysicalCondition(int.Parse(AgeValue.Text)).ToString();
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

        private double CalculatePhysicalCondition(int age)
        {
            if (age < 0)
                return 0;

            if (age <= 22)
            {
                // Physical condition grows rapidly to 85% until age 18, then slower to 100% by age 22
                if (age <= 18)
                    return age * 85.0 / 18;
                else
                    return 85 + (age - 18) * 15.0 / 4;
            }
            else
            {

                Random random = new Random();
                double physicalCondition = 100;
                for (int i = 23; i <= age; i++)
                {
                    if (random.NextDouble() < 0.05) // 5% chance of decrease each year
                        physicalCondition -= random.Next(1, 5); // Decrease by 1 to 4 percent
                    if (physicalCondition < 0)
                        physicalCondition = 0;
                }
                return physicalCondition;
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
