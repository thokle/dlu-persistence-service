using System;
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
                return devEntities.tblBladStamdatas.Where(w => w.StamdataEmail.Equals(stamBladEmail))
                  .Select(sel => new PriceTilWeb
                  {
                      BladID = sel.BladID,
                      Navn = sel.Navn,
                      tempPriser = devEntities.tempPrisers.Where(tl => tl.BladID == sel.BladID).Select(temp => new TempWebPriser { Farve4Max = temp.Farve4Max, Farve4Min =  temp.Farve4Min ,
                          Farve4Pris =  temp.Farve4Pris, FarveMax = temp.FarveMax ,FarveMin=  temp.FarveMin,                        
                          FarvePris = temp.FarvePris ,
                          FormatFra =  temp.FormatFra,
                          FormatTil=  temp.FormatTil,
                          mmPris=  temp.mmPris,
                          PlaceringID =  temp.PlaceringID ,
                         
                          PrislisteID = temp.PrislisteID, År= temp.År,placeringer = devEntities.tblPlacerings.Where(pl => pl.PlaceringID == temp.PlaceringID).ToList() })
                  }).ToList();         
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);

            }   
         
        
        }

        public Boolean UpdatePrisTilWeb(PriceWebUpdate priceWebUpdate)
        {
            var update = new tempPriser();
            devEntities.tempPrisers.AddOrUpdate(update);
        var res =    devEntities.SaveChanges();

            return res == 1 ? true : false;
        }

    }
}
