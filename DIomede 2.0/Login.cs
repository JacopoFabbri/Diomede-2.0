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
                Operazione op = new Operazione("Utenza");
                utente = op.cercaUtente(textBox1.Text);
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
                            listView1.Items.Add("CarpenterieMetalliche");
                        
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
            try
            {
                Operazione op = new Operazione("Utenza");
                utente = op.cercaUtente(utente.Username);
                if (textBox2.Text != null)
                {
                    op.modificaDatiUtente(utente.Id, utente.Username, textBox2.Text);
                    MessageBox.Show("Inserito con successo","Login:",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossibile registrare la password!","Attenzione:");
            }
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(listView1.SelectedItems[0].Text, utente, this);
            frm.Show();
            this.Hide();

        }

    }
}
