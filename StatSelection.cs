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
            GenerateStats();
        }

        private void InitializeDragAndDrop()
        {
            // List of controls to enable drag-and-drop
            var dragDropControls = new List<Control> { StatValue1, StatValue2, StatValue3, StatValue4, StatValue5, StatValue6, StatValue7, StatValue8, StatValue_Int };

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
            if (control != null)
            {
                DoDragDrop(control.Text, DragDropEffects.Copy);
            }
        }

        private void Control_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Control_DragDrop(object sender, DragEventArgs e)
        {
            var control = sender as Control;
            if (control != null)
            {
                control.Text = (string)e.Data.GetData(DataFormats.Text);
            }
        }

        private void StatValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateStats()
        {
            var stats = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                int stat = RollStat();
                stats.Add(stat);
            }

            // Check if more than 3 values are over 100
            if (stats.Count(s => s > 100) < 3)
            {
                // Optionally re-roll all stats
                stats.Clear();
                for (int i = 0; i < 9; i++)
                {
                    int stat = RollStat();
                    stats.Add(stat);
                }
            }

            // Check if any value is over 150
            if (stats.Any(s => s > 150))
            {
                // Do not discard the lowest value
                // Optionally re-roll all stats
            }
            else
            {
                // Discard the lowest value
                stats.Remove(stats.Min());
            }

            // Display the stats
            DisplayStats(stats);
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

        private double RollNormal(double mean, double stdDev)
        {
            // Box-Muller transform
            double u1 = 1.0 - random.NextDouble(); // Uniform(0,1] random doubles
            double u2 = 1.0 - random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); // Random normal(0,1)
            return mean + stdDev * randStdNormal; // Random normal(mean,stdDev^2)
        }

        private void DisplayStats(List<int> stats)
        {
            // Assuming you have TextBox controls named StatValue1, StatValue2, etc.
            StatValue1.Text = stats[0].ToString();
            StatValue2.Text = stats[1].ToString();
            StatValue3.Text = stats[2].ToString();
            StatValue4.Text = stats[3].ToString();
            StatValue5.Text = stats[4].ToString();
            StatValue6.Text = stats[5].ToString();
            StatValue7.Text = stats[6].ToString();
            StatValue8.Text = stats[7].ToString();
        }
    }
}
