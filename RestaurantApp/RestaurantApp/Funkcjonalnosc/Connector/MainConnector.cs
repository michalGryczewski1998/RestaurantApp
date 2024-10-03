using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using RestaurantApp.Models.Dodaj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestaurantApp.Funkcjonalnosc.Connector
{
    public class MainConnector
    {
        public IConfiguration Configuration { get; }
        ConfigurationBuilder _builder = new ();
        DodajRestauracjeModel _daneRestauracji;
        private static readonly HttpClient client = new HttpClient();

        public MainConnector(DodajRestauracjeModel daneRestauracji)
        {
            _daneRestauracji = daneRestauracji;

            _builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = _builder.Build();
        }

        public async Task DodajRestauracje()
        {
            string _apiUrl = Configuration["AppSettings:ApiDodaj"];

            var json = JsonConvert.SerializeObject(_daneRestauracji);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(_apiUrl, content);

#if DEBUG
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Dane zostały pomyślnie wysłane!");
            }
            else
            {
                Console.WriteLine($"Błąd: {response.StatusCode}");
            }
#endif
        }
    }
}
