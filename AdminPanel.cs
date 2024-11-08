using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larpmaster
{
    public partial class Pelinjohto : Form
    {
        private OpenFileDialog LoadCharFileDialog; // Needed to make loadcharacter file dialog work

        public Pelinjohto(bool isGameMaster)
        {
            InitializeComponent();
            LoadCharFileDialog = new OpenFileDialog();
            LoadCharFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Filter to show only text files
            // Additional initialization code here
            // Subscribe to the FormClosed event
            this.FormClosed += new FormClosedEventHandler(Pelinjohto_FormClosed);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // Load event handler code here
        }

        private void playerModeSelectionBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide admin panel
            mainMenu mainMenuForm = new mainMenu(true); // Back to player mode
            mainMenuForm.Show(); // Show the main menu
        }

        private void loadCharBtn_Click(object sender, EventArgs e)
        {
            if (LoadCharFileDialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    string fileContent = File.ReadAllText(LoadCharFileDialog.FileName, Encoding.GetEncoding("ISO-8859-1"));
                    characterDetailsBox.Text = fileContent; // Display file content in RichTextBox
                    characterDetailsBox.Visible = true; // Make the RichTextBox visible
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}");
                }
            }
        }
        // Handle the FormClosed event to exit the application
        private void Pelinjohto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Closes the application when the form is closed
        }
    }
}
    

