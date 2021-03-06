﻿using dlu_persistence_api.models;
using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
namespace dlu_persistence_api.daos
{
    public class MediePlanAviserDao
    {
        private DiMPdotNetDevEntities diMPdot;
        public MediePlanAviserDao()
        {
            diMPdot = new DiMPdotNetDevEntities();
        }

        public AvisTIlGrid GetAllUgeAvisTilGrid(int bladid, int year, int placeringid = 0)
        {
            try
            {
                var res = from b in diMPdot.tblBladStamdatas
                          join p in diMPdot.tblPrisers on b.BladID equals p.BladID into bp
                          from p in bp.DefaultIfEmpty()
                          join r in diMPdot.tblRegions on b.RegionID equals r.RegionID into rb
                          from r in rb.DefaultIfEmpty()
                          join d in diMPdot.tblBladDækning on b.BladID equals d.BladID into db
                          from d in db.DefaultIfEmpty()

                          join da in diMPdot.tblDages on b.UgedagID equals da.DagID into dab
                          from da in dab.DefaultIfEmpty()
                          join geo in diMPdot.tblGeoKodes on b.GeoKodeID equals geo.GeoKodeID into bgeo
                          from geo in bgeo.DefaultIfEmpty()
                          join hg in diMPdot.tblHovedGruppes on b.HovedgruppeID equals hg.HovedGruppeID into hgb
                          from hg in hgb.DefaultIfEmpty()
                          join pos in diMPdot.tblPostNrs on b.PostNr equals pos.PostNr into bpos
                          from pos in bpos.DefaultIfEmpty()
                          join pla in diMPdot.tblPlacerings on p.PlaceringID equals pla.PlaceringID into pplap
                          from pla in pplap.DefaultIfEmpty()
                          join prisl in diMPdot.tblPrislisters on p.PrislisteID equals prisl.PrislisteID into pprisl
                          from prisl in pprisl.DefaultIfEmpty()
                          join konw in diMPdot.tblKoncernMiljøTillæg on b.Koncern equals konw.koncern into konwb
                          from know in konwb.DefaultIfEmpty()
                          where b.BladID == bladid & b.Ophørt == false & p.År == year & p.PlaceringID == placeringid & know.koncern != null
                          select new AvisTIlGrid
                          {
                              Adresse = b.Adresse,
                              AnnonceEmail = b.Adresse2,
                              BladID = b.BladID,
                              CVR = b.CVR,
                              Adresse2 = b.Adresse2,
                              AnnonceKontrolEmail = b.AnnonceKontrolEmail,
                              Betegnelse = pla.Betegnelse,
                              BilagsbladeEmail = b.BilagsbladeEmail,
                              BogholderiEmails = b.BogholderiEmails,
                              DaekningsGrad = d.DækningsGrad,
                              DagNavn = da.DagNavn,
                              DiMPDelOmraadeKode = b.DiMPDelOmrådeKode,
                              Ejerforhold = b.Ejerforhold,
                              Emails = b.Emails,
                              FakturaGruppeID = b.FakturaGruppeID,
                              Farve4Max = p.Farve4Max,
                              Farve4Min = p.Farve4Min,
                              Farve4Pris = p.Farve4Pris,
                              FarveMax = p.FarveMax,
                              FarveMin = p.FarveMin,
                              FarvePris = p.FarvePris,
                              Fax = b.Fax,
                              Format = b.Format,
                              FormatFra = p.FormatFra,
                              FormatTil = p.FormatTil,
                              GeoKodeNavn = geo.GeoKodeNavn,
                              GiverWebTillaeg = b.GiverWebTillæg,
                              GruppeRabat = b.GruppeRabat,
                              Hjemmeside = b.Hjemmeside,
                              HovedGruppeNavn = hg.HovedGruppeNavn,
                              Husstande = pos.Husstande,
                              Koncern = b.Koncern,
                              Kontaktperson = b.Kontaktperson,
                              KontaktpersonerEmails = b.KontaktpersonerEmails,
                              MaaGiveFarveRabat = b.MåGiveFarveRabat,
                              MaterialedeadlineRubrik = b.MaterialedeadlineRubrik,
                              MaterialeDeadlineRubrikDag = (from dag in diMPdot.tblDages where dag.DagID == b.MaterialeDeadlineRubrikDag select new Dage() { DagNavn = dag.DagNavn }).FirstOrDefault<Dage>().DagNavn


,
                              MatGodtBeloeb = b.MatGodtBeløb,
                              MaterialeDeadlineRubrikKl = b.MaterialeDeadlineRubrikKl,
                              MaterialedeadlineTekst = b.MaterialedeadlineTekst,

                              MaterialeDeadlineTekstDag = (from dag in diMPdot.tblDages where dag.DagID == b.MaterialeDeadlineTekstDag select new Dage() { DagNavn = dag.DagNavn }).FirstOrDefault<Dage>().DagNavn,
                              MaterialeDeadlineTekstKl = b.MaterialeDeadlineTekstKl,
                              MaterialeEmail = b.MaterialeEmail,
                              MaxDaekningsGrad = pos.MaxDækningsGrad,
                              Medlemaar = b.MedlemÅr,
                              MedlemMaaned = (from maaned in diMPdot.tblMåneder
                                              where maaned.maanedid == b.MedlemMåned
                                              select new Måned()
                                              {
                                                  MånedNavn = maaned.maanednavn
                                              }).FirstOrDefault<Måned>().MånedNavn,
                              MmPris = p.mmPris,
                              Navn = b.Navn,
                              Navn2 = b.Navn2,
                              Ophoert = b.Ophørt,
                              Oplag = d.Oplag,
                              OrdrecheckEmail = b.OrdrecheckEmail,
                              OrdrecheckSendeDagID = (from ordd in diMPdot.tblDages
                                                      where ordd.DagID == b.OrdrecheckSendeDagID
                                                      select new Dage()
                                                      {
                                                          DagNavn = ordd.DagNavn
                                                      }).FirstOrDefault<Dage>().DagNavn,
                              OrdredeadlineRubrik = b.OrdredeadlineRubrik,
                              OrdreDeadlineRubrikDag = (from ord in diMPdot.tblDages where ord.DagID == b.OrdreDeadlineRubrikDag select new Dage() { DagNavn = ord.DagNavn }).FirstOrDefault<Dage>().DagNavn
,
                              OrdreDeadlineRubrikKl = b.OrdreDeadlineRubrikKl,
                              OrdredeadlineTekst = b.OrdredeadlineTekst,
                              OrdreDeadlineTekstDag = (from ordt in diMPdot.tblDages where ordt.DagID == b.OrdreDeadlineTekstDag select new Dage() { DagNavn = ordt.DagNavn }).FirstOrDefault<Dage>().DagNavn,
                              OrdreDeadlineTekstKl = b.OrdreDeadlineTekstKl,
                              OrdreEmail = b.OrdreEmail,
                              OrienteringEmails = b.OrienteringEmails,
                              Overfoert = b.Overført,
                              PostBy = pos.PostBy,
                              PostNr = b.PostNr,
                              Primaer = b.Primær,
                              PrimaerPct = b.PrimærPct,
                              PrisforespoergselEmails = b.PrisforespørgselEmails,
                              PrislisteNavn = prisl.PrislisteNavn,
                              RedaktionEmail = b.RedaktionEmail,
                              RegionNavn = r.RegionNavn,
                              SamannonceringsRabat = b.SamannonceringsRabat,
                              SendetidOrdrecheck = b.SendetidOrdrecheck,
                              SendIndevaerendeUge = b.SendIndeværendeUge,
                              StamdataEmail = b.StamdataEmail,
                              Tlf = b.Tlf,
                              Totalomraade = b.Totalområde,
                              TotalomraadePct = b.TotalområdePct,
                              VisPaaWWW = b.VisPåWWW,
                              WWWDaekningSomTekst = b.WWWDækningSomTekst,


                              MiljøTillæg = know.miljøtilæg.Value != 0 ? know.miljøtilæg.Value : 0,
                              koncern = know.koncern,

                              UgeavisID = d.BladID,
                              fejl = diMPdot.tblFejlTeksts.Select(
                                               f => new Fejl()
                                               {
                                                   FejlTekst = f.FejlTekst,
                                                   
                                               }).ToList(),
                                               
                              ansvar = diMPdot.tblAnnoncekontrols.Select(e => new Ansvar() { Name = e.Ansvar}).Distinct().ToList()


                          };



                return res.FirstOrDefault();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception();
            }
        }

        public class ValueSum
        {
            public ValueSum()
            {
            }

            public double? V { get; set; }
        }
    }

    public class Måned
    {
        public Måned()
        {
        }

        public string MånedNavn { get; set; }
    }
}
