using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.services.interfaces;
namespace dlu_persistence_api.services

{
    public class MediePlanAviserService
    {
        private MediePlanAviserDao dao;


        public MediePlanAviserService()
        {
            dao = new MediePlanAviserDao();
        }
        public AviserTilGrid GetAllUgeAvisTilGrid(int bladid, int year, int placeringid)
        {
            return dao.GetAllUgeAvisTilGrid(bladid, year, placeringid);
        }
    }
}
