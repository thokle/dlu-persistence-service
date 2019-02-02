using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using  dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class WEBeMailDao: IDisposable
    {

        private DiMPdotNetEntities _entities;

        public WEBeMailDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }


        public string GetWebMailByMail(string email)
        {

            try
            {

                var res = from we in _entities.tblWEBeMails
                    where we.eMail == email
                    select new
                    {
                        we.PersonID, we.eMail, we.PersonNavn
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("GetWebMailByMail " , e.InnerException);
            }
        }


        public string GetWebMailByPersonNavn(string personnavn)
        {
            try
            {
                var res = from we in _entities.tblWEBeMails
                    where we.PersonNavn == personnavn
                    orderby we.PersonNavn
                    select new
                    {
                        we.PersonID, we.eMail, we.PersonNavn
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("GetWebMailByPersonNavn " , e.InnerException);
            }
        }



        public Task<int> CreateOrUpdate(tblWEBeMail mail)
       {
           try
           {
               _entities.tblWEBeMails.AddOrUpdate(mail);

               return _entities.SaveChangesAsync();
           }
           catch (Exception e)
           {
               throw new FormattedDbEntityValidationException(e);
           }
           
        }
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}