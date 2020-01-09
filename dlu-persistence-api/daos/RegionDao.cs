using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Net.Sockets;
using dlu_persistence_api.exceptions;

using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
    public class RegionDao
    {
        private DiMPdotNetDevEntities _entities;

        public RegionDao()
        {
            _entities = new DiMPdotNetDevEntities();
            
                _entities.Configuration.LazyLoadingEnabled = true;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public List<Regions> GetRegions()
        {
            try
            {
                var res = _entities.tblRegions.SqlQuery("select * from tblRegion").ToList<tblRegion>();
                var regions = new List<Regions>();
                foreach (var d in res)
                {
                    var regiion = new Regions()
                    {
                        RegionId = d.RegionID,
                        RegionNavn1 =  d.RegionNavn,
                        RegionSortId1 = d.RegionSortKey
                    };
                    
                 regions.Add(regiion);
                }

                return regions;
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetRegions ", e.InnerException);
            }

        }

        public Regions GetRegsionById(int regionId)
        {

            try
            {
                var res = (from re in _entities.tblRegions
                    where re.RegionID == regionId
                    select new Regions()
                    {
                         RegionId = re.RegionID,
                         RegionNavn1 = re.RegionNavn,
                        RegionSortId1 = re.RegionSortKey

                    }).Single();

                return res;
            }
            
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }
    }

    public class Regions
     {
         private int RegionID;
         private string RegionNavn;
         private int RegionSortId;


         public int RegionId
         {
             get => RegionID;
             set => RegionID = value;
         }


         public string RegionNavn1
         {
             get => RegionNavn;
             set => RegionNavn = value;
         }

         public int RegionSortId1
         {
             get => RegionSortId;
             set => RegionSortId = value;
         }
     }
}