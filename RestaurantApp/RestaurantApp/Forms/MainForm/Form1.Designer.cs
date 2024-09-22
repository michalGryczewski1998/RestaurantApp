namespace RestaurantApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RestauracjaSM = new MenuStrip();
            dodajToolStripMenuItem = new ToolStripMenuItem();
            DodajRestauracjeMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            DodajMenuCaleMenuItem = new ToolStripMenuItem();
            DodajKonkretnaPozDoMenuItem = new ToolStripMenuItem();
            usuńToolStripMenuItem = new ToolStripMenuItem();
            restauracjęToolStripMenuItem1 = new ToolStripMenuItem();
            menuToolStripMenuItem1 = new ToolStripMenuItem();
            całeToolStripMenuItem1 = new ToolStripMenuItem();
            konkretnaPozycjaToolStripMenuItem = new ToolStripMenuItem();
            modyfikujToolStripMenuItem = new ToolStripMenuItem();
            restauracjęToolStripMenuItem2 = new ToolStripMenuItem();
            menuToolStripMenuItem2 = new ToolStripMenuItem();
            całeToolStripMenuItem2 = new ToolStripMenuItem();
            konkretnaPozycjaToolStripMenuItem1 = new ToolStripMenuItem();
            informacjeToolStripMenuItem = new ToolStripMenuItem();
            oAplikacjiToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            PoleRoboczePanel = new Panel();
            ZakladkiPodmenu = new TabControl();
            RestauracjaSM.SuspendLayout();
            panel1.SuspendLayout();
            PoleRoboczePanel.SuspendLayout();
            SuspendLayout();
            // 
            // RestauracjaSM
            // 
            RestauracjaSM.Items.AddRange(new ToolStripItem[] { dodajToolStripMenuItem, usuńToolStripMenuItem, modyfikujToolStripMenuItem, informacjeToolStripMenuItem });
            RestauracjaSM.Location = new Point(0, 0);
            RestauracjaSM.Name = "RestauracjaSM";
            RestauracjaSM.Size = new Size(811, 24);
            RestauracjaSM.TabIndex = 0;
            RestauracjaSM.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            dodajToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DodajRestauracjeMenuItem, menuToolStripMenuItem });
            dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            dodajToolStripMenuItem.Size = new Size(50, 20);
            dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // DodajRestauracjeMenuItem
            // 
            DodajRestauracjeMenuItem.Name = "DodajRestauracjeMenuItem";
            DodajRestauracjeMenuItem.Size = new Size(134, 22);
            DodajRestauracjeMenuItem.Text = "Restaurację";
            DodajRestauracjeMenuItem.Click += DodajRestauracjeMenuItem_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DodajMenuCaleMenuItem, DodajKonkretnaPozDoMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(134, 22);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // DodajMenuCaleMenuItem
            // 
            DodajMenuCaleMenuItem.Name = "DodajMenuCaleMenuItem";
            DodajMenuCaleMenuItem.Size = new Size(171, 22);
            DodajMenuCaleMenuItem.Text = "Całe";
            DodajMenuCaleMenuItem.Click += DodajMenuCaleMenuItem_Click;
            // 
            // DodajKonkretnaPozDoMenuItem
            // 
            DodajKonkretnaPozDoMenuItem.Name = "DodajKonkretnaPozDoMenuItem";
            DodajKonkretnaPozDoMenuItem.Size = new Size(171, 22);
            DodajKonkretnaPozDoMenuItem.Text = "Konkretna pozycja";
            DodajKonkretnaPozDoMenuItem.Click += DodajKonkretnaPozDoMenuItem_Click;
            // 
            // usuńToolStripMenuItem
            // 
            usuńToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restauracjęToolStripMenuItem1, menuToolStripMenuItem1 });
            usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            usuńToolStripMenuItem.Size = new Size(46, 20);
            usuńToolStripMenuItem.Text = "Usuń";
            // 
            // restauracjęToolStripMenuItem1
            // 
            restauracjęToolStripMenuItem1.Name = "restauracjęToolStripMenuItem1";
            restauracjęToolStripMenuItem1.Size = new Size(134, 22);
            restauracjęToolStripMenuItem1.Text = "Restaurację";
            // 
            // menuToolStripMenuItem1
            // 
            menuToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { całeToolStripMenuItem1, konkretnaPozycjaToolStripMenuItem });
            menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            menuToolStripMenuItem1.Size = new Size(134, 22);
            menuToolStripMenuItem1.Text = "Menu";
            // 
            // całeToolStripMenuItem1
            // 
            całeToolStripMenuItem1.Name = "całeToolStripMenuItem1";
            całeToolStripMenuItem1.Size = new Size(171, 22);
            całeToolStripMenuItem1.Text = "Całe";
            // 
            // konkretnaPozycjaToolStripMenuItem
            // 
            konkretnaPozycjaToolStripMenuItem.Name = "konkretnaPozycjaToolStripMenuItem";
            konkretnaPozycjaToolStripMenuItem.Size = new Size(171, 22);
            konkretnaPozycjaToolStripMenuItem.Text = "Konkretna pozycja";
            // 
            // modyfikujToolStripMenuItem
            // 
            modyfikujToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restauracjęToolStripMenuItem2, menuToolStripMenuItem2 });
            modyfikujToolStripMenuItem.Name = "modyfikujToolStripMenuItem";
            modyfikujToolStripMenuItem.Size = new Size(73, 20);
            modyfikujToolStripMenuItem.Text = "Modyfikuj";
            // 
            // restauracjęToolStripMenuItem2
            // 
            restauracjęToolStripMenuItem2.Name = "restauracjęToolStripMenuItem2";
            restauracjęToolStripMenuItem2.Size = new Size(134, 22);
            restauracjęToolStripMenuItem2.Text = "Restaurację";
            // 
            // menuToolStripMenuItem2
            // 
            menuToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { całeToolStripMenuItem2, konkretnaPozycjaToolStripMenuItem1 });
            menuToolStripMenuItem2.Name = "menuToolStripMenuItem2";
            menuToolStripMenuItem2.Size = new Size(134, 22);
            menuToolStripMenuItem2.Text = "Menu";
            // 
            // całeToolStripMenuItem2
            // 
            całeToolStripMenuItem2.Name = "całeToolStripMenuItem2";
            całeToolStripMenuItem2.Size = new Size(171, 22);
            całeToolStripMenuItem2.Text = "Całe";
            // 
            // konkretnaPozycjaToolStripMenuItem1
            // 
            konkretnaPozycjaToolStripMenuItem1.Name = "konkretnaPozycjaToolStripMenuItem1";
            konkretnaPozycjaToolStripMenuItem1.Size = new Size(171, 22);
            konkretnaPozycjaToolStripMenuItem1.Text = "Konkretna pozycja";
            // 
            // informacjeToolStripMenuItem
            // 
            informacjeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikacjiToolStripMenuItem });
            informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            informacjeToolStripMenuItem.Size = new Size(76, 20);
            informacjeToolStripMenuItem.Text = "Informacje";
            // 
            // oAplikacjiToolStripMenuItem
            // 
            oAplikacjiToolStripMenuItem.Name = "oAplikacjiToolStripMenuItem";
            oAplikacjiToolStripMenuItem.Size = new Size(129, 22);
            oAplikacjiToolStripMenuItem.Text = "O aplikacji";
            // 
            // panel1
            // 
            panel1.Controls.Add(RestauracjaSM);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 30);
            panel1.TabIndex = 3;
            // 
            // PoleRoboczePanel
            // 
            PoleRoboczePanel.Controls.Add(ZakladkiPodmenu);
            PoleRoboczePanel.Dock = DockStyle.Fill;
            PoleRoboczePanel.Location = new Point(0, 30);
            PoleRoboczePanel.Name = "PoleRoboczePanel";
            PoleRoboczePanel.Size = new Size(811, 522);
            PoleRoboczePanel.TabIndex = 5;
            // 
            // ZakladkiPodmenu
            // 
            ZakladkiPodmenu.Dock = DockStyle.Fill;
            ZakladkiPodmenu.Location = new Point(0, 0);
            ZakladkiPodmenu.Name = "ZakladkiPodmenu";
            ZakladkiPodmenu.SelectedIndex = 0;
            ZakladkiPodmenu.Size = new Size(811, 522);
            ZakladkiPodmenu.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 552);
            Controls.Add(PoleRoboczePanel);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "RestauracjaApp";
            RestauracjaSM.ResumeLayout(false);
            RestauracjaSM.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PoleRoboczePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip RestauracjaSM;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripMenuItem DodajRestauracjeMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem DodajMenuCaleMenuItem;
        private Panel panel1;
        private Panel PoleRoboczePanel;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripMenuItem restauracjęToolStripMenuItem1;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem całeToolStripMenuItem1;
        private ToolStripMenuItem konkretnaPozycjaToolStripMenuItem;
        private ToolStripMenuItem modyfikujToolStripMenuItem;
        private ToolStripMenuItem restauracjęToolStripMenuItem2;
        private ToolStripMenuItem menuToolStripMenuItem2;
        private ToolStripMenuItem całeToolStripMenuItem2;
        private ToolStripMenuItem konkretnaPozycjaToolStripMenuItem1;
        private ToolStripMenuItem DodajKonkretnaPozDoMenuItem;
        private ToolStripMenuItem informacjeToolStripMenuItem;
        private ToolStripMenuItem oAplikacjiToolStripMenuItem;
        private TabControl ZakladkiPodmenu;
    }
}
