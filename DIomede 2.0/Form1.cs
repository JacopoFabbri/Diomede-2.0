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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Operazione op = new Operazione("Utenza");
                Utente u = op.cercaUtente(textBox1.Text);
                if (u != null)
                {
                    if (u.Password.Equals(textBox2.Text))
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
                        if (u.Ruolo == 1)
                        {
                            Form2 frm = new Form2();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password errata riprovare!");
                    }
                }
                textBox2.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Utente non trovato!");
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
                Utente u = op.cercaUtente(textBox1.Text);
                if (textBox2.Text != null)
                {
                    op.modificaDatiUtente(u.Id, u.Username, textBox2.Text);
                    MessageBox.Show("Inserito con successo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossibile registrare la password!");
            }
        }
    }
}
