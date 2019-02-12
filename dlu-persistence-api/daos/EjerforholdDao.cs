using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class EjerforholdDao: IDisposable

    {
    private DiMPdotNetEntities _entities;

    public EjerforholdDao()
    {
        using (_entities = new DiMPdotNetEntities())
        {
            _entities.Configuration.LazyLoadingEnabled = true;
        }
        
    }

        public string GetEjerForholdName(string name)
        {

            try
            {
                var res = from ej in _entities.tblEjerforholds
                    where ej.Ejerforhold == name orderby ej.Ejerforhold
                    select new
                    {
                        ej.Ejerforhold, ej.EjerforholdID, ej.WebTillægRubrik, ej.WebTillægTekst 
                        
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetEjerForholdName", e.InnerException);
            }

        }

        public Task<int> OpretEjerforhold(tblEjerforhold tblEjerforhold)
        {
            try
            {
                _entities.tblEjerforholds.AddOrUpdate(tblEjerforhold);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }
 
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}