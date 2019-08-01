namespace Diomede2
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bozzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView3 = new System.Windows.Forms.ListView();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bozzaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciBozzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaBozzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macroLavorazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMacroLavorazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Location = new System.Drawing.Point(8, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(131, 391);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView2.Location = new System.Drawing.Point(145, 30);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(131, 391);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.bozzaToolStripMenuItem,
            this.gestioneCommesseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(806, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bozzaToolStripMenuItem
            // 
            this.bozzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bozzaToolStripMenuItem1});
            this.bozzaToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_modifica_file_48;
            this.bozzaToolStripMenuItem.Name = "bozzaToolStripMenuItem";
            this.bozzaToolStripMenuItem.Size = new System.Drawing.Size(155, 25);
            this.bozzaToolStripMenuItem.Text = "Gestione Preventivi";
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView3.BackColor = System.Drawing.SystemColors.Window;
            this.listView3.BackgroundImageTiled = true;
            this.listView3.Location = new System.Drawing.Point(282, 30);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(131, 391);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            this.listView3.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_azienda_64;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 25);
            this.toolStripMenuItem1.Text = "Gestione Clienti";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientiToolStripMenuItem,
            this.aggiungiClienteToolStripMenuItem,
            this.mostraListaClientiToolStripMenuItem,
            this.nascondiListaClientiToolStripMenuItem});
            this.toolStripMenuItem2.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_aggiungere_il_contatto_alla_società_48;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem2.Text = "Ditta";
            // 
            // listaClientiToolStripMenuItem
            // 
            this.listaClientiToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaClientiToolStripMenuItem.Name = "listaClientiToolStripMenuItem";
            this.listaClientiToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listaClientiToolStripMenuItem.Text = "Lista Clienti";
            this.listaClientiToolStripMenuItem.Click += new System.EventHandler(this.ListaClientiToolStripMenuItem_Click);
            // 
            // aggiungiClienteToolStripMenuItem
            // 
            this.aggiungiClienteToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_modifica_utente_uomo_16;
            this.aggiungiClienteToolStripMenuItem.Name = "aggiungiClienteToolStripMenuItem";
            this.aggiungiClienteToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aggiungiClienteToolStripMenuItem.Text = "Aggiungi Cliente";
            this.aggiungiClienteToolStripMenuItem.Click += new System.EventHandler(this.AggiungiClienteToolStripMenuItem_Click);
            // 
            // mostraListaClientiToolStripMenuItem
            // 
            this.mostraListaClientiToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_apri_libro_64;
            this.mostraListaClientiToolStripMenuItem.Name = "mostraListaClientiToolStripMenuItem";
            this.mostraListaClientiToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.mostraListaClientiToolStripMenuItem.Text = "Mostra Lista Clienti";
            this.mostraListaClientiToolStripMenuItem.Click += new System.EventHandler(this.MostraListaClientiToolStripMenuItem_Click);
            // 
            // nascondiListaClientiToolStripMenuItem
            // 
            this.nascondiListaClientiToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_rimuovi_immagine_48;
            this.nascondiListaClientiToolStripMenuItem.Name = "nascondiListaClientiToolStripMenuItem";
            this.nascondiListaClientiToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.nascondiListaClientiToolStripMenuItem.Text = "Nascondi Lista Clienti";
            this.nascondiListaClientiToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaClientiToolStripMenuItem_Click);
            // 
            // bozzaToolStripMenuItem1
            // 
            this.bozzaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaBozzeToolStripMenuItem,
            this.inserisciBozzaToolStripMenuItem,
            this.mostraListaBozzeToolStripMenuItem,
            this.nascondiListaBozzeToolStripMenuItem});
            this.bozzaToolStripMenuItem1.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_nessuna_modifica_48;
            this.bozzaToolStripMenuItem1.Name = "bozzaToolStripMenuItem1";
            this.bozzaToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.bozzaToolStripMenuItem1.Text = "Preventivo";
            // 
            // listaBozzeToolStripMenuItem
            // 
            this.listaBozzeToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaBozzeToolStripMenuItem.Name = "listaBozzeToolStripMenuItem";
            this.listaBozzeToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.listaBozzeToolStripMenuItem.Text = "Lista Preventivi";
            this.listaBozzeToolStripMenuItem.Click += new System.EventHandler(this.ListaBozzeToolStripMenuItem_Click);
            // 
            // inserisciBozzaToolStripMenuItem
            // 
            this.inserisciBozzaToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_inserisci_tabella_48;
            this.inserisciBozzaToolStripMenuItem.Name = "inserisciBozzaToolStripMenuItem";
            this.inserisciBozzaToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.inserisciBozzaToolStripMenuItem.Text = "Inserisci Preventivo";
            this.inserisciBozzaToolStripMenuItem.Click += new System.EventHandler(this.InserisciBozzaToolStripMenuItem_Click);
            // 
            // mostraListaBozzeToolStripMenuItem
            // 
            this.mostraListaBozzeToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_apri_libro_64;
            this.mostraListaBozzeToolStripMenuItem.Name = "mostraListaBozzeToolStripMenuItem";
            this.mostraListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.mostraListaBozzeToolStripMenuItem.Text = "Mostra lista Preventivi";
            this.mostraListaBozzeToolStripMenuItem.Click += new System.EventHandler(this.VisualizzaListaBozzeToolStripMenuItem_Click);
            // 
            // nascondiListaBozzeToolStripMenuItem
            // 
            this.nascondiListaBozzeToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_rimuovi_immagine_48;
            this.nascondiListaBozzeToolStripMenuItem.Name = "nascondiListaBozzeToolStripMenuItem";
            this.nascondiListaBozzeToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.nascondiListaBozzeToolStripMenuItem.Text = "Nascondi lista Preventivi";
            this.nascondiListaBozzeToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaBozzeToolStripMenuItem_Click);
            // 
            // gestioneCommesseToolStripMenuItem
            // 
            this.gestioneCommesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commesseToolStripMenuItem,
            this.macroLavorazioniToolStripMenuItem1});
            this.gestioneCommesseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestioneCommesseToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_quaderno_48;
            this.gestioneCommesseToolStripMenuItem.Name = "gestioneCommesseToolStripMenuItem";
            this.gestioneCommesseToolStripMenuItem.Size = new System.Drawing.Size(162, 25);
            this.gestioneCommesseToolStripMenuItem.Text = "Gestione Commesse";
            // 
            // commesseToolStripMenuItem
            // 
            this.commesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCommesseToolStripMenuItem,
            this.mostraListaCommesseToolStripMenuItem,
            this.nascondiListaCommesseToolStripMenuItem});
            this.commesseToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_web_48;
            this.commesseToolStripMenuItem.Name = "commesseToolStripMenuItem";
            this.commesseToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.commesseToolStripMenuItem.Text = "Commesse";
            // 
            // listaCommesseToolStripMenuItem
            // 
            this.listaCommesseToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_lista_di_cose_da_fare_100;
            this.listaCommesseToolStripMenuItem.Name = "listaCommesseToolStripMenuItem";
            this.listaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.listaCommesseToolStripMenuItem.Text = "Lista Commesse";
            this.listaCommesseToolStripMenuItem.Click += new System.EventHandler(this.ListaCommesseToolStripMenuItem_Click);
            // 
            // mostraListaCommesseToolStripMenuItem
            // 
            this.mostraListaCommesseToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_apri_libro_64;
            this.mostraListaCommesseToolStripMenuItem.Name = "mostraListaCommesseToolStripMenuItem";
            this.mostraListaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.mostraListaCommesseToolStripMenuItem.Text = "Mostra Lista Commesse";
            this.mostraListaCommesseToolStripMenuItem.Click += new System.EventHandler(this.MostraListaCommesseToolStripMenuItem_Click);
            // 
            // nascondiListaCommesseToolStripMenuItem
            // 
            this.nascondiListaCommesseToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_rimuovi_immagine_48;
            this.nascondiListaCommesseToolStripMenuItem.Name = "nascondiListaCommesseToolStripMenuItem";
            this.nascondiListaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.nascondiListaCommesseToolStripMenuItem.Text = "Nascondi Lista Commesse";
            this.nascondiListaCommesseToolStripMenuItem.Click += new System.EventHandler(this.NascondiListaCommesseToolStripMenuItem_Click);
            // 
            // macroLavorazioniToolStripMenuItem1
            // 
            this.macroLavorazioniToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMacroLavorazioniToolStripMenuItem1});
            this.macroLavorazioniToolStripMenuItem1.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_martello_64;
            this.macroLavorazioniToolStripMenuItem1.Name = "macroLavorazioniToolStripMenuItem1";
            this.macroLavorazioniToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.macroLavorazioniToolStripMenuItem1.Text = "Macro Lavorazioni";
            // 
            // listaMacroLavorazioniToolStripMenuItem1
            // 
            this.listaMacroLavorazioniToolStripMenuItem1.Name = "listaMacroLavorazioniToolStripMenuItem1";
            this.listaMacroLavorazioniToolStripMenuItem1.Size = new System.Drawing.Size(222, 24);
            this.listaMacroLavorazioniToolStripMenuItem1.Text = "Lista Macro Lavorazioni";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exitToolStripMenuItem.Image = global::CarpenterieMetallicheDiomede.Properties.Resources.icons8_stemma_della_ferrari_48;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 427);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraListaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macroLavorazioniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaMacroLavorazioniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostraListaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ToolStripMenuItem bozzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bozzaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciBozzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraListaBozzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaBozzeToolStripMenuItem;
    }
}