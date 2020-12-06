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
    class SkalSendesDao
    {
        

        private string SQL = " SELECT        CASE WHEN viewOversigt.Version < 10 THEN LTRIM(STR(viewOversigt.MedieplanNr)) + '-' + LTRIM(STR(viewOversigt.Version)) WHEN viewOversigt.Version > 10 AND  " +
"                         viewOversigt.Version < 100 THEN LTRIM(STR(viewOversigt.MedieplanNr)) + '-' + RIGHT(LTRIM(viewOversigt.Version / 10), 1) + '-' + RIGHT(LTRIM(viewOversigt.Version), 1) " +
"                         WHEN viewOversigt.Version > 100 THEN LTRIM(STR(viewOversigt.MedieplanNr)) + '-' + RIGHT(LTRIM(viewOversigt.Version / 100), 1) + '-' + RIGHT(LTRIM(viewOversigt.Version / 10), 1) + '-' + RIGHT(LTRIM(viewOversigt.Version), " +
"                         1) END AS Nr, viewOversigt.MedieplanNr, viewOversigt.Version, " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact " +
"                               WHERE        (No_ = viewOversigt.AnnoncørNo_)) AS AnnoncørNo_, " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS NavisionContact_1 " +
"                               WHERE        (No_ = viewOversigt.BureauNo_)) AS BureauNo_, viewOversigt.Format, viewOversigt.AntalFarver, viewOversigt.IndrykningsUge, viewOversigt.OrdreUdsendt, viewOversigt.MaterialeFra, " +
"                         viewOversigt.MaterialeUdsendt, viewOversigt.KonsulentCode AS OrdreAnsvarlig, " +
"                             (SELECT        [Salesperson Code] " +
"                               FROM            NavisionContact AS NavisionContact_2 " +
"                               WHERE        (No_ = viewOversigt.AnnoncørNo_)) AS SalgsAnsvarlig, viewOversigt.Overskrift, viewOversigt.Deadline, tblMedieplanNr.Kommentar " +
" FROM            viewOversigt INNER JOIN " +
"                         tblMedieplanNr ON viewOversigt.MedieplanNr = tblMedieplanNr.MedieplanNr ";

        private string SQL2 = " SELECT        (SELECT        Name " +
"                          FROM            NavisionContact " +
"                          WHERE        (No_ = viewOversigt.AnnoncørNo_)) AS AnnoncørNo_, viewOversigt.AntalFarver, " +
"                             (SELECT        Name  " +
"                               FROM            NavisionContact AS NavisionContact_1 " +
"                               WHERE        (No_ = viewOversigt.BureauNo_)) AS BureauNo_, viewOversigt.Format, viewOversigt.IndrykningsUge, viewOversigt.KonsulentCode AS OrdreAnsvarlig,  " +
"                         viewOversigt.MaterialeFra, viewOversigt.MaterialeUdsendt, viewOversigt.MedieplanNr, " +
"                         CASE WHEN viewOversigt.Version < 10 THEN LTRIM(STR(viewOversigt.MedieplanNr)) + '-' + LTRIM(STR(viewOversigt.Version)) WHEN viewOversigt.Version > 10 AND " +
"                          viewOversigt.Version < 100 THEN LTRIM(STR(viewOversigt.MedieplanNr)) + '-' + RIGHT(LTRIM(viewOversigt.Version / 10), 1)  " +
"                         + '-' + RIGHT(LTRIM(viewOversigt.Version), 1) WHEN viewOversigt.Version > 100 THEN LTRIM(STR(viewOversigt.MedieplanNr)) " +
"                         + '-' + RIGHT(LTRIM(viewOversigt.Version / 100), 1) + '-' + RIGHT(LTRIM(viewOversigt.Version / 10), 1) + '-' + RIGHT(LTRIM(viewOversigt.Version), 1) END AS Nr, " +
"                         viewOversigt.OrdreUdsendt, viewOversigt.Overskrift, " +
"                             (SELECT        [Salesperson Code]  " +
"                               FROM            NavisionContact AS NavisionContact_2  " +
"                               WHERE        (No_ = viewOversigt.AnnoncørNo_)) AS SalgsAnsvarlig, viewOversigt.Version, viewOversigt.Deadline, tblMedieplanNr.Kommentar " +
" FROM            viewOversigt INNER JOIN  " +
"                         tblMedieplanNr ON viewOversigt.MedieplanNr = tblMedieplanNr.MedieplanNr  " +
"  WHERE        (viewOversigt.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut)   " +
"  ORDER BY viewOversigt.IndrykningsUge  ";

        private DiMPdotNetDevEntities entities;

        public SkalSendesDao()
        {

            entities = new DiMPdotNetDevEntities();
        }


        public List<models.SkalSendes> SkaSendes()
        {
            try
            {
                return entities.Database.SqlQuery<SkalSendes>(SQL).ToList();

            } catch (FormattedDbEntityValidationException ex)
            {

                throw new Exception(ex.HelpLink);
            }

        }

        public List<models.SkalSendes> SkalSendesByUge(int fraUge, int tilUge)
        {
            try
            {
                return entities.Database.SqlQuery<SkalSendes>(SQL2, new SqlParameter("UgeStart", fraUge), new SqlParameter("UgeSlut", tilUge)).ToList();
            }catch (FormattedDbEntityValidationException ex)
            {
                throw new Exception(ex.HelpLink);
            }
        }


    }
}
