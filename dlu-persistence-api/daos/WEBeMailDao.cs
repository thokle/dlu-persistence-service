using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class WEBeMailDao
    {

        private DiMPdotNetDevEntities _entities;

        public WEBeMailDao()
        {
            _entities = new DiMPdotNetDevEntities();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetWebMailByMail(string email)
        {

            try
            {

                var res = from we in _entities.tblWEBeMails
                          where we.eMail == email
                          select new
                          {
                              we.PersonID,
                              we.eMail,
                              we.PersonNavn
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetWebMailByMail ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personnavn"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetWebMailByPersonNavn(string personnavn)
        {
            try
            {
                var res = from we in _entities.tblWEBeMails
                          where we.PersonNavn == personnavn
                          orderby we.PersonNavn
                          select new
                          {
                              we.PersonID,
                              we.eMail,
                              we.PersonNavn
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetWebMailByPersonNavn ", e.InnerException);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        /// <exception cref="FormattedDbEntityValidationException"></exception>
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