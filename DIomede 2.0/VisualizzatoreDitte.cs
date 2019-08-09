using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class VisualizzatoreDitte : Form
    {
        private readonly DataGridViewCell data;
        private readonly string db;
        private readonly int id;
        private List<Cliente> lista;
        private OperazionePraticheEdili op;
        private DataGridView dataGridView1;
        private int idCliente;

        public VisualizzatoreDitte(string dbName, int id, DataGridViewCell dc, DataGridView d, int cliente)
        {
            idCliente = cliente;
            dataGridView1 = d;
            data = dc;
            this.id = id;
            db = dbName;
            InitializeComponent();
        }

        private void VisualizzatoreDitte_Load(object sender, EventArgs e)
        {
            op = new OperazionePraticheEdili(db);
            lista = op.CercaClienti();
            foreach (var c in lista) comboBox1.Items.Add(c.Nome);
            comboBox1.SelectedItem = op.CercaClientiId(id).Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                data.Value = lista[comboBox1.SelectedIndex].Id;
                foreach (DataGridViewRow riga in dataGridView1.Rows)
                    if (riga.Cells[0].Value != null)
                        if (riga.Cells[0].Style.ForeColor == Color.Red)
                            try
                            {
                                op.UpdateContatto((int)riga.Cells["ID"].Value, riga.Cells["NOME"].Value + "",
                                    riga.Cells["INDIRIZZO"].Value + "", riga.Cells["CAP"].Value + "",
                                    riga.Cells["CITTA"].Value + "", riga.Cells["PEC"].Value + "",
                                    riga.Cells["EMAIL"].Value + "", riga.Cells["Iva"].Value + "",
                                    (int)riga.Cells["DITTA"].Value, riga.Cells["CELLULARE"].Value + "",
                                    riga.Cells["TEL"].Value + "", riga.Cells["RUOLO"].Value + "");
                            }
                            catch
                            {
                                MessageBox.Show("Errore nell'inserimento di dati controllare l'inserimento.", "Errore:",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                dataGridView1.DataSource = op.FiltraContratto("DITTA", "" + idCliente);
                DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                col.Name = "CLIENTE";
                dataGridView1.Columns.Add(col);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    Cliente c = op.CercaClientiId((int)r.Cells[8].Value);
                    r.Cells[12].Value = c.Nome;
                }
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].ReadOnly = true;
                Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Visualizzatore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}