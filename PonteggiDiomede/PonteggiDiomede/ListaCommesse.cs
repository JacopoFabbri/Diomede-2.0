using PonteggiDiomede;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Diomede2
{
    public partial class ListaCommesse : Form
    {
        private readonly string db;
        private readonly Dashboard formPrecente;
        private OperazionePraticheEdili op;
        private Boolean flag = false;
        public ListaCommesse(string dbName, Dashboard frm)
        {
            formPrecente = frm;
            db = dbName;
            InitializeComponent();
        }
        private void ListaCommesse_Load(object sender, EventArgs e)
        {
            try
            {
                op = new OperazionePraticheEdili(db);
                var lista = op.CercaCommessa();
                if (lista != null)
                {
                    dataGridView1.DataSource = lista;
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Cliente";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Cliente c = op.CercaClientiId((int)r.Cells[1].Value);
                        r.Cells[14].Value = c.Nome;
                    }
                    col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.Name = "Preventivo";
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        Bozza c = op.CercaBozzaId((int)r.Cells[8].Value);
                        r.Cells[15].Value = c.IdentificativoPreventivo;
                    }
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        String s = "" + r.Cells["DataOraInvio"].Value;
                        if (!((DateTime)r.Cells["DataOraInvio"].Value).ToString("yyyy/MM/dd hh:mm").Equals("0001-01-01 12:00:00") && !r.Cells["DataOraInvio"].Value.ToString().Equals("01/01/0001 00:00:00"))
                        {
                            foreach (DataGridViewCell c in r.Cells)
                            {
                                c.Style.BackColor = Color.Green;
                            }
                        }
                        else if (((DateTime)r.Cells["DATAESECUZIONE"].Value).ToString("yyyy/MM/dd").Equals(DateTime.Now.ToString("yyyy/MM/dd")))
                        {
                            foreach (DataGridViewCell c in r.Cells)
                            {
                                c.Style.BackColor = Color.Yellow;
                            }
                        }

                    }
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[14].ReadOnly = true;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[15].ReadOnly = true;
                    flag = true;
                }
            }
            catch
            {
                MessageBox.Show("Impossibile accedere a quest'area !!!","Attenzione:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            label1.Text = dataGridView1.SelectedRows.Count + "";
            formPrecente.Hide();
            dataGridView1.Focus();
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
                foreach (DataGridViewCell cella in dataGridView1.Rows[e.RowIndex].Cells) cella.Style.ForeColor = Color.Red;
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                formPrecente.Show();
                formPrecente.Dashboard_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                for (var i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    if (MessageBox.Show(
                            "Stai per eliminare " +
                            (string)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[2].Value +
                            " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        try
                        {
                            var clienti = op.CercaCommessa((int)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index]
                                .Cells[0].Value);
                            op.CancellaCommessa((int)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0]
                                .Value);
                            MessageBox.Show("Commessa Eliminata", "Conferma:", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaCommessa();
            dataGridView1.Columns[0].Visible = false;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            var frm = new InserimentoPagamento(db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
            frm.Show();
        }
        private void AggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in dataGridView1.Rows)
                if (riga.Cells[0].Value != null)
                    if (riga.Cells[0].Style.ForeColor == Color.Red)
                        try
                        {
                            op.UpdateCommessa((int)riga.Cells["Id"].Value, (int)riga.Cells["Ditta"].Value,
                                riga.Cells["NumeroCommessa"].Value + "", (DateTime)riga.Cells["Data"].Value,
                                riga.Cells["Referente"].Value + "", "" + riga.Cells["IndirizzoCantiere"].Value,
                                "" + riga.Cells["TecnicoInterno"].Value, "" + riga.Cells["Note"].Value,
                                (int)riga.Cells["Bozza"].Value, (DateTime)riga.Cells["DataEsecuzione"].Value,
                                (DateTime)riga.Cells["DataRichestaConsegna"].Value, "" + riga.Cells["Invio"].Value,
                                (DateTime)riga.Cells["DataOraInvio"].Value, "" + riga.Cells["NOTEGENERICHE"].Value);

                        }
                        catch
                        {
                            MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento", "Errore:",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            flag = false;
            dataGridView1.DataSource = op.CercaCommessa();
            dataGridView1.Columns.Remove("CLIENTE");
            dataGridView1.Columns.Remove("PREVENTIVO");
            DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "Cliente";
            dataGridView1.Columns.Add(col);
            col = new DataGridViewColumn(new DataGridViewTextBoxCell());
            col.Name = "Preventivo";
            dataGridView1.Columns.Add(col);
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Cliente c = op.CercaClientiId((int)r.Cells[1].Value);
                r.Cells[14].Value = c.Nome;
            }
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Bozza c = op.CercaBozzaId((int)r.Cells[8].Value);
                r.Cells[15].Value = c.IdentificativoPreventivo;
            }
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (!((DateTime)r.Cells["DataOraInvio"].Value).ToString("yyyy/MM/dd hh:mm").Equals("0001-01-01 12:00:00") && !r.Cells["DataOraInvio"].Value.ToString().Equals("01/01/0001 00:00:00"))
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        c.Style.BackColor = Color.Green;
                    }
                }
                else if (((DateTime)r.Cells["DATAESECUZIONE"].Value).ToString("yyyy/MM/dd").Equals(DateTime.Now.ToString("yyyy/MM/dd")))
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        c.Style.BackColor = Color.Yellow;
                    }
                }

            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[14].ReadOnly = true;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[15].ReadOnly = true;
            flag = true;
        }
        private void EliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                for (var i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    if (MessageBox.Show(
                            "Stai per eliminare " +
                            (string)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[2].Value +
                            " .Confermi?", "Conferma Eliminazione richiesta:", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                        try
                        {
                            var clienti = op.CercaCommessa((int)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index]
                                .Cells[0].Value);
                            op.CancellaCommessa((int)dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0]
                                .Value);
                            MessageBox.Show("Commessa Eliminata", "Conferma:", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Impossibile cancellare la riga selezionata", "Errore:",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

            dataGridView1.DataSource = op.CercaCommessa();
            dataGridView1.Columns[0].Visible = false;
        }
        private void PagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new InserimentoPagamento(db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
            frm.Show();
        }
        private void SelezionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = new Recap(db, (int)dataGridView1.SelectedRows[0].Cells[0].Value);
            r.Show();
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 14)
                if (e.RowIndex != -1)
                {
                    var v = new VisualizzatoreDitte(db, (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[1]);
                    v.Show();
                }
        }
        private void MacroLavorazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FiltroCommesse(dataGridView1, db);
            f.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            String path = Directory.GetCurrentDirectory() + "\\Modelli\\ALL-PROJECTS-Gestione Ponteggi.xlsm";
            Excel.Application objApp;
            objApp = new Excel.Application();
            try
            {
                Excel.Workbook wb = objApp.Workbooks.Open(path);
                Excel.Worksheet ws = wb.Sheets["Foglio1"];
                ws.Activate();
                int x = 3;
                List<Commessa> listaCommessa = op.CercaCommessa();
                List<Lavorazioni> listaLavorazioni;
                foreach (Commessa c in listaCommessa)
                {
                    listaLavorazioni = op.FiltraLavorazioni("COMMESSA", "" +c.Id);

                    ws.Cells[x, 1].Value = c.NumeroCommessa;
                    ws.Cells[x, 2].Value = c.NumeroCommessa;
                    ws.Cells[x, 3].Value = c.Data;
                    ws.Cells[x, 4].Value = "" + op.CercaClientiId(c.Ditta).Nome;
                    ws.Cells[x, 5].Value = c.IndirizzoCantiere;
                    ws.Cells[x, 6].Value = op.CercaBozzaId(c.Bozza).FaseProgetto;
                    ws.Cells[x, 7].Value = "Ponteggi";
                    foreach(Lavorazioni l in listaLavorazioni)
                    {
                        if (l.Nome.Equals("Sopraluogo"))
                        {
                            ws.Cells[x, 8].Value = l.assegnato;
                            ws.Cells[x, 9].Value = l.data.ToString("dd/MM/yyyy");
                        }else if (l.Nome.Equals("Disegno"))
                        {
                            ws.Cells[x, 10].Value = l.assegnato;
                        }else if (l.Nome.Equals("Disegno e Relazione"))
                        {
                            ws.Cells[x, 11].Value = l.assegnato;
                        }
                    }
                    ws.Cells[x, 12].Value = c.DataEsecuzione.ToString("dd/MM/yyyy");
                    ws.Cells[x, 13].Value = c.DataRichestaConsegna.ToString("dd/MM/yyyy");
                    ws.Cells[x, 14].Value = c.Note;
                    ws.Cells[x, 15].Value = c.Invio;
                    ws.Cells[x, 16].Value = c.DataOraInvio.ToString("dd/MM/yyyy");
                    ws.Cells[x, 17].Value = c.DataOraInvio.ToString("hh:mm");
                    ws.Cells[x, 18].Value = c.NoteGeneriche;
                    ws.Cells[x, 19].Value = op.CercaBozzaId(c.Bozza).Importo;
                    if (!c.DataOraInvio.ToString("yyyy/MM/dd hh:mm").Equals("0001-01-01 12:00:00") && !c.DataOraInvio.ToString("yyyy/MM/dd hh:mm").Equals("01/01/0001 00:00:00"))
                    {
                        ws.Cells[x, 22].Value = "v";
                    }
                    else if (c.DataEsecuzione.ToString("yyyy/MM/dd").Equals(DateTime.Now.ToString("yyyy/MM/dd")))
                    {
                        ws.Cells[x, 22].Value = "g";
                    }

                        x++;
                }
                wb.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\result.xlsm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento\n" + ex.ToString(), "Errore:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
            finally
            {
                objApp.Quit();
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            label1.Text = dataGridView1.SelectedRows.Count + "";

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.Series["Importo"].Points.Clear();
            //openFileDialog1.ShowDialog();                
            List<Commessa> listaCommessa = op.CercaCommessa();
            foreach(Commessa c in listaCommessa)
            {
                double x = op.CercaBozzaId(c.Bozza).Importo;
                chart1.Series["Importo"].Points.AddXY(c.Data,x);
            }
        }

        private void Chart1_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
        }
    }
}