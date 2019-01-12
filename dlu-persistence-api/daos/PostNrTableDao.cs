using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class PostNrTableDao: IDisposable
    {
        private DiMPdotNetEntities _diMPdotNetEntities;


        public PostNrTableDao()
        {
            using (_diMPdotNetEntities = new DiMPdotNetEntities())
            {
                _diMPdotNetEntities.Configuration.LazyLoadingEnabled = true;
            }
        }


        public string GetPostNrListe()
        {

            var postnrs = from ps in _diMPdotNetEntities.tblPostNrs
                orderby ps.PostNr
                select new
                {


                };
            return JsonConvert.SerializeObject(postnrs, Formatting.Indented);
        }

        public void Dispose()
        {
            _diMPdotNetEntities?.Dispose();
        }
    }
}