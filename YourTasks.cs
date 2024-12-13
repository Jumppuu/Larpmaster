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
    public partial class YourTasks : Form
    {
        private bool isgameMaster;

        public YourTasks()
        {
            InitializeComponent();
        }

        private void okBtn1_Click(object sender, EventArgs e)
        {
            okBtn2.Visible = true;
            muutaLbl.Visible = true;
            muutaTextBox.Visible = true;
        }



        private void okBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainMenu(isgameMaster).Show();
        }
    }
}
