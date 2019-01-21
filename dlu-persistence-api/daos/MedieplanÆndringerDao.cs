using System;

using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class MedieplanÆndringerDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        private MedieplanÆndringerDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }


        public string GetMediePlanÆndringerByMedieId(int mediePlan)
        {
            try
            {
                var res = from m in _entities.tblMedieplanÆndringer
                    where m.MedieplanNr == mediePlan
                    select new
                    {
                        m.MedieplanNr, m.Version, m.ÆndringsTekst
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("MedieplanÆndringerDao GetMediePlanÆndringerByMedieId " , e.InnerException);
            }

        }

        public Task<int> CreateOrUpdate(tblMedieplanÆndringer tblMedieplanÆndringer)
        {
            try
            {
                _entities.tblMedieplanÆndringer.AddOrUpdate(tblMedieplanÆndringer);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new DaoExceptions(" MedieplanÆndringerDao CreateOrUpdate ", e.InnerException);
            }
        }


        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}