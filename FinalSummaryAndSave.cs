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

            formattedText.AppendLine("Hahmosi tiedot:");
            formattedText.AppendLine($"Rotu: {selections.Race}");
            formattedText.AppendLine($"Sukupuoli: {selections.Gender}");
            formattedText.AppendLine($"Ikä: {selections.Age}");
            formattedText.AppendLine("Fyysinenkunto 100%"); // Placeholder for future feature
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

            txt.AppendLine("Hahmosi tiedot:");
            txt.AppendLine("Rotu: " + selections.Race);
            txt.AppendLine("Sukupuoli: " + selections.Gender);
            txt.AppendLine("Ikä: " + selections.Age);
            txt.AppendLine("Fyysinenkunto 100%"); // Placeholder for future feature
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

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            SelectionManager.Instance.ClearSelections();
            this.Hide();
            mainMenu MainMenu = new mainMenu(false);
            MainMenu.Show();
        }
    }
}
