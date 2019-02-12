 using System;
 using System.ComponentModel.Design;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{/// <summary>
 /// 
 /// </summary>
    public class FakuraFejlTekstDao
    {
        private DiMPdotNetEntities _entities;

        public FakuraFejlTekstDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public  string GetFejlTekster()
        {
            try
            {
                var res = from fm in _entities.tblFakturaFejlTeksts
                    orderby fm.FejlTekst
                    select new
                    {
                        fm.FejlTekst, fm.FejlKode

                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetFejlTekster", e.InnerException);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblFakturaFejlTekst"></param>
        /// <returns></returns>
        /// <exception cref="FormattedDbEntityValidationException"></exception>
        public Task<int> CreateOrUpDate(tblFakturaFejlTekst tblFakturaFejlTekst)
        {
            try
            {
                _entities.tblFakturaFejlTeksts.AddOrUpdate(tblFakturaFejlTekst);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new  FormattedDbEntityValidationException(e.InnerException);
            }
        }
    }
}