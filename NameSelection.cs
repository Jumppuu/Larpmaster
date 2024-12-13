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
    public partial class NameSelection : Form
    {
        public NameSelection()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            oikeaNimiLbl.Visible = true;
            realNameTxtbox.Visible = true;
            okBtn2.Visible = true;
        }

        private void okBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var weaponList = new WeaponList();
            weaponList.Show();
        }
    }
}
