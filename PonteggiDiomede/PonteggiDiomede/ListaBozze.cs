﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaBozze : Form
    {
        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazionePraticheEdili op;
        public ListaBozze(string dbName, Dashboard frm)
        {
            formPrecente = frm;
            db = dbName;
            InitializeComponent();
        }
        private void ListaBozze_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (op.CercaBozza() != null)
                {
                    dataGridView1.DataSource = op.CercaBozza();
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[3].ReadOnly = true;
                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!");
                Application.Exit();
            }

            formPrecente.Hide();
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }
        private void ListaBozze_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrecente.Show();
        }
        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateBozza((int)riga.Cells["ID"].Value, (DateTime)riga.Cells["DATA"].Value, (double)riga.Cells["IMPORTO"].Value, (String)riga.Cells["FASEPROGETTO"].Value,
                                riga.Cells["IDENTIFICATIVOPREVENTIVO"].Value + "", (int)riga.Cells["CLIENTE"].Value,
                                (bool)riga.Cells["ACCETTAZIONE"].Value);
                            if ((bool)riga.Cells["ACCETTAZIONE"].Value)
                            {
                                var op1 = new OperazioneAmministrazione("Amministrazione");
                                var c = op.CercaClientiId((int)riga.Cells["CLIENTE"].Value);
                                var listaAmministrazione = op1.FiltraCliente("NOME", c.Nome);
                                List<ClienteAmministrazione> listaCliente = null;
                                string commessa;
                                if (listaAmministrazione.Count <= 0)
                                {
                                    op1.InserimentoCliente(c.Nome, c.Tel, c.Email, c.Iva, c.Sdi);
                                    listaCliente = op1.CercaCliente();
                                    commessa = op1.GeneraCommessa("PO", listaCliente[listaCliente.Count - 1],
                                        "PraticheEdili", false);
                                }
                                else
                                {
                                    commessa = op1.GeneraCommessa("PO", listaAmministrazione[1], "PraticheEdili",
                                        false);
                                }

                                op.InserimentoCommessa((int)riga.Cells["CLIENTE"].Value, commessa,
                                    (DateTime)riga.Cells["DATA"].Value, "", "", "", "", (int)riga.Cells["ID"].Value, new DateTime(), new DateTime(), "", new DateTime());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaBozza();
            dataGridView1.Columns[0].Visible = false;
        }
        private void AggiungiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ib = new InserimentoBozza(db, this);
            ib.Show();
        }
        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
                if (MessageBox.Show(
                        "Stai per eliminare " +
                        (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value + " .Confermi?",
                        "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    try
                    {
                        var clienti = op.CercaBozzaId((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaBozza((int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show("Bozza Eliminata", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            dataGridView1.DataSource = op.CercaBozza();
            dataGridView1.Columns[0].Visible = false;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells)
                    cella.Style.ForeColor = Color.Red;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
            }
        }
        private void FiltraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FiltroBozze(dataGridView1, db);
            f.Show();
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatoreDitte(db, (int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                    v.Show();
                }
            }
        }
    }
}