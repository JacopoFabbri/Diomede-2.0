using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class visualizzatore : Form
    {
        readonly String s;
        public visualizzatore(String s)
        {
            this.s = s;
            InitializeComponent();
        }

        private void Visualizzatore_Load(object sender, EventArgs e)
        {
            textBox1.Text = s;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Visualizzatore_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
