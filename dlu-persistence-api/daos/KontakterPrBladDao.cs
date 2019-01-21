using System;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class KontakterPrBladDao
    {
        private DiMPdotNetEntities _entities;

        public KontakterPrBladDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }   
        }

        public Task<int> CreateOrUpdateKontakterPrBlad(tblKontakterPrBlad tblKontakterPrBlad)
        {
            try
            {
                _entities.tblKontakterPrBlads.AddOrUpdate(tblKontakterPrBlad);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw  new DaoExceptions("KontakterPrBladDao CreateOrUpdateKontakterPrBlad", e.InnerException);
            }

        }
        
        
        
    }
}