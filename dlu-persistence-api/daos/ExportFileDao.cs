using Microsoft.Extensions.Logging;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class ExportFileDao
    {
        private DiMPdotNetDevEntities entities;

        public ExportFileDao()
        {
            entities = new DiMPdotNetDevEntities();
        }
        public List<tblHovedEle> GetTblHovedEles()
        {
            try
            {
                return entities.Database.SqlQuery<tblHovedEle>("SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.Adresse, tblBladStamdata.PostNr, tblPostNr.PostBy, tblBladStamdata.Tlf, tblBladStamdata.Fax, tblBladStamdata.AnnonceEmail AS Email, tblBladStamdata.Hjemmeside, tblDage.DagNavn, CASE WHEN tblDelOmråde.DelOmrådeKode = 'Y' THEN 'delomraade_fyn' WHEN tblDelOmråde.DelOmrådeKode = 'N' THEN 'delomraade_nord' WHEN tblDelOmråde.DelOmrådeKode = 'S' THEN 'delomraade_syd' WHEN tblDelOmråde.DelOmrådeKode = 'M' THEN 'delomraade_midt' WHEN tblDelOmråde.DelOmrådeKode = 'J' THEN 'delomraade_bornholm' ELSE 'delomraade_' + lower(tblDelOmråde.DelOmrådeKode) END AS delomraade, tblBladStamdata.WWWDækningSomTekst, 0 AS KortNr, tblBladStamdata.Oplag, tblBladStamdata.RedaktionEmail FROM tblPostNr INNER JOIN tblBladStamdata ON tblPostNr.PostNr = tblBladStamdata.PostNr INNER JOIN tblDage ON tblBladStamdata.UgedagID = tblDage.DagID INNER JOIN tblDelOmråde ON tblBladStamdata.DelOmrådeID = tblDelOmråde.DelOmrådeID WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (tblBladStamdata.VisPåWWW = 1)").ToList();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<tblLaesertalEle> GetTblLaesertalEles()
        {
            try
            {
                return entities.Database.SqlQuery<tblLaesertalEle>("SELECT BladID, Totalområde, TotalområdePct, 'Kommuner' AS PrimaerKommuner, Primær, PrimærPct FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0) AND (VisPåWWW = 1)").ToList();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<tblRabatEle> GetTblRabatEles()
        {
            try
            {
                return entities.Database.SqlQuery<tblRabatEle>("SELECT BladID, GruppeRabat, SamannonceringsRabat FROM tblBladStamdata WHERE (HovedgruppeID < 2) AND (Ophørt = 0) AND (VisPåWWW = 1)").ToList();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<tblTekniskEle> GetTblTekniskEles()
        {
            try
            {
                return entities.Database.SqlQuery<tblTekniskEle>("SELECT BladID, Kontaktperson, Ejerforhold, Format, '' AS satssted, '' AS tryksted, OrdredeadlineTekst, OrdredeadlineRubrik FROM tblBladStamdata WHERE(HovedgruppeID < 2) AND(Ophørt = 0) AND(VisPåWWW = 1)").ToList();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PrimaerDaekning> GetPrimaerDaeknings()
        {
            try
            {
                return entities.Database.SqlQuery<PrimaerDaekning>("SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.PostNr AS BladPostNr, tblPostNr.PostBy, tblPostNr.PostNr FROM tblBladStamdata INNER JOIN tblBladDækning ON tblBladStamdata.BladID = tblBladDækning.BladID INNER JOIN tblPostNr ON tblBladDækning.PostNr = tblPostNr.PostNr WHERE (tblBladStamdata.HovedgruppeID < 2) AND (tblBladStamdata.Ophørt = 0) AND (tblBladStamdata.VisPåWWW = 1) AND (tblBladDækning.DækningsGrad >= 80)").ToList();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BladXml> GetBladXmls()
        {
            try
            {
                return entities.Database.SqlQuery<BladXml>("SELECT tblBladStamdata.BladID, tblBladStamdata.Navn, tblBladStamdata.Adresse, tblBladStamdata.PostNr, tblPostNr.PostBy, tblBladStamdata.Tlf,  tblBladStamdata.AnnonceEmail AS Email," +
                    " tblBladStamdata.Hjemmeside, tblDage.DagNavn, CASE WHEN tblDelOmråde.DelOmrådeKode = 'Y' THEN 'delomraade_fyn' WHEN tblDelOmråde.DelOmrådeKode = 'N' THEN 'delomraade_nord' WHEN tblDelOmråde.DelOmrådeKode = 'S' THEN 'delomraade_syd' " +
                    "WHEN tblDelOmråde.DelOmrådeKode = 'M' THEN 'delomraade_midt' WHEN tblDelOmråde.DelOmrådeKode = 'J' THEN 'delomraade_bornholm' ELSE 'delomraade_' + lower(tblDelOmråde.DelOmrådeKode) END AS Delomraade, tblBladStamdata.Oplag, tblBladStamdata.RedaktionEmail, " +
                    "tblBladStamdata.Totalområde, tblBladStamdata.TotalområdePct, 'Kommuner' AS 'Kommuner', tblBladStamdata.Primær, tblBladStamdata.PrimærPct, (SELECT mmPris FROM tblPriser WHERE(PlaceringID = 1) AND(År = YEAR(GETDATE())) AND(PrislisteID = 1) AND(FormatFra < 2)" +
                    " AND(BladID = tblBladStamdata.BladID)) AS TekstPris, (SELECT mmPris FROM tblPriser WHERE(PlaceringID = 11) AND(År = YEAR(GETDATE())) AND(PrislisteID = 1) AND(FormatFra < 2) AND(BladID = tblBladStamdata.BladID)) AS RubrikPris, (SELECT FarvePris FROM tblPriser" +
                    " WHERE(PlaceringID = 1) AND(År = YEAR(GETDATE())) AND(PrislisteID = 1) AND(FormatFra < 2) AND(BladID = tblBladStamdata.BladID)) AS FarvePris, (SELECT Farve4Pris FROM tblPriser WHERE(PlaceringID = 1) AND(År = YEAR(GETDATE())) AND(PrislisteID = 1) AND(FormatFra < 2)" +
                    " AND(BladID = tblBladStamdata.BladID)) AS Farve4Pris, tblBladStamdata.Kontaktperson FROM tblPostNr INNER JOIN tblBladStamdata ON tblPostNr.PostNr = tblBladStamdata.PostNr INNER JOIN tblDage ON tblBladStamdata.UgedagID = tblDage.DagID INNER JOIN tblDelOmråde " +
                    "ON tblBladStamdata.DelOmrådeID = tblDelOmråde.DelOmrådeID WHERE(tblBladStamdata.HovedgruppeID < 2) AND(tblBladStamdata.Ophørt = 0").ToList();

            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BladXmlDækningsGrad> GetBladXmlDækningsGrads(int bladid)
        {
            try
            {

                return entities.Database.SqlQuery<BladXmlDækningsGrad>("SELECT PostNr, DækningsGrad FROM tblBladDækning WHERE (BladID=@bladId )", new SqlParameter("bladId", bladid)).ToList();
            } catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

  public  class BladXml        
    {
        private int bladID;
        private string navn;
        private string adresse;
        private int postNr;
        private string postBy;
        private char tlf;
        private string email;
        private string hjemmeside;
        private string dagNavn;
        private string delomraade;
        private int oplag;
        private string redaktionEmail;
        private int totalområde;
        private int totalområdePct;
        private string kommuner;
        private int primær;
        private int primærPct;
        private decimal tekstPris;
        private decimal rubrikPris;
        private decimal farvePris;
        private decimal farve4Pris;
        private string kontaktperson;

        public int BladID { get => bladID; set => bladID = value; }
        public string Navn { get => navn; set => navn = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int PostNr { get => postNr; set => postNr = value; }
        public string PostBy { get => postBy; set => postBy = value; }
        public char Tlf { get => tlf; set => tlf = value; }
        public string Email { get => email; set => email = value; }
        public string Hjemmeside { get => hjemmeside; set => hjemmeside = value; }
        public string DagNavn { get => dagNavn; set => dagNavn = value; }
        public string Delomraade { get => delomraade; set => delomraade = value; }
        public int Oplag { get => oplag; set => oplag = value; }
        public string RedaktionEmail { get => redaktionEmail; set => redaktionEmail = value; }
        public int Totalområde { get => totalområde; set => totalområde = value; }
        public int TotalområdePct { get => totalområdePct; set => totalområdePct = value; }
        public string Kommuner { get => kommuner; set => kommuner = value; }
        public int Primær { get => primær; set => primær = value; }
        public int PrimærPct { get => primærPct; set => primærPct = value; }
        public decimal TekstPris { get => tekstPris; set => tekstPris = value; }
        public decimal RubrikPris { get => rubrikPris; set => rubrikPris = value; }
        public decimal FarvePris { get => farvePris; set => farvePris = value; }
        public decimal Farve4Pris { get => farve4Pris; set => farve4Pris = value; }
        public string Kontaktperson { get => kontaktperson; set => kontaktperson = value; }
    }



    public class BladXmlDækningsGrad
    {
    
        private int postNr;
        private int dækningsGrad;

        public int PostNr { get => postNr; set => postNr = value; }
        public int DækningsGrad { get => dækningsGrad; set => dækningsGrad = value; }
    }


    public class PrimaerDaekning
    {
        private int bladID;
        private string navn;
        private int bladPostNr;
        private string postBy;
        private int postNr;

        public int BladID { get => bladID; set => bladID = value; }
        public string Navn { get => navn; set => navn = value; }
        public int BladPostNr { get => bladPostNr; set => bladPostNr = value; }
        public string PostBy { get => postBy; set => postBy = value; }
        public int PostNr { get => postNr; set => postNr = value; }
    }

    public class tblTekniskEle
    {
        private int bladID;
        private string kontaktperson;
        private string ejerforhold;
        private string format;
        private string satssted;
        private string tryksted;
        private string ordredeadlineTekst;
        private string ordredeadlineRubrik;

        public int BladID { get => bladID; set => bladID = value; }
        public string Kontaktperson { get => kontaktperson; set => kontaktperson = value; }
        public string Ejerforhold { get => ejerforhold; set => ejerforhold = value; }
        public string Format { get => format; set => format = value; }
        public string Satssted { get => satssted; set => satssted = value; }
        public string Tryksted { get => tryksted; set => tryksted = value; }
        public string OrdredeadlineTekst { get => ordredeadlineTekst; set => ordredeadlineTekst = value; }
        public string OrdredeadlineRubrik { get => ordredeadlineRubrik; set => ordredeadlineRubrik = value; }
    }
    public class tblRabatEle
    {
        private int bladID;
        private string grupperRabat;
        private string samannonceringsRabat;

        public int BladID { get => bladID; set => bladID = value; }
        public string GrupperRabat { get => grupperRabat; set => grupperRabat = value; }
        public string SamannonceringsRabat { get => samannonceringsRabat; set => samannonceringsRabat = value; }
    }
    public class tblLaesertalEle
    {
        private int bladID;
        private int totalområde;
        private int totalområdePct;
        private string primaerKommuner;
        private string primær;
        private int primærPct;

        public int BladID { get => bladID; set => bladID = value; }
        public int Totalområde { get => totalområde; set => totalområde = value; }
        public int TotalområdePct { get => totalområdePct; set => totalområdePct = value; }
        public string PrimaerKommuner { get => primaerKommuner; set => primaerKommuner = value; }
        public string Primær { get => primær; set => primær = value; }
        public int PrimærPct { get => primærPct; set => primærPct = value; }
    }


  public  class tblHovedEle
    {
        private int bladID;
        private string navn;
        private string adresse;
        private int postNr;
        private string postBy;
        private string tlf;
        private string email;
        private string hjemmeside;
        private string dagNavn;

        public int BladID { get => bladID; set => bladID = value; }
        public string Navn { get => navn; set => navn = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int PostNr { get => postNr; set => postNr = value; }
        public string PostBy { get => postBy; set => postBy = value; }
        public string Tlf { get => tlf; set => tlf = value; }
        public string Email { get => email; set => email = value; }
        public string Hjemmeside { get => hjemmeside; set => hjemmeside = value; }
        public string DagNavn { get => dagNavn; set => dagNavn = value; }
    }


}
