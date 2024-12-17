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
    public partial class FinalSummaryAndSave : Form
    {
        public FinalSummaryAndSave()
        {
            InitializeComponent();
            DisplaySelections();
        }

        private void DisplaySelections()
        {
            var selections = SelectionManager.Instance.Selections;
            var formattedText = new StringBuilder();

            double physicalCondition = CalculatePhysicalCondition(selections.Age);


            formattedText.AppendLine("Hahmosi tiedot:");
            formattedText.AppendLine($"Rotu: {selections.Race}");
            formattedText.AppendLine($"Sukupuoli: {selections.Gender}");
            formattedText.AppendLine($"Ikä: {selections.Age}");
            formattedText.AppendLine($"Fyysinen kunto: {physicalCondition}%");
            formattedText.AppendLine($"Karisma: {selections.Charisma}");
            formattedText.AppendLine($"Voimakkuus: {selections.Strength}");
            formattedText.AppendLine($"Näppäryys: {selections.Dexterity}");
            formattedText.AppendLine($"Rakenne: {selections.Constitution}");
            formattedText.AppendLine($"Älykkyys: {selections.Intelligence}");
            formattedText.AppendLine($"Viisaus: {selections.Wisdom}");
            formattedText.AppendLine($"Ketteryys: {selections.Agility}");
            formattedText.AppendLine($"Kultti: {selections.Class}");
            formattedText.AppendLine($"Vuosia kultissa: {selections.YearsInCult}");
            formattedText.AppendLine($"Kuningaskunta: {selections.Kingdom}");
            formattedText.AppendLine($"Hahmon nimi: {selections.CharacterName}");
            formattedText.AppendLine($"Oikea nimi: {selections.RealName}");
            formattedText.AppendLine($"Aseet: {string.Join(", ", selections.Weapons)}");
            formattedText.AppendLine($"Tehtävät: {selections.Tasks}");
            formattedText.AppendLine($"Muuta: {selections.OtherInfo}");

            summaryTextBox.Text = formattedText.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var selections = SelectionManager.Instance.Selections;
            var txt = new StringBuilder();

            double physicalCondition = CalculatePhysicalCondition(selections.Age);

            txt.AppendLine("Hahmosi tiedot:");
            txt.AppendLine("Rotu: " + selections.Race);
            txt.AppendLine("Sukupuoli: " + selections.Gender);
            txt.AppendLine("Ikä: " + selections.Age);
            txt.AppendLine("Fyysinen kunto: " + physicalCondition + "%");
            txt.AppendLine("Karisma: " + selections.Charisma);
            txt.AppendLine("Voimakkuus: " + selections.Strength);
            txt.AppendLine("Näppäryys: " + selections.Dexterity);
            txt.AppendLine("Rakenne: " + selections.Constitution);
            txt.AppendLine("Älykkyys: " + selections.Intelligence);
            txt.AppendLine("Viisaus: " + selections.Wisdom);
            txt.AppendLine("Ketteryys: " + selections.Agility);
            txt.AppendLine("Kultti: " + selections.Class);
            txt.AppendLine("Vuosia kultissa: " + selections.YearsInCult);
            txt.AppendLine("Kuningaskunta: " + selections.Kingdom);
            txt.AppendLine("Hahmon nimi: " + selections.CharacterName);
            txt.AppendLine("Oikea nimi: " + selections.RealName);
            txt.AppendLine("Aseet: " + string.Join(", ", selections.Weapons));
            txt.AppendLine("Tehtävät: " + selections.Tasks);
            txt.AppendLine("Muuta: " + selections.OtherInfo);


            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text file (*.txt)|*.txt";
                saveFileDialog.InitialDirectory = @"C:\Downloads";
                saveFileDialog.FileName = $"{selections.CharacterName}_Luotuhahmo.txt"; // Use character name for file name
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, txt.ToString());
                    MessageBox.Show("Hahmon tallennus onnistui.");
                }
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
                // After age 22, there's a small chance of physical condition decreasing each year
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

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            SelectionManager.Instance.ClearSelections();
            this.Hide();
            mainMenu MainMenu = new mainMenu(false);
            MainMenu.Show();
        }
    }
}
