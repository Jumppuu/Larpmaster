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
    public partial class StatSelection : Form
    {
        public StatSelection()
        {
            InitializeComponent();
        }

        
        

        private void StatValue1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(StatValue1.Text, DragDropEffects.Copy);
        }

        private void StatValue1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void StatValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatValue_Int_DragDrop(object sender, DragEventArgs e)
        {
            StatValue_Int.Text = (string)e.Data.GetData(DataFormats.Text);
        }
    }
}
