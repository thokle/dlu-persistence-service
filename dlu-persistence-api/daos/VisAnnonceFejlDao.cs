using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class VisAnnonceFejlDao
    {

        private string Sql = "SELECT        CASE WHEN tblMedieplan.Version< 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version))"+
                      "   + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) "+
                     "    WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1)  "+
                     "    + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, tblBladStamdata.Navn, "+
                      "   tblAnnoncekontrol.MedieplanNr, tblMedieplan.Version, NavisionContact.Name AS AnnoncørNo_,  "+
                   "      CASE WHEN tblAnnoncekontrol.Fejlkode = 7 THEN tblFejlTekst.FejlTekst + ' Ny Side: ' + tblAnnoncekontrol.IndrykketPåSide + ' Pris: ' + tblAnnoncekontrol.FaktureresTil "+
                "          ELSE tblFejlTekst.FejlTekst END AS FejlTekst, tblAnnoncekontrol.UgeavisID, tblMedieplan.IndrykningsUge "+
                " FROM            tblMedieplanNr INNER JOIN "+
                          " tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version INNER JOIN "+
                       "   tblAnnoncekontrol INNER JOIN "+
                        "  tblFejlTekst ON tblAnnoncekontrol.Fejlkode = tblFejlTekst.Fejlkode ON tblMedieplanNr.MedieplanNr = tblAnnoncekontrol.MedieplanNr INNER JOIN "+
                        "  NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ INNER JOIN "+
                       "  tblBladStamdata ON tblAnnoncekontrol.UgeavisID = tblBladStamdata.BladID "+
          "  WHERE        (tblAnnoncekontrol.Fejlkode > 0) AND(tblAnnoncekontrol.Ansvar = '') AND(tblMedieplan.Status = 5) ";

        private DiMPdotNetDevEntities entities;

        public VisAnnonceFejlDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public List<VisAnnoceFejl> GetVisAnnoceFejls()
        {
            try
            {
                return entities.Database.SqlQuery<VisAnnoceFejl>(Sql).ToList();

            }catch (SqlException ec)
            {
                throw new FormattedDbEntityValidationException(ec.InnerException);
            }
        }
    }

    
}
