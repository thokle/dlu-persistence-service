using dlu_persistence_api.exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class ForspørgelsesDao
    {
        private DiMPdotNetDevEntities devEntities;

       public ForspørgelsesDao()
        {
            devEntities = new DiMPdotNetDevEntities();
        }

        public List<models.WebForspørgelsesLinjer> GetWebForspørgelsesLinjers()
        {
            try
            {
                return devEntities.Database.SqlQuery<models.WebForspørgelsesLinjer>(ForspørgelsesSQL.WebForspørgelsesLinjerSQL).ToList();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }


        public List<models.WebForspørgelses> GetWebForspørgelses()
        {
            try
            {
                return devEntities.Database.SqlQuery<models.WebForspørgelses>(ForspørgelsesSQL.WebForspørgelseSQL).ToList();
            }catch(SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }

        }

        public List<models.WebForspørgelses> GetWebForspørgelsesByKonsulentCode(string konsulentCode)
        {
            try
            {
                return devEntities.Database.SqlQuery<models.WebForspørgelses>(ForspørgelsesSQL.WebForspørgelsesByKonsulentCodeSQL, new SqlParameter("KonsulentCode", konsulentCode)).ToList();
            } catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

    }

    class ForspørgelsesSQL
    {
        private static string webForspørgelseSQL = "SELECT     tblWEBForespørgsel.ForespørgselID, tblWEBForespørgsel.Type, tblWEBForespørgsel.MedieplanNr, NavisionContact2.Name,  " +
"                      tblWEBForespørgsel.Mediebureau, tblWEBForespørgsel.KonsulentCode, tblWEBForespørgsel.AntalBlade, tblWEBForespørgsel.Format,  " +
"                      tblPlacering.Betegnelse, tblWEBForespørgsel.AntalFarver, tblWEBForespørgsel.AntalIndrykninger, tblWEBForespørgsel.SvarInden, " +
"                      tblWEBForespørgsel.Afsluttet, tblWEBForespørgsel.Bemærkning  " +
"FROM         tblWEBForespørgsel INNER JOIN "+
 "                     tblPlacering ON tblWEBForespørgsel.PlaceringID = tblPlacering.PlaceringID INNER JOIN "+
 "                     NavisionContact2 ON tblWEBForespørgsel.AnnoncørNo_ = NavisionContact2.No_ ";

        private static string webForspørgelsesLinjerSQL = "SELECT tblWEBForespørgselLinjer.ForespørgselID, tblWEBForespørgselLinjer.BladID, tblWEBForespørgselLinjer.DLUMmPris,  "+
"                      tblWEBForespørgselLinjer.DLUMmRabat, tblWEBForespørgselLinjer.DLUFarveTillæg, tblWEBForespørgselLinjer.DLUFarveRabat,  "+
"                      CASE tblWEBForespørgselLinjer.PlaceringUB WHEN 1 THEN 'Side 3,5,7' WHEN 2 THEN 'Høj. side f. midt' WHEN 3 THEN 'Højre side' WHEN 4 THEN 'Nej' "+
"                       ELSE '' END AS PlaceringUdenBeregning, tblWEBForespørgselLinjer.BladMmPris, tblWEBForespørgselLinjer.BladMmRabat,  "+
"                      tblWEBForespørgselLinjer.BladFarveTillæg, tblWEBForespørgselLinjer.BladFarveRabat, tblWEBForespørgselLinjer.BladBemærkning,  "+
"                      tblBladStamdata.Navn, tblWEBeMails.PersonNavn "+
"FROM         tblWEBForespørgselLinjer INNER JOIN "+
"                      tblBladStamdata ON tblWEBForespørgselLinjer.BladID = tblBladStamdata.BladID LEFT OUTER JOIN "+
"                      tblWEBeMails ON tblWEBForespørgselLinjer.BesvaretAf = tblWEBeMails.PersonID ";

        private static string webForspørgelsesByKonsulentCodeSQL = " SELECT     tblWEBForespørgsel.ForespørgselID, tblWEBForespørgsel.Type, tblWEBForespørgsel.MedieplanNr, NavisionContact2.Name,  " +
"                      tblWEBForespørgsel.Mediebureau, tblWEBForespørgsel.KonsulentCode, tblWEBForespørgsel.AntalBlade, tblWEBForespørgsel.Format,  " +
"                      tblPlacering.Betegnelse, tblWEBForespørgsel.AntalFarver, tblWEBForespørgsel.AntalIndrykninger, tblWEBForespørgsel.SvarInden,  " +
"                      tblWEBForespørgsel.Afsluttet, tblWEBForespørgsel.Bemærkning " +
" FROM         tblWEBForespørgsel INNER JOIN " +
"                      tblPlacering ON tblWEBForespørgsel.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
"                      NavisionContact2 ON tblWEBForespørgsel.AnnoncørNo_ = NavisionContact2.No_ " +
" WHERE     (tblWEBForespørgsel.KonsulentCode = @KonsulentCode) ";

        public static string WebForspørgelseSQL { get => webForspørgelseSQL; set => webForspørgelseSQL = value; }
        public static string WebForspørgelsesLinjerSQL { get => webForspørgelsesLinjerSQL; set => webForspørgelsesLinjerSQL = value; }
        public static string WebForspørgelsesByKonsulentCodeSQL { get => webForspørgelsesByKonsulentCodeSQL; set => webForspørgelsesByKonsulentCodeSQL = value; }
   
    
    }
}
