using DDF_sql_services;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public List<models.Forspørgelser> GetForspørgelsers()
        {
            var forspørgelser = new List<models.Forspørgelser>();
            var linjer = GetWebForspørgelsesLinjers();
            GetWebForspørgelses().ForEach(se =>
            {
                forspørgelser.Add(new models.Forspørgelser
                {
                    AntalBlade = se.AntalBlade,
                    AntalFarver = se.AntalFarver,
                    Afsluttet = se.Afsluttet,
                    Name = se.Name,
                    AntalIndrykninger = se.AntalIndrykninger,
                    Bemærkning = se.Bemærkning,
                    Type = se.Type,
                    Betegnelse = se.Betegnelse,
                    ForespørgselID = se.ForespørgselID,
                    Format = se.Format,
                    KonsulentCode = se.KonsulentCode,
                    Mediebureau = se.Mediebureau,
                    MedieplanNr = se.MedieplanNr,
                    SvarInden = se.SvarInden,
                    ForspørgelsesLinjer = linjer.Where(ba => ba.ForespørgselID == se.ForespørgselID).ToList()


                });
            });

            return forspørgelser;
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

        public int AfslutForspørgelses(int mediePlanNr)
        {
            try
            {
                devEntities.Database.ExecuteSqlCommand("UPDATE tblWEBForespørgsel SET Afsluttet=1 WHERE MedieplanNr=@MedieplanNr", new SqlParameter("MedieplanNr", mediePlanNr));
               return devEntities.SaveChanges();
            
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdateTableMediePlaneLinjer(int mediePlanNr)
        {
            try
            {
                devEntities.Database.ExecuteSqlCommand("UPDATE tblMedieplanLinjer SET MmPris=tblWEBForespørgselLinjer.BladMmPris, MmRabat=tblWEBForespørgselLinjer.BladMmRabat, FarvePris=tblWEBForespørgselLinjer.BladFarveTillæg, FarveRabat=tblWEBForespørgselLinjer.BladFarveRabat FROM tblWEBForespørgsel INNER JOIN tblWEBForespørgselLinjer ON tblWEBForespørgsel.ForespørgselID = tblWEBForespørgselLinjer.ForespørgselID INNER JOIN tblMedieplanLinjer ON tblWEBForespørgsel.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblWEBForespørgselLinjer.BladID = tblMedieplanLinjer.UgeavisID WHERE (tblMedieplanLinjer.Version = 1) AND (tblWEBForespørgselLinjer.BesvaretAf IS NOT NULL) AND (tblMedieplanLinjer.MedieplanNr=@MedieplanNr)", new SqlParameter("MedieplanNr", mediePlanNr));
                return devEntities.SaveChanges();
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdateTableMediePlanNr(int mediePlanNR)
        {
            try
            {
                devEntities.Database.ExecuteSqlCommand("UPDATE tblMedieplanNr SET OverførtFraPrisforespørgsel = 1 WHERE MedieplanNr=@MedieplanNR", new SqlParameter("MedieplanNR", mediePlanNR));
                return devEntities.SaveChanges();
            } catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdateTableWebForspørgelses(int mediePlandNr)
        {
            try
            {
                devEntities.Database.ExecuteSqlCommand("UPDATE tblWEBForespørgsel SET Afsluttet = 1 WHERE MedieplanNr=@MedieplanNr", new SqlParameter("MedieplanNr", mediePlandNr));
                return devEntities.SaveChanges();
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

           public List<SendRykker> GetForspørgelsers(int forspørgelsesId)
        {
            try
            {
              return  devEntities.Database.SqlQuery<SendRykker>("SELECT tblWEBForespørgselLinjer.BladID, tblBladStamdata.Navn, tblBladStamdata.PrisforespørgselEmails, tblWEBForespørgsel.AntalUdsendinger FROM tblWEBForespørgselLinjer INNER JOIN tblBladStamdata ON tblWEBForespørgselLinjer.BladID = tblBladStamdata.BladID INNER JOIN tblWEBForespørgsel ON tblWEBForespørgselLinjer.ForespørgselID = tblWEBForespørgsel.ForespørgselID WHERE tblWEBForespørgselLinjer.BesvaretAf IS NULL AND tblWEBForespørgsel.ForespørgselID =@ForespørgselID", new SqlParameter("ForespørgselID", forspørgelsesId)).ToList();

            } catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        } 

        public models.PersonId GetPersonId(string email)
        {
            try
            {
                return devEntities.Database.SqlQuery<PersonId>("SELECT PersonID FROM tblWEBeMails WHERE eMail =@email", new SqlParameter("email", email)).FirstOrDefault();
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int InsertTblWebEmails(string email)
        {
            try
            {
                return devEntities.Database.ExecuteSqlCommand("INSERT INTO tblWEBeMails (eMail, PersonNavn) VALUES (@modtager, N)", new SqlParameter("modtager", email));
                
            } catch(SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }


        public int UpdateTableWebForspørgelses(int forespørgselID, int AntalUdsendinger)
        {
            try
            {
                return devEntities.Database.ExecuteSqlCommand("UPDATE tblWEBForespørgsel SET AntalUdsendinger =@AntalUdsendinger + 1  WHERE(ForespørgselID =@forespørgselID)", new SqlParameter("AntalUdsendinger", AntalUdsendinger), new SqlParameter("forespørgselID", forespørgselID));
            }catch(SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdatseAntalUdsendiger(int AntalUdsendinger, int forespørgselID)
        {
            try
            {
                return devEntities.Database.ExecuteSqlCommand("UPDATE tblWEBForespørgsel SET AntalUdsendinger =@AntalUdsendinger + 1  WHERE ForespørgselID =@forespørgselID", new SqlParameter("AntalUdsendinger", AntalUdsendinger), new SqlParameter("forespørgselID", forespørgselID));
            }catch(SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int RunStoredProcedureOpretPrisForspørgelses(Int16 Type, int MedieplanNr, string AnnoncørNo_, string Mediebureau, 
            Int16 AntalBlade, string Format, Int16 AntalFarver, Int16 PlaceringID,Int16 AntalIndrykninger, Boolean VisPlaceringUB,  string Bemærkning)
        {
            try
            {
                return devEntities.Database.ExecuteSqlCommand(" exec OpretForespørgsel   @Type, " +
          "  @MedieplanNr , " +
          "  @AnnoncørNo_ , " +
          "  @Mediebureau , " +
          "  @KonsulentCode ," +
          "  @AntalBlade  ," +
          "  @Format nvarchar(10), " +
          "  @AntalFarver tinyint, " +
          "  @PlaceringID tinyint, " +
          "  @AntalIndrykninger tinyint, " +
          "  @VisPlaceringUB bit, " +
          "  @SvarInden datetime, " +
          "  @Bemærkning nvarchar(2000) ", Type,MedieplanNr,AnnoncørNo_, Mediebureau, AntalBlade, Format, AntalFarver, PlaceringID, AntalIndrykninger, VisPlaceringUB, Bemærkning );
                
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int RunStoredProcedureOpretForspørgelsesLinjer(int ForespørgselID, int BladID,decimal DLUMmPris, double DLUMmRabat, decimal DLUFarveTillæg, float DLUFarveRabat)
        {
            
                try
            {


                return devEntities.Database.ExecuteSqlCommand(" exec OpretForespørgselsLinjer " +
                 "   @ForespørgselID ," +
 "  @BladID  ," +
 "  @DLUMmPris , " +
 "  @DLUMmRabat , " +
 "  @DLUFarveTillæg  ," +
 "  @DLUFarveRabat" , ForespørgselID,  BladID, DLUMmPris, DLUMmRabat, DLUFarveTillæg, DLUFarveRabat);
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
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
