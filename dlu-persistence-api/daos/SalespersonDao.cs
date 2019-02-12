using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class SalespersonDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public SalespersonDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetSalesPersonByEmail(string email)
        {
            try
            {
                var res = from p in _entities.Salespersons
                    where p.E_Mail == email
                    orderby p.E_Mail
                    select new
                    {
                        p.E_Mail, p.Code, p.Name,p.Rolle,p.Status, p.NulstilLayout, p.Phone_No_, p.SidsteLoginVersion
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetSalesPersonByEmail " , e.InnerException);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetSalesPersonByName(string name)
        {
            try
            {
                var res = from p in _entities.Salespersons
                    where p.Name == name
                    orderby p.E_Mail
                    select new
                    {
                        p.E_Mail, p.Code, p.Name,p.Rolle,p.Status, p.NulstilLayout, p.Phone_No_, p.SidsteLoginVersion
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetSalesPersonByName ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="salesperson"></param>
        /// <returns></returns>
        /// <exception cref="FormattedDbEntityValidationException"></exception>
        public Task<int> CreateOrUpdate(Salesperson salesperson)
        {
            try
            {
                _entities.Salespersons.AddOrUpdate(salesperson);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
               
                throw new  FormattedDbEntityValidationException(e);
            }
        }
        
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}