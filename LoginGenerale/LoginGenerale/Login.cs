using System;
using System.IO;
using System.Windows.Forms;
using Database;
using System.Net;
using System.Text;
using System.Collections.Generic;

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
            var op = new Operaziones("Utenza");
            List<Update> u = op.CercaUpdate();
            if (u.Count != 0)
            {
                if (!u[u.Count - 1].Versione.Equals(Application.ProductVersion))
                {
                    MessageBox.Show("Aggiornamento Disponibile Installare la nuova versione");
                }
            }
            listView1.Clear();
            try
            {
                op = new Operaziones("Utenza");
                utente = op.CercaUtente(textBox1.Text);
                if (utente != null)
                {
                    if (utente.Password.Equals(textBox2.Text))
                    {
                        if (checkBox1.Checked)
                        {
                            var path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                            if (!Directory.Exists( path + "\\Login"))
                            {
                                Directory.CreateDirectory(path + "\\Login");
                                if (File.Exists(path + "\\Login\\user.paco")) File.Create(path + "\\Login\\user.paco");
                            }

                            var sw = new StreamWriter(path + "\\Login\\user.paco");
                            sw.WriteLine("user:" + textBox1.Text + "\npass:" + textBox2.Text);
                            sw.Close();
                        }

                        if (utente.Ruolo == 1 || utente.Ruolo == 4 || utente.Ruolo == 6)
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
                        else if (utente.Ruolo == 5)
                        {
                            listView1.Items.Add("PraticheEdili");
                            fileToolStripMenuItem.Visible = true;
                            fileToolStripMenuItem.DropDownItems[0].Visible = false;
                        }
                        listView1.Visible = true;
                        label1.Visible = false;
                        label2.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        checkBox1.Visible = false;
                        button1.Visible = false;
                        button3.Visible = true;
                        menuStrip1.Visible = true;
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
                    MessageBox.Show("Utente non trovato!","Errore:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
            catch 
            {
                MessageBox.Show("Errore non specificato riprovare!");
                textBox2.Clear();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            menuStrip1.Visible = false;
            var path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            if (Directory.Exists(path + "\\Login"))
                if (File.Exists(path + "\\Login\\user.paco"))
                {
                    var sr = new StreamReader(path + "\\Login\\user.paco");
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
            var path = Directory.GetCurrentDirectory();
            if (listView1.SelectedItems[0].Text.Equals("Ponteggi"))
            {
                try
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = path + "/PonteggiDiomede.exe";
                    proc.Start();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if(listView1.SelectedItems[0].Text.Equals("PraticheEdili"))
            {
                try
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = path + "/Diomede2.exe";
                    proc.Start();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (listView1.SelectedItems[0].Text.Equals("Carpenterie"))
            {
                try
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = path + "/CarpenterieMetallicheDiomede.exe";
                    proc.Start();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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
            button3.Visible = false;
            menuStrip1.Visible = false;
            textBox2.Clear();
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
        private void InserisciUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var op = new Operaziones("Utenza");
            op.inserisciUpdate(Application.ProductVersion);
        }
        private void ListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var path = Directory.GetCurrentDirectory();
                if (listView1.SelectedItems[0].Text.Equals("Ponteggi"))
                {
                    try
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.EnableRaisingEvents = false;
                        proc.StartInfo.FileName = path + "/PonteggiDiomede.exe";
                        proc.Start();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (listView1.SelectedItems[0].Text.Equals("PraticheEdili"))
                {
                    try
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.EnableRaisingEvents = false;
                        proc.StartInfo.FileName = path + "/Diomede2.exe";
                        proc.Start();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (listView1.SelectedItems[0].Text.Equals("Carpenterie"))
                {
                    try
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.EnableRaisingEvents = false;
                        proc.StartInfo.FileName = path + "/CarpenterieMetallicheDiomede.exe";
                        proc.Start();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}