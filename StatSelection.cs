using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Larpmaster
{
    public partial class StatSelection : Form
    {
        private Random random = new Random();

        public StatSelection()
        {
            InitializeComponent();
            InitializeDragAndDrop();
            this.Load += (sender, e) => GenerateStats();
        }


        private void InitializeDragAndDrop()
        {
            // List of controls to enable drag-and-drop
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

                        // Empty target control
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

                }
            }
        }

        private void GenerateStats()
        {
            var stats = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                int stat = RollStat();
                stats.Add(stat);
            }

            // Display the stats
            DisplayStats(stats);

            // Check conditions and prompt for re-roll
            BeginInvoke(new Action(() => CheckAndPromptForReroll(stats)));
        }

        private void CheckAndPromptForReroll(List<int> stats)
        {
            // Check if more than 3 values are over 100
            if (stats.Count(s => s > 100) < 3)
            {
                // Optionally re-roll all stats
                if (MessageBox.Show("3 Arvoa on alle 100 haluatko heittää uudestaan vai olla nössö?", "Re-roll Stats", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ReRollStats();
                    return;
                }
            }

            // Check if any value is over 150
            if (stats.Any(s => s > 150))
            {
                // Optionally re-roll all stats
                if (MessageBox.Show("Yksi tai useampi arvo on yli 150 haluatko heittää uudestaan?", "Re-roll Stats", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ReRollStats();
                }
            }
        }

        private void ReRollStats()
        {
            var stats = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                int stat = RollStat();
                stats.Add(stat);
            }

            // Display the stats
            DisplayStats(stats);

            // Check conditions and prompt for re-roll
            BeginInvoke(new Action(() => CheckAndPromptForReroll(stats)));
        }

        private int RollStat()
        {
            double total = 0;

            // Roll 10 times d20-1 using normal distribution
            for (int i = 0; i < 10; i++)
            {
                total += RollNormal(10.5, 5.8) - 1; // Mean 10.5, StdDev 5.8
            }

            // Roll once d10 using normal distribution
            double d10 = RollNormal(5.5, 2.9); // Mean 5.5, StdDev 2.9
            total += d10;

            // Handle special rules for d10
            while (d10 >= 9.5) // Approximate 10
            {
                d10 = RollNormal(5.5, 2.9);
                total += d10;
            }

            while (d10 <= 1.5) // Approximate 1
            {
                d10 = RollNormal(5.5, 2.9);
                total -= d10;
                if (total < 0) total = 0;
            }

            return (int)Math.Round(total);
        }

        private double RollNormal(double mean, double stdDev) // Box-Muller transform is used to generate normal distribution
        {
            double u1 = random.NextDouble(); // Uniform(0,1) random doubles
            double u2 = random.NextDouble(); // uniform(0,1) random doubles
            // Protection against u1 being zero
            if (u1 < 1e-7) u1 = 1e-7; // Prevent taking log of zero - 1e-7 is a safety threshold to avoid numerical instability in Box-Muller transform
            // Box-Muller transform: Converts uniform random numbers (u1, u2) into standard normal distribution
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            return mean + stdDev * randStdNormal;
        }

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
        }

        private void reRollStatsBtn_Click(object sender, EventArgs e)
        {
            GenerateStats();
        }

        private void autoDistributeBtn_Click(object sender, EventArgs e)
        {
            var stats = new List<int>
            {
                int.Parse(StatValue1.Text),
                int.Parse(StatValue2.Text),
                int.Parse(StatValue3.Text),
                int.Parse(StatValue4.Text),
                int.Parse(StatValue5.Text),
                int.Parse(StatValue6.Text),
                int.Parse(StatValue7.Text),
                int.Parse(StatValue8.Text)
            };

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
        }
    }
}
