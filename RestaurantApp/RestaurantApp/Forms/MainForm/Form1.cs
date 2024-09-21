using RestaurantApp.Forms.DodajForm.Restauracja;

namespace RestaurantApp
{
    public partial class MainForm : Form
    {
        private TabPage _tabDodajRestauracje;

        public MainForm()
        {
            InitializeComponent();
        }

        private void DodajRestauracjeMenuItem_Click(object sender, EventArgs e)
        {
            if (DodajRestauracje.TruOrFalseInstance)
            {
                _tabDodajRestauracje = new TabPage();
                UstawieniaFormWewnatrzTabPage(_tabDodajRestauracje, DodajRestauracje.Instance);
            }
            else 
            {
                ZakladkiPodmenu.Name = "Dodaj Restauracje";
                ZakladkiPodmenu.SelectedTab = _tabDodajRestauracje;
            }
        }

        private void DodajMenuCaleMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DodajKonkretnaPozDoMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UstawieniaFormWewnatrzTabPage(TabPage tabPage, Form form)
        {
            ZakladkiPodmenu.Controls.Add(tabPage);

            tabPage.Text = form.Name;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
            ZakladkiPodmenu.SelectedTab = tabPage;
        }
    }
}
