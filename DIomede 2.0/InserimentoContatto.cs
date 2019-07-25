using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoContatto : Form
    {
        private readonly Cliente cliente;
        private readonly string db;
        private List<Ruolo> lista;

        DataGridView dgV;

        public InserimentoContatto(Cliente c, string dbName, DataGridView dv)
        {
            dgV = dv;
            cliente = c;
            db = dbName;
            InitializeComponent();
        }

        public void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            textBox8.Text = "" + cliente.Id;
            var op = new OperazionePraticheEdili(db);
            lista = op.CercaRuolo();
            if (lista != null)
                foreach (var r in lista)
                    comboBox1.Items.Add(r.Nome);
            else
                MessageBox.Show("Inserire almeno un ruolo!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new OperazionePraticheEdili(db);
                if (!comboBox1.Text.Equals("Ruolo"))
                {
                    op.InserimentoContatto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
                        textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text,
                        "" + lista[comboBox1.SelectedIndex].Id);
                    MessageBox.Show("Contatto Inserito", "Inserito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgV.DataSource = op.FiltraContratto("DITTA", "" + cliente.Id);
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }


        private void InserisciRuoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Ruoli(db, this);
            frm.Show();
        }
    }
}