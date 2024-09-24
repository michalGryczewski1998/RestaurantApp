namespace RestaurantApp.Forms.DodajForm.Restauracja
{
    partial class DodajRestauracje
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
            components = new System.ComponentModel.Container();
            DodajeRestauracjePanel = new Panel();
            DodajZdjecieTB = new Button();
            WyczyscTB = new Button();
            DodajBTN = new Button();
            pictureBox1 = new PictureBox();
            DanePodstawoweGB = new GroupBox();
            OpisRestauracjiTB = new TextBox();
            NumerDoZamowienTB = new TextBox();
            EmailTB = new TextBox();
            ImieTB = new TextBox();
            TelefonKontaktowyTB = new TextBox();
            NazwiskoTB = new TextBox();
            NazwaRestauracjiTB = new TextBox();
            CzyDostawaRB = new RadioButton();
            KategoriaLB = new ListBox();
            AdresGB = new GroupBox();
            KodPocztowyTB = new TextBox();
            UlicaTB = new TextBox();
            MiastoTB = new TextBox();
            StatusWalidacjiEP = new ErrorProvider(components);
            StatusLabel = new Label();
            DodajeRestauracjePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DanePodstawoweGB.SuspendLayout();
            AdresGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StatusWalidacjiEP).BeginInit();
            SuspendLayout();
            // 
            // DodajeRestauracjePanel
            // 
            DodajeRestauracjePanel.Controls.Add(StatusLabel);
            DodajeRestauracjePanel.Controls.Add(DodajZdjecieTB);
            DodajeRestauracjePanel.Controls.Add(WyczyscTB);
            DodajeRestauracjePanel.Controls.Add(DodajBTN);
            DodajeRestauracjePanel.Controls.Add(pictureBox1);
            DodajeRestauracjePanel.Controls.Add(DanePodstawoweGB);
            DodajeRestauracjePanel.Controls.Add(AdresGB);
            DodajeRestauracjePanel.Dock = DockStyle.Fill;
            DodajeRestauracjePanel.Location = new Point(0, 0);
            DodajeRestauracjePanel.Name = "DodajeRestauracjePanel";
            DodajeRestauracjePanel.Size = new Size(800, 450);
            DodajeRestauracjePanel.TabIndex = 2;
            // 
            // DodajZdjecieTB
            // 
            DodajZdjecieTB.Location = new Point(632, 249);
            DodajZdjecieTB.Name = "DodajZdjecieTB";
            DodajZdjecieTB.Size = new Size(156, 23);
            DodajZdjecieTB.TabIndex = 12;
            DodajZdjecieTB.Text = "Dodaj zdjęcie";
            DodajZdjecieTB.UseVisualStyleBackColor = true;
            // 
            // WyczyscTB
            // 
            WyczyscTB.Location = new Point(632, 415);
            WyczyscTB.Name = "WyczyscTB";
            WyczyscTB.Size = new Size(75, 23);
            WyczyscTB.TabIndex = 11;
            WyczyscTB.Text = "Wyczyść";
            WyczyscTB.UseVisualStyleBackColor = true;
            // 
            // DodajBTN
            // 
            DodajBTN.Location = new Point(713, 415);
            DodajBTN.Name = "DodajBTN";
            DodajBTN.Size = new Size(75, 23);
            DodajBTN.TabIndex = 10;
            DodajBTN.Text = "Dodaj";
            DodajBTN.UseVisualStyleBackColor = true;
            DodajBTN.Click += DodajBTN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(434, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 231);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // DanePodstawoweGB
            // 
            DanePodstawoweGB.Controls.Add(OpisRestauracjiTB);
            DanePodstawoweGB.Controls.Add(NumerDoZamowienTB);
            DanePodstawoweGB.Controls.Add(EmailTB);
            DanePodstawoweGB.Controls.Add(ImieTB);
            DanePodstawoweGB.Controls.Add(TelefonKontaktowyTB);
            DanePodstawoweGB.Controls.Add(NazwiskoTB);
            DanePodstawoweGB.Controls.Add(NazwaRestauracjiTB);
            DanePodstawoweGB.Controls.Add(CzyDostawaRB);
            DanePodstawoweGB.Controls.Add(KategoriaLB);
            DanePodstawoweGB.Location = new Point(12, 12);
            DanePodstawoweGB.Name = "DanePodstawoweGB";
            DanePodstawoweGB.Size = new Size(416, 231);
            DanePodstawoweGB.TabIndex = 8;
            DanePodstawoweGB.TabStop = false;
            DanePodstawoweGB.Text = "Informacje";
            // 
            // OpisRestauracjiTB
            // 
            OpisRestauracjiTB.BorderStyle = BorderStyle.FixedSingle;
            OpisRestauracjiTB.Location = new Point(181, 109);
            OpisRestauracjiTB.Multiline = true;
            OpisRestauracjiTB.Name = "OpisRestauracjiTB";
            OpisRestauracjiTB.Size = new Size(229, 116);
            OpisRestauracjiTB.TabIndex = 8;
            OpisRestauracjiTB.Text = "Opis:";
            // 
            // NumerDoZamowienTB
            // 
            NumerDoZamowienTB.BorderStyle = BorderStyle.FixedSingle;
            NumerDoZamowienTB.Location = new Point(181, 80);
            NumerDoZamowienTB.Name = "NumerDoZamowienTB";
            NumerDoZamowienTB.Size = new Size(169, 23);
            NumerDoZamowienTB.TabIndex = 7;
            NumerDoZamowienTB.Text = "Numer do zamówień";
            // 
            // EmailTB
            // 
            EmailTB.BorderStyle = BorderStyle.FixedSingle;
            EmailTB.Location = new Point(181, 22);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(169, 23);
            EmailTB.TabIndex = 5;
            EmailTB.Text = "E-Mail";
            // 
            // ImieTB
            // 
            ImieTB.BorderStyle = BorderStyle.FixedSingle;
            ImieTB.Location = new Point(6, 22);
            ImieTB.Name = "ImieTB";
            ImieTB.Size = new Size(169, 23);
            ImieTB.TabIndex = 0;
            ImieTB.Text = "Imię";
            // 
            // TelefonKontaktowyTB
            // 
            TelefonKontaktowyTB.BorderStyle = BorderStyle.FixedSingle;
            TelefonKontaktowyTB.Location = new Point(181, 51);
            TelefonKontaktowyTB.Name = "TelefonKontaktowyTB";
            TelefonKontaktowyTB.Size = new Size(169, 23);
            TelefonKontaktowyTB.TabIndex = 6;
            TelefonKontaktowyTB.Text = "Numer tel.";
            // 
            // NazwiskoTB
            // 
            NazwiskoTB.BorderStyle = BorderStyle.FixedSingle;
            NazwiskoTB.Location = new Point(6, 51);
            NazwiskoTB.Name = "NazwiskoTB";
            NazwiskoTB.Size = new Size(169, 23);
            NazwiskoTB.TabIndex = 1;
            NazwiskoTB.Text = "Nazwisko";
            // 
            // NazwaRestauracjiTB
            // 
            NazwaRestauracjiTB.BorderStyle = BorderStyle.FixedSingle;
            NazwaRestauracjiTB.Location = new Point(6, 80);
            NazwaRestauracjiTB.Name = "NazwaRestauracjiTB";
            NazwaRestauracjiTB.Size = new Size(169, 23);
            NazwaRestauracjiTB.TabIndex = 2;
            NazwaRestauracjiTB.Text = "Restauracja";
            // 
            // CzyDostawaRB
            // 
            CzyDostawaRB.AutoSize = true;
            CzyDostawaRB.Location = new Point(6, 209);
            CzyDostawaRB.Name = "CzyDostawaRB";
            CzyDostawaRB.Size = new Size(78, 19);
            CzyDostawaRB.TabIndex = 4;
            CzyDostawaRB.TabStop = true;
            CzyDostawaRB.Text = "Dostawa ?";
            CzyDostawaRB.UseVisualStyleBackColor = true;
            // 
            // KategoriaLB
            // 
            KategoriaLB.FormattingEnabled = true;
            KategoriaLB.ItemHeight = 15;
            KategoriaLB.Items.AddRange(new object[] { "Włoska", "Francuska", "Chińska", "Japońska", "Meksykańska", "Indyjska", "Tajska", "Śródziemnomorska", "Amerykańska", "Wegetariańska / Wegańska", "Fusion", "Grill / Barbecue", "Seafood (rybna)", "Fast food", "Steakhouse", "Pizzeria", "Kawiarnia", "Cukiernia / Piekarnia", "Restauracja rodzinna", "Fine dining (wykwintna)" });
            KategoriaLB.Location = new Point(6, 109);
            KategoriaLB.Name = "KategoriaLB";
            KategoriaLB.Size = new Size(169, 94);
            KategoriaLB.TabIndex = 3;
            // 
            // AdresGB
            // 
            AdresGB.Controls.Add(KodPocztowyTB);
            AdresGB.Controls.Add(UlicaTB);
            AdresGB.Controls.Add(MiastoTB);
            AdresGB.Location = new Point(12, 249);
            AdresGB.Name = "AdresGB";
            AdresGB.Size = new Size(188, 189);
            AdresGB.TabIndex = 7;
            AdresGB.TabStop = false;
            AdresGB.Text = "Adres";
            // 
            // KodPocztowyTB
            // 
            KodPocztowyTB.BorderStyle = BorderStyle.FixedSingle;
            KodPocztowyTB.Location = new Point(6, 80);
            KodPocztowyTB.Name = "KodPocztowyTB";
            KodPocztowyTB.Size = new Size(169, 23);
            KodPocztowyTB.TabIndex = 3;
            KodPocztowyTB.Text = "Kod Pocztowy";
            // 
            // UlicaTB
            // 
            UlicaTB.BorderStyle = BorderStyle.FixedSingle;
            UlicaTB.Location = new Point(6, 51);
            UlicaTB.Name = "UlicaTB";
            UlicaTB.Size = new Size(169, 23);
            UlicaTB.TabIndex = 2;
            UlicaTB.Text = "Ulica";
            // 
            // MiastoTB
            // 
            MiastoTB.BorderStyle = BorderStyle.FixedSingle;
            MiastoTB.Location = new Point(6, 22);
            MiastoTB.Name = "MiastoTB";
            MiastoTB.Size = new Size(169, 23);
            MiastoTB.TabIndex = 1;
            MiastoTB.Text = "Miasto";
            // 
            // StatusWalidacjiEP
            // 
            StatusWalidacjiEP.ContainerControl = this;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(206, 423);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(0, 15);
            StatusLabel.TabIndex = 13;
            // 
            // DodajRestauracje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DodajeRestauracjePanel);
            Name = "DodajRestauracje";
            Text = "DodajRestauracjeForm";
            DodajeRestauracjePanel.ResumeLayout(false);
            DodajeRestauracjePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DanePodstawoweGB.ResumeLayout(false);
            DanePodstawoweGB.PerformLayout();
            AdresGB.ResumeLayout(false);
            AdresGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StatusWalidacjiEP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel DodajeRestauracjePanel;
        private TextBox NazwaRestauracjiTB;
        private TextBox NazwiskoTB;
        private TextBox ImieTB;
        private ListBox KategoriaLB;
        private GroupBox DanePodstawoweGB;
        private TextBox NumerDoZamowienTB;
        private TextBox EmailTB;
        private TextBox TelefonKontaktowyTB;
        private RadioButton CzyDostawaRB;
        private GroupBox AdresGB;
        private TextBox KodPocztowyTB;
        private TextBox UlicaTB;
        private TextBox MiastoTB;
        private Button DodajZdjecieTB;
        private Button WyczyscTB;
        private Button DodajBTN;
        private PictureBox pictureBox1;
        private TextBox OpisRestauracjiTB;
        private ErrorProvider StatusWalidacjiEP;
        private Label StatusLabel;
    }
}