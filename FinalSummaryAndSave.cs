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

            formattedText.AppendLine($"Race: {selections.Race}");
            formattedText.AppendLine($"Gender: {selections.Gender}");
            formattedText.AppendLine($"Age: {selections.Age}");
            formattedText.AppendLine($"Charisma: {selections.Charisma}");
            formattedText.AppendLine($"Strength: {selections.Strength}");
            formattedText.AppendLine($"Dexterity: {selections.Dexterity}");
            formattedText.AppendLine($"Constitution: {selections.Constitution}");
            formattedText.AppendLine($"Intelligence: {selections.Intelligence}");
            formattedText.AppendLine($"Wisdom: {selections.Wisdom}");
            formattedText.AppendLine($"Agility: {selections.Agility}");
            formattedText.AppendLine($"Class: {selections.Class}");
            formattedText.AppendLine($"Years in Cult: {selections.YearsInCult}");
            formattedText.AppendLine($"Kingdom: {selections.Kingdom}");
            formattedText.AppendLine($"Character Name: {selections.CharacterName}");
            formattedText.AppendLine($"Real Name: {selections.RealName}");
            formattedText.AppendLine($"Weapons: {string.Join(", ", selections.Weapons)}");
            formattedText.AppendLine($"Tasks: {selections.Tasks}");
            formattedText.AppendLine($"Other Info: {selections.OtherInfo}");

            summaryTextBox.Text = formattedText.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var selections = SelectionManager.Instance.Selections;
            var csv = $"Race,Gender,Age,Charisma,Class,YearsInCult,Kingdom,CharacterName,RealName,Weapons,Tasks,OtherInfo\n" +
                      $"{selections.Race},{selections.Gender},{selections.Age},{selections.Charisma},{selections.Agility},{selections.Wisdom},{selections.Strength},{selections.Dexterity},{selections.Constitution},{selections.Intelligence},{selections.Class},{selections.YearsInCult},{selections.Kingdom},{selections.CharacterName},{selections.RealName},{string.Join(";", selections.Weapons)},{selections.Tasks},{selections.OtherInfo}";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.InitialDirectory = @"C:\Downloads";
                saveFileDialog.FileName = $"{selections.CharacterName}_CharacterSelections.csv"; // Use character name for file name
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, csv);
                    MessageBox.Show("File saved successfully.");
                }
            }
        }
    }
}
