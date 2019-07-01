using Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class Login : Form
    {
        private Utente utente;
        public Login()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            try
            {
                Operaziones op = new Operaziones("Utenza");
                utente = op.CercaUtente(textBox1.Text);
                if (utente != null)
                {
                    if (utente.Password.Equals(textBox2.Text))
                    {
                        if (checkBox1.Checked)
                        {
                            String path = Directory.GetCurrentDirectory();
                            if (!Directory.Exists(path + "\\Login"))
                            {
                                Directory.CreateDirectory(path + "\\Login");
                                if (File.Exists(path + "\\Login\\user.txt"))
                                {
                                    File.Create(path + "\\Login\\user.txt");

                                }
                            }
                            StreamWriter sw = new StreamWriter(path + "\\Login\\user.txt");
                            sw.WriteLine("user:" + textBox1.Text + "\npass:" + textBox2.Text);
                            sw.Close();
                        }
                        if (utente.Ruolo == 1 || utente.Ruolo == 4)
                        {
                            listView1.Items.Add("Occupazione");
                            listView1.Items.Add("Ponteggi");
                            listView1.Items.Add("PraticheEdili");
                            listView1.Items.Add("Carpenterie");
                        
                        }else if(utente.Ruolo == 3)
                        {
                            listView1.Items.Add("Ponteggi");
                        }
                        button2.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Password errata riprovare!","Attenzione:",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Utente non trovato!");
                }
                listView1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                checkBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Errore non specificato riprovare!");
                textBox2.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            String path = Directory.GetCurrentDirectory();
            if (Directory.Exists(path + "\\Login"))
            {
                if (File.Exists(path + "\\Login\\user.txt"))
                {
                    StreamReader sr = new StreamReader(path + "\\Login\\user.txt");
                    while (true)
                    {
                        String s = sr.ReadLine();
                        if (s == null)
                        {
                            break;
                        }
                        if (s.Contains("user:"))
                        {
                            textBox1.Text = s.Substring(5, s.Length - 5);
                        }
                        else if (s.Contains("pass:"))
                        {
                            textBox2.Text = s.Substring(5, s.Length - 5);
                        }
                        else
                        {
                            break;
                        }
                    }
                    sr.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ModificaPassword frm = new ModificaPassword(utente);
            frm.Show();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(listView1.SelectedItems[0].Text, this);
            frm.Show();
            this.Hide();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Secret sec = new Secret();
            sec.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            checkBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
        }


    }
}
