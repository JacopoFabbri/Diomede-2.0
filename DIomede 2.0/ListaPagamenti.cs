﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class ListaPagamenti : Form
    {
        private readonly string db;
        private OperazionePraticheEdili op;

        public ListaPagamenti(string dbName)
        {
            db = dbName;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*
            InserimentoPagamento fmr = new InserimentoPagamento(db);
            fmr.Show();
            */
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }

        private void ListaPagamenti_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                if (op.CercaPagamento() != null)
                {
                    dataGridView1.DataSource = op.CercaPagamento();
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = op.CercaPagamento();
                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!","Attenzione:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdatePagamento((int) riga.Cells["ID"].Value, riga.Cells["NUMEROCOMMESSA"].Value + "",
                                (double) riga.Cells["IMPORTO"].Value, riga.Cells["NOTE"].Value + "",
                                riga.Cells["FATTURA"].Value + "", (DateTime) riga.Cells["DATAFATTURA"].Value,
                                (DateTime) riga.Cells["DATA"].Value, (int) riga.Cells["CLIENTE"].Value,
                                (int) riga.Cells["COMMESSA"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaPagamento();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
                if (MessageBox.Show(
                        "Stai per eliminare " +
                        (string) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?",
                        "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    try
                    {
                        var clienti = op.CercaPagamento((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaPagamento((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            dataGridView1.DataSource = op.CercaPagamento();
            dataGridView1.Columns[0].Visible = false;
        }

        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdatePagamento((int) riga.Cells["ID"].Value, riga.Cells["NUMEROCOMMESSA"].Value + "",
                                (double) riga.Cells["IMPORTO"].Value, riga.Cells["NOTE"].Value + "",
                                riga.Cells["FATTURA"].Value + "", (DateTime) riga.Cells["DATAFATTURA"].Value,
                                (DateTime) riga.Cells["DATA"].Value, (int) riga.Cells["CLIENTE"].Value,
                                (int) riga.Cells["COMMESSA"].Value);
                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaPagamento();
            dataGridView1.Columns[0].Visible = false;
        }

        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
                if (MessageBox.Show(
                        "Stai per eliminare " +
                        (string) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value + " .Confermi?",
                        "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    try
                    {
                        var clienti = op.CercaPagamento((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]
                            .Cells[0].Value);
                        op.CancellaPagamento((int) dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0]
                            .Value);
                        MessageBox.Show("Cliente Eliminato", "Conferma", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

            dataGridView1.DataSource = op.CercaPagamento();
            dataGridView1.Columns[0].Visible = false;
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 6)
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatoreDitte(db, (int) dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex], dataGridView1, 12);
                    v.Show();
                }
        }
    }
}