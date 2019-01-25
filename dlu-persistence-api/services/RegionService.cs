using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class RegionService: IRegionService
    {
        private RegionDao _dao;

        public RegionService()
        {
            _dao = new RegionDao();
        }

        public string GetRegions()
        {
            return _dao.GetRegions();
        }
    }
}