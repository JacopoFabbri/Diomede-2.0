﻿namespace Diomede2
{
    partial class ListaCommesse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCommesse));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiornaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserimentoCommessaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selezionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 444);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operazioniToolStripMenuItem,
            this.selezionaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operazioniToolStripMenuItem
            // 
            this.operazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiornaToolStripMenuItem,
            this.eliminaToolStripMenuItem,
            this.pagamentoToolStripMenuItem,
            this.inserimentoCommessaToolStripMenuItem});
            this.operazioniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operazioniToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_servizi_48;
            this.operazioniToolStripMenuItem.Name = "operazioniToolStripMenuItem";
            this.operazioniToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.operazioniToolStripMenuItem.Text = "Edit";
            // 
            // aggiornaToolStripMenuItem
            // 
            this.aggiornaToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_sincronizzare_48;
            this.aggiornaToolStripMenuItem.Name = "aggiornaToolStripMenuItem";
            this.aggiornaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.aggiornaToolStripMenuItem.Text = "Aggiorna";
            this.aggiornaToolStripMenuItem.Click += new System.EventHandler(this.AggiornaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_cestino_48;
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.EliminaToolStripMenuItem_Click);
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_sacco_dei_soldi_16;
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.pagamentoToolStripMenuItem.Text = "Pagamento";
            this.pagamentoToolStripMenuItem.Click += new System.EventHandler(this.PagamentoToolStripMenuItem_Click);
            // 
            // inserimentoCommessaToolStripMenuItem
            // 
            this.inserimentoCommessaToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_più_48;
            this.inserimentoCommessaToolStripMenuItem.Name = "inserimentoCommessaToolStripMenuItem";
            this.inserimentoCommessaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.inserimentoCommessaToolStripMenuItem.Text = "Inserimento Commessa";
            this.inserimentoCommessaToolStripMenuItem.Click += new System.EventHandler(this.InserimentoCommessaToolStripMenuItem_Click);
            // 
            // selezionaToolStripMenuItem
            // 
            this.selezionaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selezionaToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_casella_di_controllo_selezionata_48;
            this.selezionaToolStripMenuItem.Name = "selezionaToolStripMenuItem";
            this.selezionaToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.selezionaToolStripMenuItem.Text = "Seleziona";
            this.selezionaToolStripMenuItem.Click += new System.EventHandler(this.SelezionaToolStripMenuItem_Click);
            // 
            // ListaCommesse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaCommesse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Commesse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.ListaCommesse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiornaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selezionaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserimentoCommessaToolStripMenuItem;
    }
}