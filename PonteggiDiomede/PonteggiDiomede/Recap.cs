﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class Recap : Form
    {
        String db;
        int idCommessa;
        OperazionePraticheEdili op;
        Commessa commessa;
        public Recap(String dbName, int id)
        {
            db = dbName;
            idCommessa = id;
            InitializeComponent();
        }
        private void Recap_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                commessa = op.CercaCommessa(idCommessa);
                textBox1.Text = "" + commessa.NumeroCommessa;
                textBox2.Text = op.CercaClientiId(commessa.Ditta).Nome;
                textBox5.Text = "" + op.CercaBozzaId(commessa.Bozza).Importo;
                List<Lavorazioni> listaLavorazione = new List<Lavorazioni>();
                dataGridView1.DataSource = listaLavorazione;
                textBox6.Text = commessa.Note;
                dataGridView1.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("ciao");
            }

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
            {
                cella.Style.ForeColor = Color.Red;
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                op.UpdateCommessa(commessa.Id, textBox6.Text);
                op.UpdateBozza(commessa.Bozza, Convert.ToDouble(textBox5.Text));
                Cliente c = op.CercaClientiId(commessa.Ditta);
                op.UpdateCliente(c.Id, textBox2.Text, c.Indirizzo, c.Cap, c.Citta, c.Pec, c.Email, c.Iva, c.Tel, c.Sdi);
            }
            catch
            {
                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InserimentoPagamento p = new InserimentoPagamento(db, commessa.Id);
            p.Show();
        }
    }
}
