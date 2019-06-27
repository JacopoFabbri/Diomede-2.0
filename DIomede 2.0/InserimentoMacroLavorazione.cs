﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diomede2
{
    public partial class InserimentoMacroLavorazione : Form
    {
        readonly String db;
        List<TipologiaMacroLavorazione> lista;
        OperazionePraticheEdili op;
        public InserimentoMacroLavorazione(String dbName)
        {
            db = dbName;
            InitializeComponent();
        }


        private void InserimentoMacroLavorazione_Load(object sender, EventArgs e)
        {
            op  = new OperazionePraticheEdili(db);
            lista = op.CercaTipologiaMacroLavorazione();
            foreach(TipologiaMacroLavorazione t in lista)
            {
                comboBox1.Items.Add(t.Nome);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                op.InserimentoMacrolavorazione(textBox1.Text,dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToDouble(textBox2.Text), textBox3.Text,lista[comboBox1.SelectedIndex].Id, textBox4.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Errore durante l'inserimento \nripetere l'operazione");
            }
        }
    }
}