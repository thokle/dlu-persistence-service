using DDF_sql_services;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class WebAnnonceKontrol
    {
        private DiMPdotNetDevEntities devEntities;
        private string sQL1 = "Select tblMedieplan.MedieplanNr As OrdreNr, Case When tblAnnoncekontrol.ErKontrolleret Is NULL Then 0 Else tblAnnoncekontrol.ErKontrolleret End As SlutVist, NavisionContact.Name As Annoncør, tblPlacering.Betegnelse, LTRIM(STR(tblMedieplan.Format1)) + 'x' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, CASE WHEN tblAnnoncekontrol.Fejlkode IS NULL THEN 0 ELSE tblAnnoncekontrol.Fejlkode END AS FejlID, tblMedieplan.Fakturering AS EnOrdre, tblDPKulør.Kulør, NavisionContact.No_ AS AnnoncørID, tblPlacering.PlaceringID AS mmType, tblMedieplanLinjer.UgeavisID AS BladID, tblDPKulør.DPKulørID, tblMedieplan.Version, tblMedieplanLinjer.MedieplanNr, tblMedieplanLinjer.Version AS EXPR2, tblAnnoncekontrol.SidePlacering FROM tblMedieplanLinjer INNER JOIN tblDPKulør INNER JOIN NavisionContact INNER JOIN tblPlacering INNER JOIN tblMedieplan ON tblPlacering.PlaceringID = tblMedieplan.PlaceringID ON NavisionContact.No_ = tblMedieplan.AnnoncørNo_ ON tblDPKulør.DPKulørID = tblMedieplan.DPKulørID INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version LEFT OUTER JOIN tblAnnoncekontrol ON tblMedieplanLinjer.MedieplanNr = tblAnnoncekontrol.MedieplanNr AND tblMedieplanLinjer.UgeavisID = tblAnnoncekontrol.UgeavisID WHERE (tblMedieplan.Status = 3 OR tblMedieplan.Status = 5 OR tblMedieplan.Status = 6 OR tblMedieplan.Status = 99) AND(tblMedieplan.IndrykningsUge = @IndrykningsUge) AND(tblMedieplanLinjer.UgeavisID = @ugeAvisID) AND(tblMedieplan.IndrykningsÅr = @year) ORDER BY OrdreNr";
        private string sQL2 = "SELECT Navn FROM tblBladStamdata WHERE (BladID = @BladID)";
        private string dELETESQL = "DELETE FROM tblAnnoncekontrol WHERE (MedieplanNr =  @OrdreID ) AND (UgeavisID = @BladID )";
     
        private string iNSERTSQL = "INSERT INTO tblAnnoncekontrol (MedieplanNr, UgeavisID, ErKontrolleret, " +
                                      "KontrolTidspunkt, KontrollørEmail, KontrolleretAfDLU, Fejlkode, SidePlacering) " +
                                      "VALUES (@OrdreID , @BladID , 1, " +
                                      "GETDATE(),'@email', @kontrolleretAfDLU,@ErrorID,@SidePlacering )";
      
        private string selectDistinct = "SELECT DISTINCT COUNT(tblMedieplanLinjer.UgeavisID) AS ManglerKontrol FROM " +
                                      "tblMedieplanNr INNER JOIN tblMedieplanLinjer ON tblMedieplanNr.MedieplanNr = tblMedieplanLinjer.MedieplanNr " +
                                      "AND tblMedieplanNr.AktivVersion = tblMedieplanLinjer.Version LEFT OUTER JOIN " +
                                      "tblAnnoncekontrol ON tblMedieplanLinjer.MedieplanNr = tblAnnoncekontrol.MedieplanNr AND " +
                                      "tblMedieplanLinjer.UgeavisID = tblAnnoncekontrol.UgeavisID WHERE " +
                                      "(tblMedieplanNr.MedieplanNr =@OrdreID ) AND " +
                                      "(tblAnnoncekontrol.ErKontrolleret IS NULL OR tblAnnoncekontrol.ErKontrolleret = 0)";

        private string selectCount = "SELECT COUNT(MedieplanNr) AS AntalFejl FROM tblAnnoncekontrol " +
                                          "WHERE(Fejlkode > 0) And (MedieplanNr = @OrdreID )";

        private string selectMediePlan = "SELECT tblMedieplan.Fakturering FROM tblMedieplan INNER JOIN tblMedieplanNr ON " +
                                              "tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion " +
                                              "WHERE(tblMedieplanNr.MedieplanNr = @OrdreID )";

        private string upDateSQL = "UPDATE tblMedieplan SET Status = @Status  FROM tblMedieplan INNER JOIN " +
                    "tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = " +
                    "tblMedieplanNr.AktivVersion WHERE (tblMedieplan.MedieplanNr = @OrdreID )";

        private string upDateSQL1 = "UPDATE tblMedieplanNr SET Status = @Status WHERE(MedieplanNr = @OrdreID )";
        private string upDateSQL2 = "UPDATE tblAnnoncekontrol SET ErKontrolleret = 0  WHERE (MedieplanNr =@OrdreID) AND (UgeavisID =@BladID )";
        public WebAnnonceKontrol()
        {
            using (devEntities = new DiMPdotNetDevEntities()) ;
            devEntities.Configuration.AutoDetectChangesEnabled = true;
        }

        public List<AnnonceKontrolWeb> AnnonceKontrolWebs(int ugeAvisID, int IndrykningsUge, int year)
        {
            try
            {
                return devEntities.Database.SqlQuery<AnnonceKontrolWeb>(sQL1, new SqlParameter("ugeAvisID", ugeAvisID), new SqlParameter("IndrykningsUge", IndrykningsUge), new SqlParameter("year", year)).ToList();
            } catch(SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }

        public List<string> GetAvisNavn(int bladId)
        {
            try
            {

                return devEntities.Database.SqlQuery<string>(sQL2,new SqlParameter("BladID", bladId)).ToList();
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }

        public int Delete(int OrdreID, int BladID)
        {
            try
            {
                return devEntities.Database.ExecuteSqlCommand(dELETESQL, new SqlParameter("OrdreID", OrdreID), new SqlParameter("BladID", BladID));
            } catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }

        public int InsertSQL(int OrdreID, int BladID, string email, Boolean kontrolleretAfDLU, int ErrorID, string SidePlacering)
        {
            //@OrdreID , @BladID , 1, " +
          //  "GETDATE(),'@email', @kontrolleretAfDLU,@ErrorID,@SidePlacering )";//
            try
            {
                return devEntities.Database.ExecuteSqlCommand(iNSERTSQL,new SqlParameter("OrdreID", OrdreID), new SqlParameter("BladID", BladID), new SqlParameter("email", email)
                    , new SqlParameter("kontrolleretAfDLU", kontrolleretAfDLU),new SqlParameter("ErrorID", ErrorID), new SqlParameter("SidePlacering", SidePlacering));
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }

        public int ManglerKontrol(int OrdreID)
        {
            try
            {

                return devEntities.Database.SqlQuery<int>(selectDistinct, new SqlParameter("OrdreID", OrdreID))
                    .ToList().Count;

            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
            

        }

        public int AntaFejl(int OrdreID)
        {

            try
            {
                return devEntities.Database.SqlQuery<int>(selectCount, new SqlParameter("OrdreID", OrdreID)).ToList()
                    .Count;


            }
            catch (SqlException ex)
            {
                throw  new FormattedDbEntityValidationException(ex.InnerException);
                  
            }
        }

        public int SelectFakturing(int OrdreID)
        {

            try
            {
                return devEntities.Database.SqlQuery<int>(selectMediePlan, new SqlParameter("OrdreID", OrdreID)).ToList().Count;
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }


        public int UpdateMediePlan(int Status, int OrdreID)
        {
            try
            {
                return devEntities.Database.ExecuteSqlCommand(upDateSQL, new SqlParameter("Status", Status),
                    new SqlParameter("OrdreID", OrdreID));
            }
            catch (SqlException ex)
            {
                
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }


        public int UpdateMediePlanNr(int Status, int OrdreID)
        {

            try
            {
                return devEntities.Database.ExecuteSqlCommand(upDateSQL1, new SqlParameter("Status", Status),
                    new SqlParameter("OrdreID", OrdreID));
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }

        }


        public int UpdateAnnonceKontrol(int OrdreID, int BladID)
        {

            try
            {
                return devEntities.Database.ExecuteSqlCommand(upDateSQL2, new SqlParameter("OrdreID", OrdreID),
                    new SqlParameter("BladID", BladID));
            }
            catch (SqlException ex)
            {
                throw  new FormattedDbEntityValidationException(ex.InnerException);    
                   
            }
        }


    }
}
