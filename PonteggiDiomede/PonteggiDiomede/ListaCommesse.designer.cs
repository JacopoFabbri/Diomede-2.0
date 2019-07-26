namespace Diomede2
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
            this.macroLavorazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selezionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 399);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operazioniToolStripMenuItem,
            this.macroLavorazioniToolStripMenuItem,
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
            this.pagamentoToolStripMenuItem});
            this.operazioniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operazioniToolStripMenuItem.Image = global::PonteggiDiomede.Properties.Resources.icons8_servizi_48;
            this.operazioniToolStripMenuItem.Name = "operazioniToolStripMenuItem";
            this.operazioniToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.operazioniToolStripMenuItem.Text = "Edit";
            // 
            // aggiornaToolStripMenuItem
            // 
            this.aggiornaToolStripMenuItem.Image = global::PonteggiDiomede.Properties.Resources.icons8_sincronizzare_48;
            this.aggiornaToolStripMenuItem.Name = "aggiornaToolStripMenuItem";
            this.aggiornaToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.aggiornaToolStripMenuItem.Text = "Aggiorna";
            this.aggiornaToolStripMenuItem.Click += new System.EventHandler(this.AggiornaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Image = global::PonteggiDiomede.Properties.Resources.icons8_eliminare_48;
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.EliminaToolStripMenuItem_Click);
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.Image = global::PonteggiDiomede.Properties.Resources.icons8_sacco_dei_soldi_16;
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.pagamentoToolStripMenuItem.Text = "Pagamento";
            this.pagamentoToolStripMenuItem.Click += new System.EventHandler(this.PagamentoToolStripMenuItem_Click);
            // 
            // macroLavorazioniToolStripMenuItem
            // 
            this.macroLavorazioniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroLavorazioniToolStripMenuItem.Image = global::PonteggiDiomede.Properties.Resources.icons8_filtro_riempito_48;
            this.macroLavorazioniToolStripMenuItem.Name = "macroLavorazioniToolStripMenuItem";
            this.macroLavorazioniToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.macroLavorazioniToolStripMenuItem.Text = "Filtro";
            this.macroLavorazioniToolStripMenuItem.Click += new System.EventHandler(this.MacroLavorazioniToolStripMenuItem_Click);
            // 
            // selezionaToolStripMenuItem
            // 
            this.selezionaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selezionaToolStripMenuItem.Image = global::PonteggiDiomede.Properties.Resources.icons8_casella_di_controllo_selezionata_48;
            this.selezionaToolStripMenuItem.Name = "selezionaToolStripMenuItem";
            this.selezionaToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.selezionaToolStripMenuItem.Text = "Seleziona";
            this.selezionaToolStripMenuItem.Click += new System.EventHandler(this.SelezionaToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(593, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 39);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem macroLavorazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selezionaToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}