using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using System.Collections.Generic;
namespace dlu_persistence_api.daos
{
    public class PlaceringDao
    {
        private DiMPdotNetDevEntities entities;

        public PlaceringDao()
        {
            entities = new DiMPdotNetDevEntities();
        }


        public List<Placering> GetPlaceringer()
        {
            try
            {
                var res = from pl in entities.tblPlacerings
                          select new Placering
                          {
                             PlaceringID =  pl.PlaceringID,
                            Betegenlse =   pl.Betegnelse
                          };
                return res.ToList<Placering>();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public Task<int> OpretPlacering(tblPlacering tblPlacering)
        {
            try
            {
                tblPlacering.PlaceringID = GetLatestID();
                entities.tblPlacerings.AddOrUpdate(tblPlacering);
                return entities.SaveChangesAsync();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
           
        }

        private byte GetLatestID()
        {
            byte a = 1;
            var res = entities.tblPlacerings.SqlQuery("select top 1 * from tblPlacering as a order  by a.PlaceringID desc").SingleOrDefault();

            var n = res.PlaceringID + a;

            return (byte)n;
        }
    }
}