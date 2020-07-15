using Remotion.Linq.Clauses;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class PricesFromWebDao
    {
        private DiMPdotNetDevEntities devEntities;

        public PricesFromWebDao()
        {
            devEntities = new DiMPdotNetDevEntities();
            devEntities.Configuration.LazyLoadingEnabled = true;
        }

        public List<PriceTilWeb> ShowPapersFromStamBladId(string stamBladEmail) {

           
            try
            {
                var res =


                    (from sel in devEntities.tblBladStamdatas
                     where sel.StamdataEmail == stamBladEmail
                     select new PriceTilWeb()
                     {
                         BladID = sel.BladID,
                         Navn = sel.Navn,
                         tempPriser = (from temp in devEntities.tblPrisers
                                       where temp.BladID == sel.BladID & temp.År == DateTime.Now.Year - 1
                                       select new TempWebPriser()
                                       {
                                           BladID = sel.BladID,
                                           Farve4Max = temp.Farve4Max,
                                           Farve4Min = temp.Farve4Min,
                                           Farve4Pris = temp.Farve4Pris,
                                           FarveMax = temp.FarveMax,
                                           FarveMin = temp.FarveMin,
                                           FarvePris = temp.FarvePris,
                                           FormatFra = temp.FormatFra,
                                           FormatTil = temp.FormatTil,
                                           mmPris = temp.mmPris,
                                       PlaceringID = temp.PlaceringID,
                                           year = temp.År,
                                           
                                           PlaceringsNavn = devEntities.tblPlacerings.Select(p => new { p.Betegnelse , p.PlaceringID}).Where(w => w.PlaceringID == temp.PlaceringID).FirstOrDefault().Betegnelse
                                        
                                       }).ToList(),
                        placeringer = (from pl in devEntities.tblPlacerings orderby pl.PlaceringID select new { pl.Betegnelse}).ToList()

                     }).ToList();

                    
                return res;
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);

            }       
        
        }

        public TempWebPriser GetSinglePricwTilWeb(int bladid, int prislisteid, int placerigId, int år)
        {
            return null;
        }

        public Boolean UpdatePrisTilWeb(PriceWebUpdate priceWebUpdate)
        {
            var update = new newPriser();
            update.BladID = priceWebUpdate.BladID;
            update.Farve4Max = priceWebUpdate.Farve4Max;
            update.Farve4Min = priceWebUpdate.Farve4Min;
            update.Farve4Pris = priceWebUpdate.Farve4Pris;
            update.FarveMax = priceWebUpdate.FarveMax;
            update.FarveMin = priceWebUpdate.FarveMin;
            update.FormatFra = priceWebUpdate.FormatFra;
            update.FormatTil = priceWebUpdate.FormatTil;
            update.mmPris = priceWebUpdate.mmPris;
            update.PlaceringID = priceWebUpdate.PlaceringID;
            update.PrislisteID = priceWebUpdate.PrislisteID;
            update.År = priceWebUpdate.År;
            devEntities.newPrisers.AddOrUpdate(update);
        var res =    devEntities.SaveChanges();

            return res == 1 ? true : false;
        }

    }
}
