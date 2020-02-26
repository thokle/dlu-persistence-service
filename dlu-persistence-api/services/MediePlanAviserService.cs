using dlu_persistence_api.daos;
using dlu_persistence_api.models;
namespace dlu_persistence_api.services

{
    public class MediePlanAviserService
    {
        private MediePlanAviserDao dao;


        public MediePlanAviserService()
        {
            dao = new MediePlanAviserDao();
        }
        public AvisTIlGrid GetAllUgeAvisTilGrid(int bladid, int year, int placeringid)
        {
            return dao.GetAllUgeAvisTilGrid(bladid, year, placeringid);
        }
    }
}
