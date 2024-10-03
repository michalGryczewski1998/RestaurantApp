namespace RestaurantAPI.Mode.PrzyjmowaneDane.RestauracjaInfo
{
    public class RestauracjaModel
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
        public string? Zdjecie { get; set; }
        public AdresRestauracjiModel Adres { get; set; }
    }
}
