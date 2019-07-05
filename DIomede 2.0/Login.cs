using System;
using System.IO;
using System.Windows.Forms;
using Database;

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
                var op = new Operaziones("Utenza");
                utente = op.CercaUtente(textBox1.Text);
                if (utente != null)
                {
                    if (utente.Password.Equals(textBox2.Text))
                    {
                        if (checkBox1.Checked)
                        {
                            var path = Directory.GetCurrentDirectory();
                            if (!Directory.Exists(path + "\\Login"))
                            {
                                Directory.CreateDirectory(path + "\\Login");
                                if (File.Exists(path + "\\Login\\user.txt")) File.Create(path + "\\Login\\user.txt");
                            }

                            var sw = new StreamWriter(path + "\\Login\\user.txt");
                            sw.WriteLine("user:" + textBox1.Text + "\npass:" + textBox2.Text);
                            sw.Close();
                        }

                        if (utente.Ruolo == 1 || utente.Ruolo == 4)
                        {
                            listView1.Items.Add("Occupazione");
                            listView1.Items.Add("Ponteggi");
                            listView1.Items.Add("PraticheEdili");
                            listView1.Items.Add("Carpenterie");
                            fileToolStripMenuItem.DropDownItems[0].Visible = true;
                        }
                        else if (utente.Ruolo == 3)
                        {
                            listView1.Items.Add("Ponteggi");
                            fileToolStripMenuItem.Visible = true;
                            fileToolStripMenuItem.DropDownItems[0].Visible = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password errata riprovare!", "Attenzione:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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
                button2.Visible = false;
                button3.Visible = true;
                menuStrip1.Visible = true;
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
            menuStrip1.Visible = false;
            var path = Directory.GetCurrentDirectory();
            if (Directory.Exists(path + "\\Login"))
                if (File.Exists(path + "\\Login\\user.txt"))
                {
                    var sr = new StreamReader(path + "\\Login\\user.txt");
                    while (true)
                    {
                        var s = sr.ReadLine();
                        if (s == null) break;
                        if (s.Contains("user:"))
                            textBox1.Text = s.Substring(5, s.Length - 5);
                        else if (s.Contains("pass:"))
                            textBox2.Text = s.Substring(5, s.Length - 5);
                        else
                            break;
                    }
                    sr.Close();
                }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var frm = new ModificaPassword(utente);
            frm.Show();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            var frm = new Dashboard(listView1.SelectedItems[0].Text, this);
            frm.Show();
            Hide();
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
            menuStrip1.Visible = false;
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModificaPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ModificaPassword(utente);
            frm.Show();
        }

        private void InserisciUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoUtente u = new InserimentoUtente();
            u.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            var frm = new ModificaPassword(utente);
            frm.Show();
        }
    }
}