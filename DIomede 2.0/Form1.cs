using Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            open();

        }
        public void open()
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.1.135;Port = 3307;Database=Utenza;Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
            conn.Open();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Operazione op = new Operazione();
                Utente u = op.cercaUtente(textBox1.Text);
                if (u != null)
                {
                    if(u.Password.Equals(textBox2.Text))
                    {
                        Form2 frm = new Form2();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password errata riprovare!");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Utente non trovato!");
            }
        }
    }
}
