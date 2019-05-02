using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class GeoCodeService : IGeoCodeService
    {
        private GeoDao geoDao;

        public GeoCodeService()
        {
            geoDao = new GeoDao();
        }
        public string GetGeoCodeById(int geocodeid)
        {
            return geoDao.GetGeoCodeById(geocodeid);
        }
    }
}
