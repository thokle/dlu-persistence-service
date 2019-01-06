using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.models;
using dlu_persistence_api.mapper;
namespace dlu_persistence_api.daos
{
    public class MediePlanDao
    {
        private DiMPdotNetEntities entities;
        private mapper.AutoMaperUtil mapper;
        public MediePlanDao()
        {
            this.entities = new DiMPdotNetEntities();
            this.mapper = new AutoMaperUtil();
            entities.Configuration.LazyLoadingEnabled = true;
        }



        public MediePlan GetMediePlanByNumber(int medieplanNr)
        {
            var res = entities.tblMedieplans.Where(predicate => predicate.MedieplanNr == medieplanNr).SingleOrDefault();

         return   dlu_persistence_api.mapper.AutoMaperUtil.ConvertFromTbleMdiePlan(res);
        }
    }
}



        




