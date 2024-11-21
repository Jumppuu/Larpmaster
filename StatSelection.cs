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
            InitializeDragAndDrop();
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
    }
}
