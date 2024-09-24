using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models.Dodaj
{
    public class DodajRestauracjeModel
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Email { get; set; }
        public string NumerTelRestauracji { get; set; }
        public string NumerTelDoZamowien { get; set; }
        public string Kategoria { get; set; }
        public bool CzyDostawa { get; set; }
        public string Zdjecie { get; set; }
        public AdresRestauracjiModel Adres { get; set; }
    }
}
