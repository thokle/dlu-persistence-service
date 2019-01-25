using System;
using System.Linq;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;

namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetPostNrListe()
        {
            try
            {
                var postnrs = from ps in _diMPdotNetEntities.tblPostNrs
                    orderby ps.PostNr
                    select new
                    {
                        ps.PostNr, ps.Husstande, ps.PostBy

                    };
                return JsonConvert.SerializeObject(postnrs, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("PostNrTableDao GetPostNrListe " , e.InnerException);
            }
        
    }

        public void Dispose()
        {
            _diMPdotNetEntities?.Dispose();
        }
    }
}