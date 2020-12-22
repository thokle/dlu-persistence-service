using dlu_persistence_api.exceptions;
using System;
using System.Data.SqlClient;

namespace dlu_persistence_api.services
{
   public class SendTilNavisionService
    {
        private DiMPdotNetDevEntities entities;


        public SendTilNavisionService()
        {
            entities = new DiMPdotNetDevEntities();
        }
        public Tuple<string, int> SendTilnavison(int indrykingsUge)
        {


            try
            {

                // Opdater TotalPris i de rækker hvor den mangler. Sættes til sidst udregnede pris for avisen
                entities.Database.ExecuteSqlCommand(@"UPDATE tblMedieplanLinjer SET TotalPris = (SELECT TOP (1) TotalPris FROM dbo.tblMedieplanLinjer AS tblMedieplanLinjer_1 WHERE     (MedieplanNr = dbo.tblMedieplanLinjer.MedieplanNr) AND (TotalPris IS NOT NULL) AND (Version < tblMedieplanLinjer.Version) AND (UgeavisID = tblMedieplanLinjer.UgeavisID) ORDER BY Version DESC) WHERE (TotalPris IS NULL) AND (Version > 11)");

                entities.Database.ExecuteSqlCommand(@"INSERT INTO tblMedieplan (MedieplanNr, Version, AnnoncørNo_, BureauNo_, Format1, Format2, AntalFarver, DPKulørID, PlaceringID, IndrykningsUge, IndrykningsÅr, Beskrivelse, Overskrift, Kontaktperson, KontaktpersonTilhører, Fakturering, RekvisitionsNr, BilagsBladeTil,
BilagsBladeTilNavn, BilagsBladeTilAdresse, BilagsBladeTilPostNr, BilagsBladeATT, MaterialeGodtgørelseTil, MaterialeFølgerFra, MaterialeFølgerFraLeverandør, BrugMaterialeFraUge, MaterialeGodtgørelseAlle, SikkerhedsGodt, InfoGodt, SamletPris, OprettetDato, OrdreDato, KonsulentCode, Status, RettelserEfterAnnoncekontrol
, TilladFarveSærRabat, TilladMmSærRabat, [Document Type], [Credit Reason], [Previous Version], SammeMateriale, KunForhandlerBundForskellig, SammeBureauOrdreNr, FællesBureauOrdreNr, BemærkningTilAnnoncør, BemærkningTilBlade, WebTillægOpkræves, MiljøTillægOpkræves, OpkrævJyskeMiljøTillæg, OpkrævFynskeMiljøTillæg,
OpkrævNorthMiljøTillæg, OpkrævDSVPMiljøTillæg, OpkrævHelsingørMiljøTillæg) SELECT tblMedieplan_1.MedieplanNr, tblMedieplan_1.Version * 10 + 1 AS EXPR1, tblMedieplan_1.AnnoncørNo_, tblMedieplan_1.BureauNo_, tblMedieplan_1.Format1, tblMedieplan_1.Format2, tblMedieplan_1.AntalFarver, tblMedieplan_1.DPKulørID, 
tblMedieplan_1.PlaceringID, tblMedieplan_1.IndrykningsUge, tblMedieplan_1.IndrykningsÅr, tblMedieplan_1.Beskrivelse, tblMedieplan_1.Overskrift, tblMedieplan_1.Kontaktperson,tblMedieplan_1. KontaktpersonTilhører, tblMedieplan_1.Fakturering, tblMedieplan_1.RekvisitionsNr, tblMedieplan_1.BilagsBladeTil, 
tblMedieplan_1.BilagsBladeTilNavn, tblMedieplan_1.BilagsBladeTilAdresse, tblMedieplan_1.BilagsBladeTilPostNr, tblMedieplan_1.BilagsBladeATT, tblMedieplan_1.MaterialeGodtgørelseTil, tblMedieplan_1.MaterialeFølgerFra, tblMedieplan_1.MaterialeFølgerFraLeverandør, tblMedieplan_1.BrugMaterialeFraUge, 
tblMedieplan_1.MaterialeGodtgørelseAlle, tblMedieplan_1.SikkerhedsGodt, tblMedieplan_1.InfoGodt, tblMedieplan_1.SamletPris, tblMedieplan_1.OprettetDato, tblMedieplan_1.OrdreDato, tblMedieplan_1.KonsulentCode, tblMedieplan_1.Status, tblMedieplan_1.RettelserEfterAnnoncekontrol, tblMedieplan_1.TilladFarveSærRabat, 
tblMedieplan_1.TilladMmSærRabat, tblMedieplan_1.[Document Type], tblMedieplan_1.[Credit Reason], tblMedieplan_1.[Previous Version], tblMedieplan_1.SammeMateriale, tblMedieplan_1. KunForhandlerBundForskellig, tblMedieplan_1.SammeBureauOrdreNr, tblMedieplan_1.FællesBureauOrdreNr, tblMedieplan_1.BemærkningTilAnnoncør,
tblMedieplan_1.BemærkningTilBlade, tblMedieplan_1.WebTillægOpkræves, tblMedieplan_1.MiljøTillægOpkræves, tblMedieplan_1.OpkrævJyskeMiljøTillæg, tblMedieplan_1.OpkrævFynskeMiljøTillæg, tblMedieplan_1.OpkrævNorthMiljøTillæg, tblMedieplan_1.OpkrævDSVPMiljøTillæg, tblMedieplan_1.OpkrævHelsingørMiljøTillæg
FROM dbo.tblMedieplan AS tblMedieplan_1 INNER JOIN dbo.tblMedieplanNr ON tblMedieplan_1.MedieplanNr = dbo.tblMedieplanNr.MedieplanNr AND tblMedieplan_1.Version = dbo.tblMedieplanNr.AktivVersion WHERE (dbo.tblMedieplanNr.Status = 6) AND (dbo.tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan_1.IndrykningsUge=@indrykingsUge) ", new SqlParameter("indrykingsUge", indrykingsUge));

                // Kopier medieplanlinjer
              var res1 =   entities.Database.ExecuteSqlCommand(@"INSERT INTO tblMedieplanLinjer (MedieplanNr, Version, UgeavisID, Mm, NormalMmPris, MmPris, MmRabat, MåGiveMmRabat, MmTotal, FarveTillæg, FarvePris, FarveRabat, FarveMin, FarveMax, FarveTotal, Total, MåGiveMaterialeGodtgørelse, SkalGiveMaterialeGodtgørelse," +
                      " MaterialeGodtgørelsePris, TotalPris, ManueltÆndret, ErWeekendGruppe, WebtillægFaktureresHer, SendeGruppe, RabatGruppe, MedIGrupper, BureauOrdreNr, MaterialeNr, Bemærkning, MiljøTillæg, TotalInclTillæg) SELECT tblMedieplanLinjer_1.MedieplanNr, " +
                      "tblMedieplanLinjer_1.Version * 10 + 1 AS EXPR1, " +
                      "tblMedieplanLinjer_1.UgeavisID, tblMedieplanLinjer_1.Mm, tblMedieplanLinjer_1.NormalMmPris, tblMedieplanLinjer_1.MmPris, tblMedieplanLinjer_1.MmRabat, tblMedieplanLinjer_1.MåGiveMmRabat, tblMedieplanLinjer_1.MmTotal, tblMedieplanLinjer_1.FarveTillæg, " +
                      "tblMedieplanLinjer_1.FarvePris, tblMedieplanLinjer_1.FarveRabat, tblMedieplanLinjer_1.FarveMin, tblMedieplanLinjer_1.FarveMax, tblMedieplanLinjer_1.FarveTotal, tblMedieplanLinjer_1.Total, " +
                      "tblMedieplanLinjer_1.MåGiveMaterialeGodtgørelse, tblMedieplanLinjer_1.SkalGiveMaterialeGodtgørelse, tblMedieplanLinjer_1.MaterialeGodtgørelsePris, tblMedieplanLinjer_1.TotalPris, " +
                      "tblMedieplanLinjer_1.ManueltÆndret, tblMedieplanLinjer_1.ErWeekendGruppe, tblMedieplanLinjer_1.WebtillægFaktureresHer, tblMedieplanLinjer_1.SendeGruppe, tblMedieplanLinjer_1.RabatGruppe," +
                      " tblMedieplanLinjer_1.MedIGrupper, tblMedieplanLinjer_1.BureauOrdreNr, tblMedieplanLinjer_1.MaterialeNr, tblMedieplanLinjer_1.Bemærkning, tblMedieplanLinjer_1.MiljøTillæg, tblMedieplanLinjer_1.TotalInclTillæg " +
                      "FROM tblMedieplanLinjer AS tblMedieplanLinjer_1 INNER JOIN tblMedieplan ON tblMedieplanLinjer_1.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer_1.Version = tblMedieplan.Version" +
                      " INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) " +
                      "AND (tblMedieplan.IndrykningsUge=@indrykingsUge)", new SqlParameter("indrykingsUge", indrykingsUge));

              var res2=  entities.Database.ExecuteSqlCommand(@"INSERT INTO dbo.tblOrdreNavision (OrdreNr, Version, [Document Type], AnnoncørID, Uge, AntalFarver, OrdreDato, SamletPris, SælgerKode, SikkerhedsGodt, InfoGodt, BureauOrdreNr, Bureau, EnOrdre, Status, FakBem1, FakBem2, FakBem3, MaterialeGodtgørelseTil, [Previous Order No], [Credit Reason], [Previous Version], [Item Description], SammeBureauOrdreNr) SELECT tblMedieplan.MedieplanNr AS OrdreNr, tblMedieplan.Version * 10 + 1 AS EXPR1, tblMedieplan.[Document Type], tblMedieplan.AnnoncørNo_, tblMedieplan.IndrykningsUge AS Uge, tblMedieplan.AntalFarver, tblMedieplan.OrdreDato, tblMedieplan.SamletPris, NavisionContact.[Salesperson Code], tblMedieplan.SikkerhedsGodt, tblMedieplan.InfoGodt, tblMedieplan.FællesBureauOrdreNr AS BureauOrdreNr, tblMedieplan.BureauNo_ AS Bureau, tblMedieplan.Fakturering AS EnOrdre, tblMedieplanNr.Status, tblMedieplanNr.FakturaBemærkning1 AS FakBem1, tblMedieplanNr.FakturaBemærkning2 AS FakBem2, tblMedieplanNr.FakturaBemærkning3 AS FakBem3, 1 AS MatTil, tblMedieplan.MedieplanNr AS [Previous Order No], '' AS EXPR1, 0 AS EXPR2, '' AS EXPR3, tblMedieplan.SammeBureauOrdreNr FROM tblMedieplan INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge=@indrykingsUge)", new SqlParameter("indrykingsUge", indrykingsUge));

              var res3=  entities.Database.ExecuteSqlCommand(@"SET DATEFIRST 1 INSERT INTO tblOrdreLinjerNavision (OrdreNr, Version, [Document Type], BladId, Format, Mm, AnvendtPris, SpecialRabat, FarveTillægsPris, FarveTillægsRabat, MaterialeGodt, TotalPris, MaterialePris, BureauOrdreNr, FirstTime) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version * 10 + 1 AS EXPR1, tblMedieplan.[Document Type], tblMedieplanLinjer.UgeavisID AS BladId, LTRIM(STR(tblMedieplan.Format1)) + 'x' + LTRIM(STR(tblMedieplan.Format2)) AS Format, tblMedieplanLinjer.Mm, tblMedieplanLinjer.MmPris AS AnvendtPris, tblMedieplanLinjer.MmRabat AS SpecialRabat, tblMedieplanLinjer.FarvePris AS FarveTillægsPris, tblMedieplanLinjer.FarveRabat AS FarveTillægsRabat, tblMedieplanLinjer.SkalGiveMaterialeGodtgørelse AS MaterialeGodt, tblMedieplanLinjer.TotalPris, tblMedieplanLinjer.MaterialeGodtgørelsePris AS MaterialePris, tblMedieplanLinjer.BureauOrdreNr, (DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4 - DATEPART(dw, DATEADD(week, tblMedieplan.IndrykningsUge, DATEADD(year, tblMedieplan.IndrykningsÅr - 1900, 0)) - 4) + 1) + tblBladStamdata.UgedagID % 7 - 1 AS IndrykningsDato FROM tblMedieplanLinjer INNER JOIN tblMedieplan ON tblMedieplanLinjer.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanLinjer.Version = tblMedieplan.Version INNER JOIN tblMedieplanNr ON tblMedieplan.MedieplanNr = tblMedieplanNr.MedieplanNr AND tblMedieplan.Version = tblMedieplanNr.AktivVersion INNER JOIN tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge=@indrykingsUge)", new SqlParameter("indrykingsUge", indrykingsUge));


             var res4 = entities.Database.ExecuteSqlCommand(@"INSERT INTO tblOrdreGebyrNavision (OrdreNr, Version, [Document Type], Type, BladId, Description, Amount) SELECT tblMedieplanLinjer.MedieplanNr AS OrdreNr, tblMedieplanLinjer.Version * 10 + 1 AS Version, 0 AS DokType, 2 AS Type, tblMedieplanLinjer.UgeavisID AS BladId, 'Miljø tillæg' AS Description, tblMedieplanLinjer.MiljøTillæg AS Amount FROM tblMedieplanNr INNER JOIN tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version INNER JOIN tblMedieplanLinjer ON tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr AND tblMedieplan.Version = tblMedieplanLinjer.Version WHERE (tblMedieplan.MiljøTillægOpkræves = 1) AND (tblMedieplanLinjer.MiljøTillæg > 0) AND (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge = @indrykingsUge)", new SqlParameter("indrykingsUge", indrykingsUge));

                // Opdater Navision ordre dato så kl. sættes til 00:00:00, Advertiser med annoncørnavn og Placement med placerings betegnelse
            var res5=    entities.Database.ExecuteSqlCommand("UPDATE tblOrdreNavision SET OrdreDato = CONVERT(DATETIME, CONVERT(NVARCHAR, tblOrdreNavision.OrdreDato, 105) + ' 00:00:00', 105), Advertiser = NavisionContact.Name, Placement = tblPlacering.Betegnelse FROM tblOrdreNavision INNER JOIN tblMedieplan ON tblOrdreNavision.Version = tblMedieplan.Version AND tblOrdreNavision.OrdreNr = tblMedieplan.MedieplanNr INNER JOIN tblPlacering ON tblMedieplan.PlaceringID = tblPlacering.PlaceringID INNER JOIN NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_");

              var res6=  entities.Database.ExecuteSqlCommand(@"UPDATE tblMedieplanNr SET AktivVersion = tblMedieplanNr.AktivVersion * 10 + 1 FROM tblMedieplanNr INNER JOIN tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version WHERE (tblMedieplanNr.Status = 6) AND (tblMedieplanNr.AktivVersion < 100) AND (tblMedieplan.IndrykningsUge=@indrykingsUge) ", new SqlParameter("indrykingsUge", indrykingsUge));


                return new Tuple<string, int>("Sendt til Navision", res1+res2+res3+res4);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Tuple<int, int> RunNavisonStoredProcedures()
        {
            try
            {
                var res1 = entities.IndsætOrdreTilNavision();
                var res2 = entities.IndsætOrdreLinjerTilNavision();

                return new Tuple<int, int>(res1, res2);
               
            } catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }
    }
}
