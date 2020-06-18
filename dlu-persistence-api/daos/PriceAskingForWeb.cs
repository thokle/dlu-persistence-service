using dlu_persistence_api.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class PriceAskingForWeb
    {
        private DiMPdotNetDevEntities devEntities;

        public PriceAskingForWeb()
        {
            devEntities = new DiMPdotNetDevEntities();

            
        }

        public List<PriceAskingWebModel> GetPriceAskingToGrid(string konsulent=null)
        {
            try
            {
                if (!String.IsNullOrEmpty(konsulent))
                {
                    var res = devEntities.Database.SqlQuery<PriceAskingWebModel>("SELECT     tblWEBForespørgsel.ForespørgselID, tblWEBForespørgsel.Type, tblWEBForespørgsel.MedieplanNr, NavisionContact2.Name, " +
                        "  tblWEBForespørgsel.Mediebureau, tblWEBForespørgsel.KonsulentCode, tblWEBForespørgsel.AntalBlade, tblWEBForespørgsel.Format, " +
                        " tblPlacering.Betegnelse, tblWEBForespørgsel.AntalFarver, tblWEBForespørgsel.AntalIndrykninger, tblWEBForespørgsel.SvarInden,  " +
                        " tblWEBForespørgsel.Afsluttet, tblWEBForespørgsel.Bemærkning   " +
                        "   FROM  tblWEBForespørgsel INNER JOIN  " +
                         " tblPlacering ON tblWEBForespørgsel.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
                         " NavisionContact2 ON tblWEBForespørgsel.AnnoncørNo_ = NavisionContact2.No_ " +
                     " WHERE(tblWEBForespørgsel.KonsulentCode = @KonsulentCode)", new SqlParameter("KonsulentCode", konsulent)).ToList<PriceAskingWebModel>();

                    return res;
                } else
                {
                    var res = devEntities.Database.SqlQuery<PriceAskingWebModel>("SELECT     tblWEBForespørgsel.ForespørgselID, tblWEBForespørgsel.Type, tblWEBForespørgsel.MedieplanNr, NavisionContact2.Name, " +
                     "  tblWEBForespørgsel.Mediebureau, tblWEBForespørgsel.KonsulentCode, tblWEBForespørgsel.AntalBlade, tblWEBForespørgsel.Format, " +
                     " tblPlacering.Betegnelse, tblWEBForespørgsel.AntalFarver, tblWEBForespørgsel.AntalIndrykninger, tblWEBForespørgsel.SvarInden,  " +
                     " tblWEBForespørgsel.Afsluttet, tblWEBForespørgsel.Bemærkning   " +
                     "   FROM  tblWEBForespørgsel INNER JOIN  " +
                      " tblPlacering ON tblWEBForespørgsel.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
                      " NavisionContact2 ON tblWEBForespørgsel.AnnoncørNo_ = NavisionContact2.No_ ").ToList<PriceAskingWebModel>();

                    return res;
                }
            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
          
            /**/



        }
    }
}
