using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
    public class RegionDao
    {
        private DiMPdotNetEntities _entities;

        public RegionDao()
        {
            _entities = new DiMPdotNetEntities();
            
                _entities.Configuration.LazyLoadingEnabled = true;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetRegions()
        {
            try
            {
                var res = _entities.tblRegions.SqlQuery("select * from tblRegion").ToList<tblRegion>();
                var regions = new List<Regioms>();
                foreach (var d in res)
                {
                    var regiion = new Regioms()
                    {
                        RegionId = d.RegionID,
                        RegionNavn1 =  d.RegionNavn,
                        RegionSortId1 = d.RegionSortKey
                    };
                    
                 regions.Add(regiion);
                }

                return JsonConvert.SerializeObject(regions, formatting: Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetRegions ", e.InnerException);
            }

        }
    }

     class Regioms
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