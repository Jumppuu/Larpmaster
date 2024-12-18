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
            statSelection = new StatSelection("rotu", "sukupuoli"); // Example initialization
            yearsUseableLbl.Text = $"Vuosia Käytettävissä: {yearsUsable}";
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
            yearsUseableLbl.Text = $"{yearsUseable}";
        }

        // Event handler for Cult buttons
        private void CultButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string selectedClass = button.Text;
                SetSelectedClass(selectedClass);
                MessageBox.Show($"Kultti {selectedClass} Valittu.");
            }

            yearsInCultInput.Visible = true;
            yearsConfirmedBtn.Visible = true;
            yearsinCultLbl.Visible = true;
        }

        private void yearsConfirmedBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(yearsInCultInput.Text, out int yearsInCult))
            {
                SelectionManager.Instance.Selections.YearsInCult = yearsInCult;
            }
            else
            {
                MessageBox.Show("Laita oikea määrä vuosia");
                return;
            }

            this.Hide();
            var kingdomSelection = new KingdomSelection();
            kingdomSelection.Show();
        }
        // Method to set the selected class
        private void SetSelectedClass(string selectedClass)
        {
            SelectionManager.Instance.Selections.Class = selectedClass;
        }

        private void yearsInCultInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}