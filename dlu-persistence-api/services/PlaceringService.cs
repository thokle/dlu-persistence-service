using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.services.interfaces;
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
