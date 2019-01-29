using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using  System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class KonkurrenceDaekningDao: IDisposable

    {
    private DiMPdotNetEntities _entities;

    public KonkurrenceDaekningDao()
    {
        using (_entities = new DiMPdotNetEntities())
        {
            _entities.Configuration.LazyLoadingEnabled = true;
        }
    }


        public string GetKomkurrenceDækningPrPostNr(int postnr)
        {
            try
            {
                var res = from k in _entities.tblKonkurrentDækning
                    where k.PostNr == postnr
                    orderby k.PostNr
                    select new
                    {
                        k.PostNr, k.Oplag, k.DækningsGrad
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("GetKomkurrenceDækningPrPostNr ", e.InnerException);
            }
        }

        public string GetKonkurrenceDækningPrDaeknngGrad(int daekg)
        {

            try
            {
                var res = from k in _entities.tblKonkurrentDækning
                    where k.DækningsGrad == daekg
                    orderby k.DækningsGrad
                    select new
                    {
                        k.PostNr, k.Oplag, k.DækningsGrad
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetKonkurrenceDækningPrDaeknngGrad", e.InnerException);
            }

        }

        public Task<int> CreateOrUpdate(tblKonkurrentDækning tblKonkurrentDækning)
        {
            try
            {
                _entities.tblKonkurrentDækning.AddOrUpdate(tblKonkurrentDækning);
                return _entities.SaveChangesAsync();
            }
            catch (DbEntityValidationException e)
            {
                throw new    FormattedDbEntityValidationException(e.InnerException);
            }

            
        }
        
        
        public void Dispose()
        {
           _entities.Dispose();
        }
    }
}