using dlu_persistence_api.daos;

namespace dlu_persistence_api.services
{
    public class BladTilaegsTypeService
    {
        private BladTilaegsTypeDao dao;

        public BladTilaegsTypeService()
        {
            dao = new BladTilaegsTypeDao();
        }
        public int CreateOrUpdate(tblBladTillaegsType tblBladTillaegsType)
        {
            return dao.CreateOrUpdate(tblBladTillaegsType);
        }


    }
}

