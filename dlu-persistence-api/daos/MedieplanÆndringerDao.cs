using System;

using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using System.Collections.Generic;
namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class MedieplanÆndringerDao: IDisposable
    {
        private DiMPdotNetDevEntities _entities;

        public MedieplanÆndringerDao()
        {
            _entities = new DiMPdotNetDevEntities();
 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediePlan"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public List<AenderingsTekst> GetMediePlanÆndringerByMedieId(int mediePlan, int  version)
        {
            try
            {
                var res = from m in _entities.tblMedieplanÆndringer
                    where m.MedieplanNr == mediePlan & m.Version == version
                    select new AenderingsTekst
                    {
                       MedieplanNr =  m.MedieplanNr,Version = m.Version, AendringsTekst= m.ÆndringsTekst
                    };

                return res.ToList();
            }
            catch (Exception e)
            {
                throw new DaoExceptions("MedieplanÆndringerDao GetMediePlanÆndringerByMedieId " , e.InnerException);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblMedieplanÆndringer"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public int CreateOrUpdate(tblMedieplanÆndringer tblMedieplanÆndringer)
        {
            try
            {
                _entities.tblMedieplanÆndringer.AddOrUpdate(tblMedieplanÆndringer);
                return _entities.SaveChanges();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}