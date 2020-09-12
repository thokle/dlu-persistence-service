using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    internal class SQLStringsUtil
    {

        private static string sQL = "SELECT  TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version))  "
                  + "  WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1)  + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) "
                 + "   + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
                 "   CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR "
                  + "  tblMedieplan.KontaktpersonTilhører = 2 THEN "
                  + "    (SELECT   Name  FROM   NavisionContact AS Contact1 "
                  + "       WHERE(No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN "
                  + "      (SELECT    Name   FROM            NavisionContact AS Contact1 "
                  + "       WHERE(No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, "
                + "    CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN "
                + "   (SELECT   Name  FROM     NavisionContact AS Contact2 "
                   + "     WHERE(No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN "
                   + "   (SELECT   Name FROM            NavisionContact AS Contact2 "
                   + "    WHERE(No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse, "
                 + "   LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) "
                 + "  AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, "
                 + "   tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "
                + "       (SELECT[Salesperson Code] "
                   + "      FROM            NavisionContact "
                + "      WHERE(No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato "
           + " FROM   tblMedieplan INNER JOIN "
         + "   tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN "
                 + "    tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version "
+ "  GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge,  "
                  + " tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr,  "
                  + " tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol,  "
                  + " tblMedieplan.OprettetDato "
+ "  ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";


        private static string sQL2 = " SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version))  " +
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1)  " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR " +
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_,  " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse,  " +
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID)  " +
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, " +
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                             (SELECT        [Salesperson Code] " +
"                               FROM            NavisionContact " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato " +
" FROM            tblMedieplan INNER JOIN " +
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version " +
" WHERE        (tblMedieplan.AnnoncørNo_ = @AnnoncørNo) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND  " +
"                         (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR " +
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) " +
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge,  " +
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr,  " +
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                         tblMedieplan.OprettetDato " +
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL3 = " SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version))  " +
        "                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1)  " +
        "                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr))  " +
        "                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
        "                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR " +
        "                         tblMedieplan.KontaktpersonTilhører = 2 THEN " +
        "                             (SELECT        Name " +
        "                               FROM            NavisionContact AS Contact1 " +
        "                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN " +
        "                             (SELECT        Name " +
        "                               FROM            NavisionContact AS Contact1 " +
        "                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_,  " +
        "                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN " +
        "                             (SELECT        Name " +
        "                               FROM            NavisionContact AS Contact2 " +
        "                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN " +
        "                             (SELECT        Name " +
        "                               FROM            NavisionContact AS Contact2 " +
        "                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse,  " +
        "                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID)  " +
        "                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, " +
        "                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
        "                             (SELECT        [Salesperson Code] " +
        "                               FROM            NavisionContact " +
        "                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato " +
        " FROM            tblMedieplan INNER JOIN " +
        "                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
        "                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version " +
        " WHERE        (tblMedieplan.AnnoncørNo_ = @AnnoncørNo) AND (tblMedieplan.BureauNo_ = @BureauNo) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND  " +
        "                         @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND  " +
        "                         (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR " +
        "                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) " +
        " GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge,  " +
        "                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr,  " +
        "                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol,  " +
        "                         tblMedieplan.OprettetDato " +
        " ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL4 = "SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version))  "+ 
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1)  "+
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) "+
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR "+
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name " + 
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_,  "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse,  "+
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID)  "+
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version,   "+
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                             (SELECT        [Salesperson Code] "+
"                               FROM            NavisionContact "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato "+
"FROM            tblMedieplan INNER JOIN "+
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN "+
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version "+
"WHERE        (tblMedieplan.AnnoncørNo_ = @AnnoncørNo) AND (tblMedieplan.BureauNo_ = @BureauNo) AND (tblMedieplan.KonsulentCode = @KonsulentCode) AND  "+
"                         (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND (tblMedieplan.Version BETWEEN  "+
"                         @VersionFra AND @VersionTil) AND (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR "+
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) " +
"GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge,  "+
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr,  "+
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol,  "+
"                         tblMedieplan.OprettetDato "+
"ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL5 = "SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) "+
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) "+
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) "+
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR "+
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_,  "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse,  "+
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID)  "+
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, "+
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                             (SELECT        [Salesperson Code] "+
"                               FROM            NavisionContact  "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato "+
" FROM            tblMedieplan INNER JOIN "+
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN "+
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version INNER JOIN "+
"                         tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion "+
" WHERE        (tblMedieplan.AnnoncørNo_ = @AnnoncørNo) AND (tblMedieplan.BureauNo_ = @BureauNo) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND "+
"                         @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND (tblMedieplanLinjer.UgeavisID = @UgeavisID) AND (tblMedieplan.Version BETWEEN @VersionFra AND "+
"                         @VersionTil) AND (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR "+
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) "+
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge, "+
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr, "+
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                         tblMedieplan.OprettetDato "+
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL6 = " SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) " +
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR " +
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse, "+
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) "+
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, "+
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                             (SELECT        [Salesperson Code] "+
"                               FROM            NavisionContact "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato "+
" FROM            tblMedieplan INNER JOIN "+
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN "+
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version "+
" WHERE        (tblMedieplan.AnnoncørNo_ = @AnnoncørNo) AND (tblMedieplan.KonsulentCode = @KonsulentCode) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND "+
"                         @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND "+
"                         (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR "+
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) "+
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge, "+
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr, "+
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                         tblMedieplan.OprettetDato "+
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL7 = "SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) " +
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR " +
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse, " +
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) " +
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, " +
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                             (SELECT        [Salesperson Code] " +
"                               FROM            NavisionContact " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato " +
" FROM            tblMedieplan INNER JOIN " +
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version INNER JOIN " +
"                         tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion " +
" WHERE        (tblMedieplan.AnnoncørNo_ = @AnnoncørNo) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND " +
"                         (tblMedieplanLinjer.UgeavisID = @UgeavisID) AND (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND " +
"                         (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR " +
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) " +
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge, " +
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr, " +
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                         tblMedieplan.OprettetDato " +
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version  ";

        private static string sQL8 = " SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) "+
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) "+
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) "+
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR "+
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse, "+
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) "+
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, "+
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                             (SELECT        [Salesperson Code] "+
"                               FROM            NavisionContact "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato "+
" FROM            tblMedieplan INNER JOIN "+
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN "+
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version "+
" WHERE        (tblMedieplan.BureauNo_ = @BureauNo) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND "+
"                         (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR "+
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) "+
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge, "+
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr, "+
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                         tblMedieplan.OprettetDato "+
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

private static string sQL9 = "SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) " +
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR " +
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse, " +
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) " +
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, " +
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol," +
"                             (SELECT        [Salesperson Code] " +
"                               FROM            NavisionContact " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato " +
"  FROM            tblMedieplan INNER JOIN " +
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version " +
" WHERE        (tblMedieplan.BureauNo_ = @BureauNo) AND (tblMedieplan.KonsulentCode = @KonsulentCode) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND " +
"                         @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND " +
"                         (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR " +
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) " +
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge, " +
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr, " +
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                         tblMedieplan.OprettetDato " +
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL10 = "SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) " +
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR " +
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse, " +
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) " +
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, " +
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                             (SELECT        [Salesperson Code] " +
"                               FROM            NavisionContact " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato " +
" FROM            tblMedieplan INNER JOIN " +
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version INNER JOIN " +
"                         tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion " +
" WHERE        (tblMedieplan.BureauNo_ = @BureauNo) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND " +
"                         (tblMedieplanLinjer.UgeavisID = @UgeavisID) AND (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND " +
"                         (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR " +
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) " +
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge, " +
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr, " +
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                         tblMedieplan.OprettetDato " +
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL11 = "SELECT DISTINCT  "+
"                         CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) WHEN tblMedieplan.Version > 10 AND "+
"                          tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) "+
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) "+
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR "+
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact1 "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, "+
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN "+
"                             (SELECT        Name  "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN "+
"                             (SELECT        Name "+
"                               FROM            NavisionContact AS Contact2 "+
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse, "+
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) "+
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, "+
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                             (SELECT        [Salesperson Code] "+
"                               FROM            NavisionContact "+
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato  "+
" FROM            tblMedieplan INNER JOIN " +
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN "+
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version INNER JOIN "+
"                         tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion "+
" WHERE        (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND "+
"                         (tblMedieplanLinjer.BureauOrdreNr = @BureauOrdreNr) OR "+
"                         (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) AND "+
"                         (tblMedieplan.FællesBureauOrdreNr = @BureauOrdreNr) "+
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge, "+
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr, "+
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, "+
"                         tblMedieplan.OprettetDato "+
" HAVING        (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR "+
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) "+
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL12 = "SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) " +
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR " +
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse, " +
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) " +
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, " +
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol," +
"                             (SELECT        [Salesperson Code] " +
"                               FROM            NavisionContact " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato " +
" FROM            tblMedieplan INNER JOIN " +
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version " +
" WHERE        (tblMedieplan.KonsulentCode = @KonsulentCode) AND (tblMedieplan.IndrykningsUge BETWEEN @UgeStart AND @UgeSlut) AND (tblMedieplan.IndrykningsÅr = @År) " +
"                         AND (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR " +
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) " +
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge, " +
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr, " +
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                         tblMedieplan.OprettetDato " +
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";

        private static string sQL13 = "SELECT        TOP (100) PERCENT CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) " +
"                         WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version < 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) " +
"                         + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) " +
"                        + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører = 0 OR " +
"                         tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 1 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact1 " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS AnnoncørNo_, " +
"                         CASE WHEN tblMedieplan.KontaktpersonTilhører < 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) WHEN tblMedieplan.KontaktpersonTilhører = 2 THEN " +
"                             (SELECT        Name " +
"                               FROM            NavisionContact AS Contact2 " +
"                               WHERE        (No_ = tblMedieplan.BureauNo_)) + ' - ' + tblMedieplan.Kontaktperson END AS BureauNo_, tblMedieplan.Beskrivelse, tblPlacering.Betegnelse,  " +
"                         LTRIM(STR(tblMedieplan.Format1)) + ' x ' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplan.AntalFarver, COUNT(tblMedieplanLinjer.UgeavisID) " +
"                         AS AntalUgeaviser, tblMedieplan.KonsulentCode, tblMedieplan.IndrykningsUge, tblMedieplan.Status, tblMedieplan.MedieplanNr, tblMedieplan.Version, " +
"                         tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol, " +
"                             (SELECT        [Salesperson Code] " +
"                               FROM            NavisionContact " +
"                               WHERE        (No_ = tblMedieplan.AnnoncørNo_)) AS SalgsAnsvarlig, tblMedieplan.OprettetDato " +
"FROM            tblMedieplan INNER JOIN " +
"                         tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN " +
"                         tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version " +
" WHERE        (tblMedieplan.MedieplanNr = @MedieplanNr) AND (tblMedieplan.Version BETWEEN @VersionFra AND @VersionTil) AND  " +
"                         (tblMedieplan.RettelserEfterAnnoncekontrol = 0 OR " +
"                         tblMedieplan.RettelserEfterAnnoncekontrol = @MedtagRettelser) " +
" GROUP BY tblMedieplan.AnnoncørNo_, tblMedieplan.BureauNo_, tblMedieplan.Format1, tblMedieplan.Format2, tblMedieplan.AntalFarver, tblMedieplan.IndrykningsUge,  " +
"                         tblMedieplan.Beskrivelse, tblMedieplan.KonsulentCode, tblMedieplan.Status, tblPlacering.Betegnelse, tblMedieplan.Version, tblMedieplan.MedieplanNr,  " +
"                         tblMedieplan.Kontaktperson, tblMedieplan.KontaktpersonTilhører, tblMedieplan.Overskrift, tblMedieplan.RettelserEfterAnnoncekontrol,  " +
"                         tblMedieplan.OprettetDato " +
" ORDER BY tblMedieplan.MedieplanNr, tblMedieplan.Version ";
        public static string SQL { get => sQL; set => sQL = value; }
        public static string SQL2 { get => sQL2; set => sQL2 = value; }
        public static string SQL3 { get => sQL3; set => sQL3 = value; }
        public static string SQL4 { get => sQL4; set => sQL4 = value; }
        public static string SQL5 { get => sQL5; set => sQL5 = value; }
        public static string SQL6 { get => sQL6; set => sQL6 = value; }
        public static string SQL7 { get => sQL7; set => sQL7 = value; }
        public static string SQL8 { get => sQL8; set => sQL8 = value; }
        public static string SQL9 { get =>sQL9; set => sQL9 = value; }
        public static string SQL10 { get => sQL10; set => sQL10 = value; }
        public static string SQL11 { get => sQL11; set => sQL11 = value; }
        public static string SQL12 { get => sQL12; set => sQL12 = value; }
        public static string SQL13 { get => sQL13; set => sQL13 = value; }

    }
}
