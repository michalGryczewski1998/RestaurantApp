using Microsoft.Extensions.Configuration;
using RestaurantApp.Models.Dodaj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Funkcjonalnosc.Connector
{
    public class MainConnector
    {
        public IConfiguration Configuration { get; }
        ConfigurationBuilder _builder = new ();
        DodajRestauracjeModel _daneRestauracji;

        public MainConnector(DodajRestauracjeModel daneRestauracji)
        {
            _daneRestauracji = daneRestauracji;

            _builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = _builder.Build();
        }

        private void DodajRestauracje()
        {
            string _apiUrl = Configuration["AppSettings:ApiUrl"];

        }
    }
}
