using RestaurantApp.Funkcjonalnosc.Dodaj;
using RestaurantApp.Models.Dodaj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Forms.DodajForm.Restauracja
{
    public partial class DodajRestauracje : Form
    {
        private static DodajRestauracje? _instance = null;
        private readonly string _zdjecie = string.Empty;

        public DodajRestauracje()
        {
            InitializeComponent();
        }

        public static DodajRestauracje Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DodajRestauracje();
                }
                return _instance;
            }
        }

        public static bool TruOrFalseInstance
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private void DodajBTN_Click(object sender, EventArgs e)
        {  
            bool _status;
            DodajRestauracjeModel _restauracja = new();
            DodajRestauracjeAkcja dodaj = new();

            PobierzDaneDlaRestauracji(ref _restauracja);

            if (_restauracja != null)
            {
                dodaj.Dodaj(_restauracja);
            }
            else
            {
                MessageBox.Show("Brak danych o restauracji");
            }


        }

        private void PobierzDaneDlaRestauracji(ref DodajRestauracjeModel restauracja)
        {
            try
            {
                List<Control> listaKontrolek = DodajeRestauracjePanel.Controls.OfType<GroupBox>().Cast<Control>().ToList();
                bool statusWalidacji = WalidacjaDanych(listaKontrolek);
                if (statusWalidacji) 
                {
                    AdresRestauracjiModel adres = new()
                    {
                        Miasto = MiastoTB.Text,
                        Ulica = UlicaTB.Text,
                        KodPocztowy = KodPocztowyTB.Text
                    };

                    restauracja.Imie = ImieTB.Text;
                    restauracja.Nazwisko = NazwiskoTB.Text;
                    restauracja.Email = EmailTB.Text;
                    restauracja.NumerTelRestauracji = TelefonKontaktowyTB.Text;
                    restauracja.NumerTelDoZamowien = NumerDoZamowienTB.Text;
                    restauracja.Nazwa = NazwaRestauracjiTB.Text;
                    restauracja.Kategoria = KategoriaLB.SelectedItem.ToString();
                    restauracja.CzyDostawa = CzyDostawaRB.Checked ? true : false;
                    restauracja.Opis = OpisRestauracjiTB.Text;
                    restauracja.Zdjecie = _zdjecie;
                    restauracja.Adres = adres;
                }
                else
                {
                    StatusWalidacjiEP.SetError(StatusLabel, "Proszę wypełnić wszystkie dane");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd podczas dodawania danych: " + e.Message);
            }
        }

        private bool WalidacjaDanych(List<Control> listaKontrolek)
        {
            bool status = true;
          
            foreach (Control control in listaKontrolek) 
            {
                if (control is GroupBox)
                {
                    List<TextBox> listaTextBox = control.Controls.OfType<TextBox>().ToList();
                    foreach (TextBox item in listaTextBox)
                    {
                        TextBox textBox = item as TextBox;
                        if (string.IsNullOrEmpty(textBox.Text))
                        {
                            return false;
                        }
                    }
                }
            }

            if (KategoriaLB.Items == null || string.IsNullOrEmpty(_zdjecie))
            {
                status = false;
            }

            return status;
        }
    }
}
