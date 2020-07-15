using dlu_persistence_api.models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class OmsaetningDao
    {
        private DiMPdotNetDevEntities entities;

        public OmsaetningDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public List<Omsaetning> GetOmsaetnings(int år, byte fraUge, byte tilUge)
        {
            try
            {
                return entities.Database.SqlQuery<Omsaetning>("SELECT  CASE WHEN NavisionContact.ContactNoFilter <> '' THEN (SELECT NavCon.Name FROM NavisionContact NavCon WHERE NavCon.No_ = NavisionContact.ContactNoFilter) ELSE NavisionContact.Name END AS Annoncør, NavisionContact2.Name AS Bureau, tblBladStamdata.Navn AS Ugeavis, tblDelOmråde.DelOmrådeKode,  " +
                 "     tblDelOmråde.DelOmrådeSortKey, tblHovedGruppe.HovedGruppeNavn, tblHovedGruppe.HovedGruppeSortKey, tblGeoKode.GeoKodeNavn, " +
                 "     tblGeoKode.GeoKodeSortKey, Salesperson.Name AS Konsulent, CASE WHEN IndrykningsÅr = @År THEN tblMedieplanLinjer.Mm ELSE 0 END AS MmÅrNy, " +
                 "     CASE WHEN IndrykningsÅr = @År - 1 THEN tblMedieplanLinjer.Mm ELSE 0 END AS MmÅrGammel, " +
                  "    CASE WHEN IndrykningsÅr = @År THEN tblMedieplanLinjer.Total ELSE 0 END AS PrisÅrNy, " +
                 "     CASE WHEN IndrykningsÅr = @År - 1 THEN tblMedieplanLinjer.Total ELSE 0 END AS PrisÅrGammel, tblMedieplan.IndrykningsUge, tblMedieplan.IndrykningsÅr, " +
                 "     tblBladStamdata.Ejerforhold, CASE WHEN tblAnnoncekontrol.SidePlacering IS NULL THEN 0 ELSE tblAnnoncekontrol.SidePlacering END AS SidePlaceringen, CASE WHEN IndrykningsÅr = @År THEN tblMedieplanLinjer.MiljøTillæg ELSE 0 END AS MiljøTillægNy, CASE WHEN IndrykningsÅr = @År - 1 THEN tblMedieplanLinjer.MiljøTillæg ELSE 0 END AS MiljøTillægGammel, CASE WHEN IndrykningsÅr = @År THEN CASE WHEN tblMedieplan.SikkerhedsGodt = 1 THEN CASE WHEN tblMedieplan.InfoGodt = 1 THEN tblMedieplanLinjer.TotalInclTillæg * 0.02 ELSE tblMedieplanLinjer.TotalInclTillæg * 0.01 END ELSE CASE WHEN tblMedieplan.InfoGodt = 1 THEN tblMedieplanLinjer.TotalInclTillæg * 0.01 ELSE 0 END END END AS GodtgørelseNy, CASE WHEN IndrykningsÅr = @År - 1 THEN CASE WHEN tblMedieplan.SikkerhedsGodt = 1 THEN CASE WHEN tblMedieplan.InfoGodt = 1 THEN tblMedieplanLinjer.TotalInclTillæg * 0.02 ELSE tblMedieplanLinjer.TotalInclTillæg * 0.01 END ELSE CASE WHEN tblMedieplan.InfoGodt = 1 THEN tblMedieplanLinjer.TotalInclTillæg * 0.01 ELSE 0 END END END AS GodtgørelseGammel, CASE WHEN IndrykningsÅr = @År THEN 1 ELSE 0 END AS AntalIndrykningerNy, CASE WHEN IndrykningsÅr = @År - 1 THEN 1 ELSE 0 END AS AntalIndrykningerGammel, LTRIM(STR(dbo.tblMedieplan.Format1)) + ' x ' + LTRIM(STR(dbo.tblMedieplan.Format2)) AS Format " +
                  "   FROM            tblBladStamdata INNER JOIN  " +
                 "     tblDelOmråde ON tblBladStamdata.DelOmrådeID = tblDelOmråde.DelOmrådeID INNER JOIN " +
                  "    tblGeoKode ON tblBladStamdata.GeoKodeID = tblGeoKode.GeoKodeID INNER JOIN " +
                   "   tblHovedGruppe ON tblBladStamdata.HovedgruppeID = tblHovedGruppe.HovedGruppeID INNER JOIN " +
                 "     tblMedieplanLinjer ON tblBladStamdata.BladID = tblMedieplanLinjer.UgeavisID INNER JOIN " +
                  "    tblMedieplan ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version INNER JOIN " +
                  "    tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN " +
                  "    NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ INNER JOIN " +
                 "     Salesperson ON NavisionContact.[Salesperson Code] = Salesperson.Code LEFT OUTER JOIN " +
                 "     tblAnnoncekontrol ON tblMedieplanLinjer.MedieplanNr = tblAnnoncekontrol.MedieplanNr AND " +
                  "    tblMedieplanLinjer.UgeavisID = tblAnnoncekontrol.UgeavisID LEFT OUTER JOIN " +
                   "   NavisionContact2 ON tblMedieplan.BureauNo_ = NavisionContact2.No_" +
                   "  WHERE(tblMedieplan.Status = 3 OR " +
                    "  tblMedieplan.Status > 4) AND(tblMedieplan.IndrykningsÅr = @År OR " +
                    "  tblMedieplan.IndrykningsÅr = @År - 1) AND(tblMedieplan.IndrykningsUge BETWEEN @FraUge AND @TilUge)", new SqlParameter("År", år), new SqlParameter("FraUge", fraUge), new SqlParameter("TilUge", tilUge)).ToList();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
         
        }

    }

   
}
