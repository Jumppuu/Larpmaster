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

            formattedText.AppendLine($"Rotu: {selections.Race}");
            formattedText.AppendLine($"Sukupuoli: {selections.Gender}");
            formattedText.AppendLine($"Ikä: {selections.Age}");
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
            var csv = new StringBuilder();

            csv.AppendLine("Rotu: " + selections.Race);
            csv.AppendLine("Sukupuoli: " + selections.Gender);
            csv.AppendLine("Ikä: " + selections.Age);
            csv.AppendLine("Karisma: " + selections.Charisma);
            csv.AppendLine("Voimakkuus: " + selections.Strength);
            csv.AppendLine("Näppäryys: " + selections.Dexterity);
            csv.AppendLine("Rakenne: " + selections.Constitution);
            csv.AppendLine("Älykkyys: " + selections.Intelligence);
            csv.AppendLine("Viisaus: " + selections.Wisdom);
            csv.AppendLine("Ketteryys: " + selections.Agility);
            csv.AppendLine("Kultti: " + selections.Class);
            csv.AppendLine("Vuosia kultissa: " + selections.YearsInCult);
            csv.AppendLine("Kuningaskunta: " + selections.Kingdom);
            csv.AppendLine("Hahmon nimi: " + selections.CharacterName);
            csv.AppendLine("Oikea nimi: " + selections.RealName);
            csv.AppendLine("Aseet: " + string.Join(", ", selections.Weapons));
            csv.AppendLine("Tehtävät: " + selections.Tasks);
            csv.AppendLine("Muuta: " + selections.OtherInfo);


            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.InitialDirectory = @"C:\Downloads";
                saveFileDialog.FileName = $"{selections.CharacterName}_Luotuhahmo.csv"; // Use character name for file name
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, csv.ToString());
                    MessageBox.Show("Hahmon tallennus onnistui.");
                }
            }
        }
    }
}
