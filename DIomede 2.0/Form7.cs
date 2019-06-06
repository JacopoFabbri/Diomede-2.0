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
    public partial class Form7 : Form
    {
        Cliente cliente;
        String db;
        OperazionePraticheEdili op;
        Form2 formPrecente;
        public Form7(Cliente c, String dbName, Form2 frm)
        {
            formPrecente = frm;
            cliente = c;
            db = dbName;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }



        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                List<Contatto> lista = op.filtraContratto("DITTA", "" + cliente.Id);
                if (lista != null)
                {
                    dataGridView1.DataSource = lista;
                    dataGridView1.Columns[0].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }
            formPrecente.Hide();
            dataGridView1.Focus();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5(cliente, db);
            frm.Show();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrecente.Show();
        }
    }
}
