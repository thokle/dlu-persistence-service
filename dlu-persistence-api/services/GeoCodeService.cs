using dlu_persistence_api.daos;
using dlu_persistence_api.services.interfaces;
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
