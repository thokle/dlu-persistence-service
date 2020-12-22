using Microsoft.VisualStudio.TestTools.UnitTesting;
using Map_Service_Api.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_Service_Api.services.Tests
{
    [TestClass()]
    public class GeoLocationServiceTests
    {
        [TestMethod()]
        public void GetUserGeoLocationAsyncTest()
        {
            GeoLocationService geoLocationService = new GeoLocationService();

            var res = geoLocationService.GetIP();
           
                Console.WriteLine("lattite {0}", res);
         
          
        }
    }
}