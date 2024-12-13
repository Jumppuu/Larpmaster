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
    public partial class ClassSelection : Form
    {
        private StatSelection statSelection;

        public ClassSelection(int yearsUsable)
        {
            InitializeComponent();
            statSelection = new StatSelection("race", "gender"); // Example initialization
            yearsUseableLbl.Text = $"Years Usable: {yearsUsable}";
            SubscribeToStatSelection(statSelection);
        }

        public void SubscribeToStatSelection(StatSelection statSelection)
        {
            this.statSelection = statSelection;
            statSelection.AgeConfirmed += UpdateYearsUseable;
        }

        private void UpdateYearsUseable()
        {
            int ageInput = statSelection.AgeInputValue;
            int minimumAge = statSelection.MinimumAgeValue;
            int yearsUseable = ageInput - minimumAge;
            yearsUseableLbl.Text = $"Years Usable: {yearsUseable}";
        }

        // Event handler for Cult buttons
        private void CultButton_Click(object sender, EventArgs e)
        {
            yearsInCultInput.Visible = true;
            yearsConfirmedBtn.Visible = true;
            yearsinCultLbl.Visible = true;
        }

        private void yearsConfirmedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var kingdomSelection = new KingdomSelection();
            kingdomSelection.Show();
        }
    }
}