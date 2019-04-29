using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class DelOmraadeService : IDelOmraadeService
    {
        private DelOmraadeDao _omraadeDao;

        public DelOmraadeService()
        {
            _omraadeDao = new DelOmraadeDao();
        }
        public string GetAllRegions()
        {
            return _omraadeDao.GetAllRegions();
        }

        public string GetDelOmraadeById(int delomraadeId)
        {
          return  _omraadeDao.GetDelOmraadeById(delomraadeId);
        }
    }
}
      
        
