using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Controllers;
using RestaurantAPI.Mode.DataBaseModel.Entities;

namespace RestaurantAPI.Mode.DataBaseModel
{
    public class RestaurantDbContext : DbContext
    {
        ConfigurationBuilder configurationBuilder = new();
        private readonly string _connectionString = String.Empty;

        public DbSet<RestauracjaDane> restauracja { get; set; }
        public DbSet<AdresRestauracji> adresRestauracji { get; set; }


        public RestaurantDbContext(IConfiguration configuration)
        {
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = configurationBuilder.Build();
            _connectionString = configuration["ConnectionStrings:Connection"];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestauracjaDane>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Imie).IsRequired().HasMaxLength(25);
                entity.Property(e => e.Nazwisko).IsRequired().HasMaxLength(55);
                entity.Property(e => e.Nazwa).IsRequired().HasMaxLength(120);
                entity.Property(e => e.Opis).IsRequired().HasMaxLength(350);
                entity.Property(e => e.NumerTelRestauracji).IsRequired().HasMaxLength(20);

                entity.HasOne(e => e.AdresRestauracji)
                .WithOne(e => e.Restauracja)
                .HasForeignKey<AdresRestauracji>(e => e.RestauracjaId);
            });

            modelBuilder.Entity<AdresRestauracji>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Miasto).IsRequired().HasMaxLength(55);
            });
        }
    }
}
