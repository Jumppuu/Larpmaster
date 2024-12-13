using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Larpmaster
{
    public partial class WeaponList : Form
    {
        private List<string> selectedWeapons;

        public WeaponList()
        {
            InitializeComponent();
            selectedWeapons = new List<string>();

            // Ensure the event handler is assigned
            removeLastWeaponBtn.Click += RemoveLastWeaponBtn_Click;
        }

        private void WeaponButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string weapon = button.Text;
                selectedWeapons.Add(weapon);
                UpdateWeaponList();
            }
        }

        private void RemoveLastWeaponBtn_Click(object sender, EventArgs e)
        {
            if (selectedWeapons.Count > 0)
            {
                selectedWeapons.RemoveAt(selectedWeapons.Count - 1);
                UpdateWeaponList();
            }
        }

        private void UpdateWeaponList()
        {
            weaponListBox.Items.Clear();
            foreach (var weapon in selectedWeapons)
            {
                weaponListBox.Items.Add(weapon);
            }
        }

        private void exitWeaponListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new YourTasks().Show();
        }
    }
}
