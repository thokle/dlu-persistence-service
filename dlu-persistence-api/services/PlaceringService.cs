using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class PlaceringService
    {
        private PlaceringDao placeringDao;

        public PlaceringService()
        {
            placeringDao = new PlaceringDao();
        }


        public Task<int> OpretPlacering(tblPlacering tblPlacering)
        {
            return placeringDao.OpretPlacering(tblPlacering);
        }
    }
}
