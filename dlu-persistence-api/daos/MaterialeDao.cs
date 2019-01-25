using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class MaterialeDao : IDisposable
    {
        private DiMPdotNetEntities _entities;

        public MaterialeDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetMaterialeByMediaNr(int ma)
        {
            try
            {
                var res = from m in _entities.tblMateriales
                    where m.MedieplanNr == ma
                    select new
                    {
                        m.MedieplanNr, m.ErSendt, m.FilNavn, m.FilSti, m.SkalSendes, m.UgeavisID

                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions(" MaterialeDao GetMaterialeByMediaNr  ", e.InnerException);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblMateriale"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Task<int> CreateMateriale(tblMateriale tblMateriale)
        {
            try
            {
                _entities.tblMateriales.AddOrUpdate(tblMateriale);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new DaoExceptions(" MaterialeDao CreateMateriale ", e.InnerException );
            }
        }

        public void Dispose()
        {
            _entities.Dispose();
        }
    }
}