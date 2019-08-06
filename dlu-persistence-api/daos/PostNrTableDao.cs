using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net.Sockets;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;

namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
    public class PostNrTableDao
    {
        private DiMPdotNetDevEntities _diMPdotNetEntities;


        public PostNrTableDao()
        {
            _diMPdotNetEntities = new DiMPdotNetDevEntities();
            
                _diMPdotNetEntities.Configuration.LazyLoadingEnabled = true;
            
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
                    orderby ps.PostBy
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

        public string GetPostNrAfByNavn(string bynavn)
        {
            try
            {

                var res = from ps in _diMPdotNetEntities.tblPostNrs
                    where ps.PostBy.Equals(bynavn)
                    orderby ps.PostBy
                    select new
                    {
                        ps.PostNr
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetPostNrAfByNavn " , e.InnerException);
            }
        }


        public string GetByBYPostNr(int postnr)
        {
            try
            {

                var res = from ps in _diMPdotNetEntities.tblPostNrs
                    where ps.PostNr == postnr
                    orderby ps.PostBy
                    select new
                    {
                        ps.PostBy, ps.PostNr,ps.MaxDækningsGrad
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetByBYPostNr " , e.InnerException);
            }   
        }

        public void Dispose()
        {
            _diMPdotNetEntities?.Dispose();
        }
    }
}