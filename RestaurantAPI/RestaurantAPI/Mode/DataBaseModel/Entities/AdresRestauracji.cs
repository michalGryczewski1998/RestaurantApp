namespace RestaurantAPI.Mode.DataBaseModel.Entities
{
    public class AdresRestauracji
    {
        public Guid Id { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string KodPocztowy { get; set; }
        // Wlasciwosc nawigacyjna do restauracji
        public RestauracjaDane Restauracja { get; set; }
        // Klucz obcy restauracji
        public Guid RestauracjaId { get; set; }
    }
}
