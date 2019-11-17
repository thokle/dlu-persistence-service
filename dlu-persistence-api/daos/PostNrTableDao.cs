using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net.Sockets;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

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
        public List<PostNrModel> GetPostNrListe()
        {
            try
            {
                var postnrs = from ps in _diMPdotNetEntities.tblPostNrs
                              orderby ps.PostNr ascending
                              select new PostNrModel()
                              {
                                  PostNr = ps.PostNr,
                                  Hustande = ps.Husstande,
                                  PostBy = ps.PostBy

                              };
                return postnrs.ToList<PostNrModel>();
            }
            catch (Exception e)
            {
                throw new Exception(e.HelpLink);
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
        
        public int CheckIfPostNrExist(int postnr)
        {
            int returnValue = 0;
            var res = (from p in _diMPdotNetEntities.tblPostNrs
                       where p.PostNr == postnr
                       select new PostNrModel()
                       {
                           Hustande = p.Husstande, PostBy =  p.PostBy, PostNr =p.PostNr
                       });

            if ((int)res.Count() > 0)
            {
                returnValue =  1;
            } else if (res.Count() < 1)
            {
                returnValue =  0;
            }
            return returnValue;     
        }
       
        public int AddOrUpdate(tblPostNr tbl)
        {
            _diMPdotNetEntities.tblPostNrs.AddOrUpdate(tbl);
            return _diMPdotNetEntities.SaveChanges();
        }
    }
}