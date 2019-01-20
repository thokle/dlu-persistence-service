using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class KontaktDao
    {
        private DiMPdotNetEntities _entities;

        public KontaktDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }

        public string GetKontakterPrBlad(int bladid)
        {

            var res = from ko in _entities.tblKontakterPrBlads
                where ko.BladID == bladid
                select new
                {
                    ko.BladID,
                    ko.KontaktID,
                    ko.tblKontakter,
                    ko.tblKontaktFunktioners,
                    
                    kontakter = from t in _entities.tblKontakters where t.KontaktID == ko.KontaktID select  new
                    {
                        t.KontaktID, t.Fornavn, t.Efternavn, t.Email, t.Tlfnr,t.Mobilnr, t.TitelID
                    }

    
                };

            return JsonConvert.SerializeObject(res, Formatting.Indented);

        }


        public string GetKontaktTitler()
        {
            var res = from kt in _entities.tblKontaktTitlers
                orderby kt.Titel
                select new
                {
                    kt.TitelID,
                    kt.Titel
                };
            return JsonConvert.SerializeObject(res, Formatting.Indented);
        }

        public string GetKontakterArbOmråderKontkte()
        {
            var res = from kk in _entities.tblKontaktArbOmråder
                orderby kk.ArbOmråde
                select new
                {
                    kk.ArbOmråde,
                    kk.ArbOmrådeID
                };
            return JsonConvert.SerializeObject(res, Formatting.Indented);
        }
        
        

    }
}