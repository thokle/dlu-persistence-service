using Map_Service_Api.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Map_Service_Api
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var postnr = new List<int>();
            postnr.Add(2300);
            postnr.Add(2400);

            MapLocationService mapLocationService = new MapLocationService();

            mapLocationService.CreateMapFromMediePlan(postnr).Result.ForEach(res =>
            {
                res.Locations.ToList().ForEach(loc =>
                {
                    Console.WriteLine(loc);
                });
            });

            
        }
    }
}
