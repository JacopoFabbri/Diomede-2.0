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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraListaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nascondiListaCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macroLavorazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMacroLavorazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneEconomicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPagamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gestioneCommesseToolStripMenuItem,
            this.gestioneEconomicaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(806, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 23);
            this.toolStripMenuItem1.Text = "Gestione Clienti";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientiToolStripMenuItem,
            this.aggiungiClienteToolStripMenuItem,
            this.mostraListaClientiToolStripMenuItem,
            this.nascondiListaClientiToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem2.Text = "Ditta";
            // 
            // listaClientiToolStripMenuItem
            // 
            this.listaClientiToolStripMenuItem.Name = "listaClientiToolStripMenuItem";
            this.listaClientiToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.listaClientiToolStripMenuItem.Text = "Lista Clienti";
            this.listaClientiToolStripMenuItem.Click += new System.EventHandler(this.ListaClientiToolStripMenuItem_Click);
            // 
            // aggiungiClienteToolStripMenuItem
            // 
            this.aggiungiClienteToolStripMenuItem.Name = "aggiungiClienteToolStripMenuItem";
            this.aggiungiClienteToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.aggiungiClienteToolStripMenuItem.Text = "Aggiungi Cliente";
            this.aggiungiClienteToolStripMenuItem.Click += new System.EventHandler(this.AggiungiClienteToolStripMenuItem_Click);
            // 
            // mostraListaClientiToolStripMenuItem
            // 
            this.mostraListaClientiToolStripMenuItem.Name = "mostraListaClientiToolStripMenuItem";
            this.mostraListaClientiToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.mostraListaClientiToolStripMenuItem.Text = "Mostra Lista Clienti";
            // 
            // nascondiListaClientiToolStripMenuItem
            // 
            this.nascondiListaClientiToolStripMenuItem.Name = "nascondiListaClientiToolStripMenuItem";
            this.nascondiListaClientiToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.nascondiListaClientiToolStripMenuItem.Text = "Nascondi Lista Clienti";
            // 
            // gestioneCommesseToolStripMenuItem
            // 
            this.gestioneCommesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commesseToolStripMenuItem,
            this.macroLavorazioniToolStripMenuItem1});
            this.gestioneCommesseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestioneCommesseToolStripMenuItem.Name = "gestioneCommesseToolStripMenuItem";
            this.gestioneCommesseToolStripMenuItem.Size = new System.Drawing.Size(146, 23);
            this.gestioneCommesseToolStripMenuItem.Text = "Gestione Commesse";
            // 
            // commesseToolStripMenuItem
            // 
            this.commesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCommesseToolStripMenuItem,
            this.mostraListaCommesseToolStripMenuItem,
            this.nascondiListaCommesseToolStripMenuItem});
            this.commesseToolStripMenuItem.Name = "commesseToolStripMenuItem";
            this.commesseToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.commesseToolStripMenuItem.Text = "Commesse";
            // 
            // listaCommesseToolStripMenuItem
            // 
            this.listaCommesseToolStripMenuItem.Name = "listaCommesseToolStripMenuItem";
            this.listaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.listaCommesseToolStripMenuItem.Text = "Lista Commesse";
            // 
            // mostraListaCommesseToolStripMenuItem
            // 
            this.mostraListaCommesseToolStripMenuItem.Name = "mostraListaCommesseToolStripMenuItem";
            this.mostraListaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.mostraListaCommesseToolStripMenuItem.Text = "Mostra Lista Commesse";
            // 
            // nascondiListaCommesseToolStripMenuItem
            // 
            this.nascondiListaCommesseToolStripMenuItem.Name = "nascondiListaCommesseToolStripMenuItem";
            this.nascondiListaCommesseToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.nascondiListaCommesseToolStripMenuItem.Text = "Nascondi Lista Commesse";
            // 
            // macroLavorazioniToolStripMenuItem1
            // 
            this.macroLavorazioniToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMacroLavorazioniToolStripMenuItem1});
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
            // gestioneEconomicaToolStripMenuItem
            // 
            this.gestioneEconomicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagamentiToolStripMenuItem});
            this.gestioneEconomicaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gestioneEconomicaToolStripMenuItem.Name = "gestioneEconomicaToolStripMenuItem";
            this.gestioneEconomicaToolStripMenuItem.Size = new System.Drawing.Size(144, 23);
            this.gestioneEconomicaToolStripMenuItem.Text = "Gestione Economica";
            // 
            // pagamentiToolStripMenuItem
            // 
            this.pagamentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPagamentiToolStripMenuItem});
            this.pagamentiToolStripMenuItem.Name = "pagamentiToolStripMenuItem";
            this.pagamentiToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.pagamentiToolStripMenuItem.Text = "Pagamenti";
            // 
            // listaPagamentiToolStripMenuItem
            // 
            this.listaPagamentiToolStripMenuItem.Name = "listaPagamentiToolStripMenuItem";
            this.listaPagamentiToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.listaPagamentiToolStripMenuItem.Text = "Lista Pagamenti";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exitToolStripMenuItem.Image = global::PonteggiDiomede.Properties.Resources.icons8_eliminare_48;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 427);
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
        private System.Windows.Forms.ToolStripMenuItem gestioneEconomicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macroLavorazioniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaMacroLavorazioniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagamentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPagamentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraListaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nascondiListaCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}