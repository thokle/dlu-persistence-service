using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class ErSendtDao
    {
        private DiMPdotNetDevEntities entities;

        public ErSendtDao()
        {
            entities = new DiMPdotNetDevEntities();
        }


        public List<models.SkalSendes> GetAllSkalSendes()
        {
            try
            {
                return entities.Database.SqlQuery<models.SkalSendes>("SELECT        CASE WHEN viewOrdreErSendt.Version < 10 THEN LTRIM(STR(viewOrdreErSendt.MedieplanNr)) + '-' + LTRIM(STR(viewOrdreErSendt.Version)) WHEN viewOrdreErSendt.Version > 10 AND  " +
                        " viewOrdreErSendt.Version < 100 THEN LTRIM(STR(viewOrdreErSendt.MedieplanNr)) + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version / 10), 1) + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version), 1) " +
                         " WHEN viewOrdreErSendt.Version > 100 THEN LTRIM(STR(viewOrdreErSendt.MedieplanNr)) + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version / 100), 1) + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version / 10), 1) " +
                         " + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version), 1) END AS Nr, MedieplanNr, Version, " +
                         "     (SELECT        Name " +
                          "      FROM            NavisionContact " +
                           "     WHERE(No_ = viewOrdreErSendt.AnnoncørNo_)) AS AnnoncørNo_, " +
                         "     (SELECT        Name " +

                    "    FROM            NavisionContact AS NavisionContact_1 " +

                      "  WHERE(No_ = viewOrdreErSendt.BureauNo_)) AS BureauNo_, Format, AntalFarver, IndrykningsUge, OrdreUdsendt, MaterialeFra, MaterialeUdsendt, KonsulentCode AS OrdreAnsvarlig, " +
                       "       (SELECT[Salesperson Code] " +

             "   FROM            NavisionContact AS NavisionContact_2 " +

              " WHERE(No_ = viewOrdreErSendt.AnnoncørNo_)) AS SalgsAnsvarlig " +
 " FROM viewOrdreErSendt").ToList(); 
            } catch(Exception ex)
            {
                throw new exceptions.FormattedDbEntityValidationException(ex.InnerException);
            }
        }

        public List<models.SkalSendes> GetSkalSendesFraUgeTilUge(int fraUge, int tilUge)
        {
            try
            {
                return entities.Database.SqlQuery<models.SkalSendes>("SELECT        CASE WHEN viewOrdreErSendt.Version < 10 THEN LTRIM(STR(viewOrdreErSendt.MedieplanNr)) + '-' + LTRIM(STR(viewOrdreErSendt.Version)) WHEN viewOrdreErSendt.Version > 10 AND  " +
                        "  viewOrdreErSendt.Version < 100 THEN LTRIM(STR(viewOrdreErSendt.MedieplanNr)) + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version / 10), 1) + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version), 1) " +
                     "    WHEN viewOrdreErSendt.Version > 100 THEN LTRIM(STR(viewOrdreErSendt.MedieplanNr)) + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version / 100), 1) + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version / 10), 1) " +
                      "    + '-' + RIGHT(LTRIM(viewOrdreErSendt.Version), 1) END AS Nr, " +
                       "       (SELECT        Name " +
                       "        FROM            NavisionContact " +
                         "      WHERE(No_ = viewOrdreErSendt.AnnoncørNo_)) AS AnnoncørNo_, AntalFarver, " +
                       "      (SELECT        Name " +

                    "   FROM            NavisionContact AS NavisionContact_1 " +

                    "   WHERE(No_ = viewOrdreErSendt.BureauNo_)) AS BureauNo_, Format, IndrykningsUge, KonsulentCode AS OrdreAnsvarlig, MaterialeFra, MaterialeUdsendt, MedieplanNr, OrdreUdsendt, " +
                     "        (SELECT[Salesperson Code] " +

            "   FROM            NavisionContact AS NavisionContact_2 " +

             "  WHERE(No_ = viewOrdreErSendt.AnnoncørNo_)) AS SalgsAnsvarlig, Version" +
  " FROM viewOrdreErSendt " +
" WHERE(IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) " +
 "ORDER BY IndrykningsUge DESC", new SqlParameter("UgeStart", fraUge), new SqlParameter("UgeSlut", tilUge)).ToList();
            }catch(Exception ex)
            {
                throw new exceptions.FormattedDbEntityValidationException(ex.InnerException);
            }
        }
    }
}
