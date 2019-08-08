using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amministrazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel4.Visible)
            {
                tableLayoutPanel4.Visible = false;
            }
            else
            {
                tableLayoutPanel4.Visible = true;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel4.Visible)
            {
                tableLayoutPanel4.Visible = false;
            }
            else
            {
                tableLayoutPanel4.Visible = true;
            }
        }

        private void TableLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void TableLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.
        }
    }
}
