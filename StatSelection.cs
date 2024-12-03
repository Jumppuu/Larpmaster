using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Larpmaster
{
    public partial class StatSelection : Form
    {
        private Random random = new Random();

        // Dictionary to store race-specific age data
        private Dictionary<string, (int averageLifespan, int minimumAge)> raceAgeData = new Dictionary<string, (int, int)>
        {
            { "Ihminen", (50, 14) },
            { "Haltija", (430, 60) },
            { "Puolihaltija", (90, 21) }
        };

        // Dictionary to store race-specific stat multipliers
        private Dictionary<string, Dictionary<string, double>> raceStatMultipliers = new Dictionary<string, Dictionary<string, double>>
        {
            { "Ihminen", new Dictionary<string, double> { { "Str", 1.0 }, { "Dex", 1.0 }, { "Con", 1.0 }, { "Int", 1.0 }, { "Wis", 1.0 }, { "Cha", 1.0 }, { "Agi", 1.0 } } },
            { "Haltija", new Dictionary<string, double> { { "Str", 0.96 }, { "Dex", 1.02 }, { "Con", 0.74 }, { "Int", 1.02 }, { "Wis", 1.04 }, { "Cha", 1.05 }, { "Agi", 1.04 } } },
            { "Puolihaltija", new Dictionary<string, double> { { "Str", 0.99 }, { "Dex", 1.01 }, { "Con", 0.91 }, { "Int", 1.01 }, { "Wis", 1.02 }, { "Cha", 0.99 }, { "Agi", 1.02 } } }
        };

        private string currentRace;

        // Constructor
        public StatSelection(string race, string gender)
        {
            InitializeComponent();
            InitializeDragAndDrop();
            currentRace = race;

            this.Load += (sender, e) => GenerateStats();
        }
        // Method to update race and age labels

        private void UpdateRaceAndAgeLabels(string race)
        {

            raceLabel.Text = $"Rodun {race}";

            if (raceAgeData.TryGetValue(race, out var ageData))
            {
                averageLifespanLabel.Text = $"Keskimääräinen elinikä: {ageData.averageLifespan} vuotta";
                minimumAgeLabel.Text = $"Minimi ikä: {ageData.minimumAge} vuotta";


            }
            else
            {
                averageLifespanLabel.Text = "Keskimääräinen elinikä: Tuntematon";
                minimumAgeLabel.Text = "Minimi ikä: Tuntematon";
            }

            if (raceStatMultipliers.TryGetValue(race, out var multipliers))
            {
                strMultiplierLbl.Text = $"{multipliers["Str"] * 100:F2}%";
                dexMultiplierLbl.Text = $"{multipliers["Dex"] * 100:F2}%";
                conMultiplierLbl.Text = $"{multipliers["Con"] * 100:F2}%";
                intMultiplierLbl.Text = $"{multipliers["Int"] * 100:F2}%";
                wisMultiplierLbl.Text = $"{multipliers["Wis"] * 100:F2}%";
                chaMultiplierLbl.Text = $"{multipliers["Cha"] * 100:F2}%";
                agiMultiplierLbl.Text = $"{multipliers["Agi"] * 100:F2}%";
            }
        }



        // Method to initialize drag-and-drop functionality
        private void InitializeDragAndDrop()
        {
            var dragDropControls = new List<Control> { StatValue1, StatValue2, StatValue3, StatValue4, StatValue5, StatValue6, StatValue7, StatValue8, StatValue_Int, StatValue_Wis,
                                                      StatValue_Str, StatValue_Dex, StatValue_Con, StatValue_Agi, StatValue_Cha };

            foreach (var control in dragDropControls)
            {
                control.AllowDrop = true;
                control.MouseDown += new MouseEventHandler(Control_MouseDown);
                control.DragEnter += new DragEventHandler(Control_DragEnter);
                control.DragDrop += new DragEventHandler(Control_DragDrop);
            }
        }

        // Event handler for mouse down event
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            if (control != null && !string.IsNullOrWhiteSpace(control.Text))
            {
                var data = new DataObject();
                data.SetData(DataFormats.Text, control.Text);
                data.SetData("sourceControl", control);

                DoDragDrop(data, DragDropEffects.Move);
            }
        }

        // Event handler for drag enter event
        private void Control_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Event handler for drag drop event
        private void Control_DragDrop(object sender, DragEventArgs e)
        {
            var targetControl = sender as Control;
            if (targetControl != null)
            {
                string draggedText = (string)e.Data.GetData(DataFormats.Text);

                if (e.Data.GetDataPresent("sourceControl"))
                {
                    var sourceControl = e.Data.GetData("sourceControl") as Control;
                    if (sourceControl != null)
                    {
                        if (string.IsNullOrWhiteSpace(targetControl.Text))
                        {
                            targetControl.Text = draggedText;
                            sourceControl.Text = string.Empty;
                        }
                        else
                        {
                            string targetText = targetControl.Text;
                            targetControl.Text = draggedText;
                            sourceControl.Text = targetText;
                        }
                    }

                    UpdateFinalStats();
                }
            }
        }

        // Method to generate stats
        private void GenerateStats()
        {
            var stats = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                int stat = RollStat();
                stats.Add(stat);
            }

            DisplayStats(stats);
            BeginInvoke(new Action(() => CheckAndPromptForReroll(stats)));
        }

        // Method to check and prompt for re-roll
        private void CheckAndPromptForReroll(List<int> stats)
        {
            if (stats.Count(s => s > 100) < 3)
            {
                if (MessageBox.Show("3 Arvoa on alle 100 haluatko heittää uudestaan vai olla nössö?", "Re-roll Stats", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ReRollStats();
                    return;
                }
            }

            if (stats.Any(s => s > 150))
            {
                if (MessageBox.Show("Yksi tai useampi arvo on yli 150 haluatko heittää uudestaan?", "Re-roll Stats", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ReRollStats();
                }
            }
        }

        // Method to re-roll stats
        private void ReRollStats()
        {
            var stats = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                int stat = RollStat();
                stats.Add(stat);
            }

            DisplayStats(stats);
            BeginInvoke(new Action(() => CheckAndPromptForReroll(stats)));
        }

        // Method to roll a single stat
        private int RollStat()
        {
            double total = 0;

            for (int i = 0; i < 10; i++)
            {
                total += RollNormal(10.5, 5.8) - 1;
            }

            double d10 = RollNormal(5.5, 2.9);
            total += d10;

            while (d10 >= 9.5)
            {
                d10 = RollNormal(5.5, 2.9);
                total += d10;
            }

            while (d10 <= 1.5)
            {
                d10 = RollNormal(5.5, 2.9);
                total -= d10;
                if (total < 0) total = 0;
            }

            return (int)Math.Round(total);
        }

        // Method to roll a normal distribution
        private double RollNormal(double mean, double stdDev)
        {
            double u1 = random.NextDouble();
            double u2 = random.NextDouble();
            if (u1 < 1e-7) u1 = 1e-7;
            // Box-Muller transform: Converts uniform random numbers (u1, u2) into standard normal distribution
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            return mean + stdDev * randStdNormal;
        }

        // Method to display stats
        private void DisplayStats(List<int> stats)
        {
            StatValue1.Text = stats[0].ToString();
            StatValue2.Text = stats[1].ToString();
            StatValue3.Text = stats[2].ToString();
            StatValue4.Text = stats[3].ToString();
            StatValue5.Text = stats[4].ToString();
            StatValue6.Text = stats[5].ToString();
            StatValue7.Text = stats[6].ToString();
            StatValue8.Text = stats[7].ToString();

            UpdateFinalStats();
        }

        // Method to update final stats
        private void UpdateFinalStats()
        {
            if (raceStatMultipliers.TryGetValue(currentRace, out var multipliers))
            {
                UpdateFinalStat(StatValue_Str, strFinalLbl, multipliers["Str"]);
                UpdateFinalStat(StatValue_Dex, dexFinalLbl, multipliers["Dex"]);
                UpdateFinalStat(StatValue_Con, conFinalLbl, multipliers["Con"]);
                UpdateFinalStat(StatValue_Int, intFinalLbl, multipliers["Int"]);
                UpdateFinalStat(StatValue_Wis, wisFinalLbl, multipliers["Wis"]);
                UpdateFinalStat(StatValue_Cha, chaFinalLbl, multipliers["Cha"]);
                UpdateFinalStat(StatValue_Agi, agiFinalLbl, multipliers["Agi"]);
            }
        }

        // Method to update a single final stat
        private void UpdateFinalStat(Control initialControl, Control finalControl, double multiplier)
        {
            if (int.TryParse(initialControl.Text, out int value))
            {
                finalControl.Text = (value * multiplier).ToString("F2");
            }
        }

        // Event handler for re-roll stats button click
        private void reRollStatsBtn_Click(object sender, EventArgs e)
        {
            GenerateStats();
        }

        // Event handler for auto distribute button click
        private void autoDistributeBtn_Click(object sender, EventArgs e)
        {
            var stats = new List<int>();
            var statValues = new[] { StatValue1.Text, StatValue2.Text, StatValue3.Text, StatValue4.Text, StatValue5.Text, StatValue6.Text, StatValue7.Text, StatValue8.Text };

            foreach (var statValue in statValues)
            {
                if (int.TryParse(statValue, out int result))
                {
                    stats.Add(result);
                }
            }

            // Ensure there are enough values to distribute
            if (stats.Count < 8)
            {
                MessageBox.Show("Can't auto distribute if values are already manually added.");
                return;
            }

            // Shuffle the stats list
            stats = stats.OrderBy(x => random.Next()).ToList();

            // Distribute the stats to the stat controls
            StatValue_Str.Text = stats[0].ToString();
            StatValue_Dex.Text = stats[1].ToString();
            StatValue_Con.Text = stats[2].ToString();
            StatValue_Int.Text = stats[3].ToString();
            StatValue_Wis.Text = stats[4].ToString();
            StatValue_Cha.Text = stats[5].ToString();
            StatValue_Agi.Text = stats[6].ToString();

            UpdateFinalStats();
        }
        // Method for the back-button in the initial Stat Selection screen
        private void BackButton_StatSelect_Click(object sender, EventArgs e)
        {
            string race = currentRace;
            this.Close();
            GenderSelection genderSelection = new GenderSelection(race);
            genderSelection.Show();

        }

        private void ConfirmButton_StatSelection_Click(object sender, EventArgs e)
        {
            string race = currentRace;
            UpdateRaceAndAgeLabels(race);

            raceLabel.Show();
            averageLifespanLabel.Show();
            minimumAgeLabel.Show();

            AgeInput.Show();
            AgeInputLabel.Show();
            acceptAgeButton.Show();

        }

        private void acceptAgeButton_Click(object sender, EventArgs e)
        {
            string race = currentRace;
            if (raceAgeData.TryGetValue(race, out var ageData))
            {
                if (int.Parse(AgeInput.Text) < (ageData.minimumAge))
                {
                    MessageBox.Show("Hahmosi on liian nuori!","Huomio!", MessageBoxButtons.OK);
                }
            }
                {

                }
            }
        }
    }

