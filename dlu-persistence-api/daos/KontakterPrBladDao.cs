using System;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblKontakterPrBlad"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Task<int> CreateOrUpdateKontakterPrBlad(tblKontakterPrBlad tblKontakterPrBlad)
        {
            try
            {
                _entities.tblKontakterPrBlads.AddOrUpdate(tblKontakterPrBlad);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw  new FormatException();
            }

        }
        
        
        
    }
}