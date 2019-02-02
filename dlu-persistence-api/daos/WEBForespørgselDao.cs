using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class WebForespørgselDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public WebForespørgselDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }



        public string GetWebForespørgselByMedieplanNr(int mediePlanNr)
        {
            try
            {
                var res = from we in _entities.tblWEBForespørgsel
                    where we.MedieplanNr == mediePlanNr
                    orderby we.MedieplanNr
                    select new
                    {
                        we.MedieplanNr, we.Afsluttet, we.Bemærkning, we.Format, we.Mediebureau, we.Type, we.AnnoncørNo_, we.AntalBlade, we.AntalFarver, we.AntalIndrykninger,
                        we.AntalUdsendinger, we.KonsulentCode, we.SvarInden, we.ForespørgselID, we.PlaceringID, we.PlaceringUB 
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetWEBForespørgselByMedieplanNr ", e.InnerException);
            }
        }

        public string GetWebForespørgselByAnnoncørNo(string annoncørid)
        {

            try
            {
                var res = from we in _entities.tblWEBForespørgsel
                    where we.AnnoncørNo_ == annoncørid
                    orderby we.AnnoncørNo_
                    select new
                    {
                        we.MedieplanNr, we.Afsluttet, we.Bemærkning, we.Format, we.Mediebureau, we.Type, we.AnnoncørNo_, we.AntalBlade, we.AntalFarver, we.AntalIndrykninger,
                        we.AntalUdsendinger, we.KonsulentCode, we.SvarInden, we.ForespørgselID, we.PlaceringID, we.PlaceringUB 
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetWEBForespørgselByAnnoncørNo ", e.InnerException);
            }
        }

        public string GetWebForespørgselByMediebureau(string burea)
        {
            try
            {
                var res = from we in _entities.tblWEBForespørgsel
                    where we.Mediebureau == burea
                    orderby we.Mediebureau
                    select new
                    {
                        we.MedieplanNr, we.Afsluttet, we.Bemærkning, we.Format, we.Mediebureau, we.Type, we.AnnoncørNo_, we.AntalBlade, we.AntalFarver, we.AntalIndrykninger,
                        we.AntalUdsendinger, we.KonsulentCode, we.SvarInden, we.ForespørgselID, we.PlaceringID, we.PlaceringUB 
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetWEBForespørgselByMediebureau " , e.InnerException);
            }
        }


        public Task<int> CreateOrUpdate(tblWEBForespørgsel forespørgsel)
        {
            try
            {
                _entities.tblWEBForespørgsel.AddOrUpdate(forespørgsel);
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