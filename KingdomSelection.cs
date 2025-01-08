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
    public partial class KingdomSelection : Form
    {
        public KingdomSelection()
        {
            InitializeComponent();
        }

        private void vuoriniittyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionManager.Instance.Selections.Kingdom = "Vuoriniitty";
            NameSelection nameselection = new NameSelection();
            nameselection.Show();
        }

        private void vardakovBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionManager.Instance.Selections.Kingdom = "Vardakov";
            NameSelection nameselection = new NameSelection();
            nameselection.Show();
        }

        private void metsäläisetBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionManager.Instance.Selections.Kingdom = "Metsäläiset";
            NameSelection nameselection = new NameSelection();
            nameselection.Show();
        }

        private void noKingdomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionManager.Instance.Selections.Kingdom = "Ei kuulu mihinkään";
            NameSelection nameselection = new NameSelection();
            nameselection.Show();
        }
    }
}
