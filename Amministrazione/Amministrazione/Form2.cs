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
    public partial class Form2 : Form

    {
        private readonly string settore;
        public Form2()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = false;

            if (tableLayoutPanel2.Visible)
            {
                tableLayoutPanel2.Visible = false;
            }
            else
            {
                tableLayoutPanel2.Visible = true;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel4.Visible = false;

            if (tableLayoutPanel3.Visible)
            {
                tableLayoutPanel3.Visible = false;
            }
            else
            {
                tableLayoutPanel3.Visible = true;

            }
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel2.Visible = false;

            if (tableLayoutPanel4.Visible)
            {
                tableLayoutPanel4.Visible = false;
            }
            else
            {
                tableLayoutPanel4.Visible = true;

            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            listView3.Visible = true;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            listView3.Visible = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                InserimentoCliente cliente = new InserimentoCliente(settore);
                cliente.Show();
                tableLayoutPanel2.Visible = false;
            }
            catch
            {
                MessageBox.Show("Errore imprevisto contattare l'assistenza","Attenzione",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}

