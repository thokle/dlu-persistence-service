using XPlat.Device.Geolocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace Map_Service_Api.services
{
   public class GeoLocationService : IDisposable
    {
       // private Geolocator geolocator { get; set; }
       
        public GeoLocationService()
        {
          //  geolocator = new Geolocator();
      
        }

        public  string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public string GetIP()
        {
            string externalIP = "";
            externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
            externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString();
            return externalIP;
        }

        public  Task<Tuple<double, double, double, double>> GetUserGeoLocationAsync()
        {
            /*  var location =   geolocator.GetLocation(TimeSpan.FromMilliseconds(500), TimeSpan.FromSeconds(1).TotalSeconds).ContinueWith(e =>
             {
                 var coordinates = e.Result;
                 var re = new Tuple<double, double, double, double>(coordinates.Coordinate.Latitude, coordinates.Coordinate.Longitude, coordinates.Coordinate.Accuracy, coordinates.Coordinate.Altitude);
                 return re;
             });*/
            return null;
          //  return location;
        }
        public void Dispose()
        {
            this.Dispose();
        }
    }
}
