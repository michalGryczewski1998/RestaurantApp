using RestaurantApp.Funkcjonalnosc.Connector;
using RestaurantApp.Models.Dodaj;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Funkcjonalnosc.Dodaj
{
    public class DodajRestauracjeAkcja
    {
        public void Dodaj(DodajRestauracjeModel daneRestauracji)
        {   Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            var connector = new MainConnector(daneRestauracji);
            connector.DodajRestauracje();

            stopwatch.Stop();
#if DEBUG
            Console.WriteLine($"Czas wykonania metody: {stopwatch.ElapsedMilliseconds / 1000} sekund");
#endif
        }

    }
}
