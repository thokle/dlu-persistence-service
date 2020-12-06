using DDF_sql_services.daos;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using dlu_persistence_api.services;
using LinqKit;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class MediePlanDao
    {
        private DDF_sql_services.daos.AnnonøcerDAO annonøcerDAO;
        private DDF_sql_services.daos.BureaoDao bureaoDao;
        private List<DDF_sql_services.daos.Annoncøer> annoncøers { get; set; }
        private List<DDF_sql_services.daos.Bureau> bureaus { get; set; }

     

        private string GetBureauName(string annoncør)
        {
            if (annoncør !=null && annoncør!= "") {
                var res = bureaus.Find(s => s.Company_No_ == annoncør).Annoncør;
                return res != null ? res : "Ingen bureau";
            }
            return "Ingen Bureau";
        }
        private DiMPdotNetDevEntities entities;
        private IQueryable<tblMedieplan> res;
        
        public MediePlanDao()
        {
            entities = new DiMPdotNetDevEntities();
            annonøcerDAO = new AnnonøcerDAO();
          annoncøers =   annonøcerDAO.GetAnnoncøer();
            bureaoDao = new BureaoDao();
            bureaus = bureaoDao.GetListbureauer();
            entities.Configuration.LazyLoadingEnabled = false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="medieplanNr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public MediePlan GetMediePlanByNumber(int medieplanNr, int version)
        {
            try
            { 
                var res = entities.tblMedieplans.Where(medieplan => medieplan.MedieplanNr == medieplanNr && medieplan.Version == version).Select(mp => new MediePlan()
                {
                    Statius = mp.Status,
                    annoncoer_no = mp.AnnoncørNo_,
                    PlaceringID = mp.PlaceringID,
                    DPKulørID = mp.DPKulørID,
                    AntalFarver = mp.AntalFarver,
                    bemaerkning_til_annoncoer = mp.BemærkningTilAnnoncør,
                    BemærkningTilBlade = mp.BemærkningTilBlade,
                    Beskrivelse = mp.Beskrivelse,
                    BilagsBladeATT = mp.BilagsBladeATT,
                    BilagsBladeTil = mp.BilagsBladeTil,
                    BilagsBladeTilAdresse = mp.BilagsBladeTilAdresse,
                    BilagsBladeTilNavn = mp.BilagsBladeTilNavn,
                    BilagsBladeTilPostNr = mp.BilagsBladeTilPostNr,
                    BrugMaterialeFraUge = mp.BrugMaterialeFraUge,
                    BureauNo_ = mp.BureauNo_,
                    Credit_Reason = mp.Credit_Reason,
                    Document_Type = mp.Document_Type,
                    Fakturering = mp.Fakturering,
                    Format1 = mp.Format1,
                    Format2 = mp.Format2,
                    FællesBureauOrdreNr = mp.FællesBureauOrdreNr,
                    IndrykningsUge = mp.IndrykningsUge,
                    IndrykningsÅr = mp.IndrykningsÅr,
                    InfoGodt = mp.InfoGodt,
                    KonsulentCode = mp.KonsulentCode,
                    Kontaktperson = mp.Kontaktperson,
                    kontaktperson_tilhoerer = mp.KontaktpersonTilhører,
                    KunForhandlerBundForskellig = mp.KunForhandlerBundForskellig,
                    MaterialeFølgerFra = mp.MaterialeFølgerFra,
                    materiale_foelger_fra_leveerandoer = mp.MaterialeFølgerFraLeverandør,
                    materiale_godtgoerle_alle = mp.MaterialeGodtgørelseAlle,
                    materiale_godtgoerelse_til = mp.MaterialeGodtgørelseTil,
                    MedieplanNr = mp.MedieplanNr,
                    miljoe_tillaeg_opkraeves = mp.MiljøTillægOpkræves,
                    opkraev_dsvp_miljotillaeg = mp.OpkrævDSVPMiljøTillæg,
                    opkraev_fynsk_miljoetilaeg = mp.OpkrævFynskeMiljøTillæg,
                    opkraev_helsingoer_miljoetilaeg = mp.OpkrævHelsingørMiljøTillæg,
                    opkraev_jyskemedier_as_tilaeg = mp.OpkrævJyskeMedierASTillæg,
                    opkraev_jyske_miljoetillaeg = mp.OpkrævJyskeMiljøTillæg,
                    opkrav_nordjysk_miljoetillaeg = mp.OpkrævNordjyskeTillæg,
                    opkrae_north_miljoetilaeg = mp.OpkrævNorthMiljøTillæg,
                    OprettetDato = mp.OprettetDato,
                    OrdreDato = mp.OrdreDato,
                    Overskrift = mp.Overskrift,
                    RekvisitionsNr = mp.RekvisitionsNr,
                    placering_betegnelse = mp.tblPlacering.Betegnelse,
                    kuloer = mp.tblDPKulør.Kulør,
                    mediePlanNr_AktiveVesion = mp.tblMedieplanNr.AktivVersion,
                    mediePlanNr_andvendtmiloetillaeg = mp.tblMedieplanNr.AnvendtMiljøTillæg,
                    mediePlanNr_anvendtPrisBeregner_version = mp.tblMedieplanNr.AnvendtPrisberegningVersion,
                    mediePlanNr_faktura_bemaerkning1 = mp.tblMedieplanNr.FakturaBemærkning1,
                    mediePlanNr_faktura_bemaerkning2 = mp.tblMedieplanNr.FakturaBemærkning2,
                    mediePlanNr_faktura_bemaerkning3 = mp.tblMedieplanNr.FakturaBemærkning3,
                    mediePlanNr_kommentar = mp.tblMedieplanNr.Kommentar,
                    mediePlanNr_materiale_modtaget = mp.tblMedieplanNr.MaterialeModtaget,
                    mediePlanNr_overfoert_fra_pris_forsporgelse = mp.tblMedieplanNr.OverførtFraPrisforespørgsel,
                    mediePlanNr_status = mp.tblMedieplanNr.Status,
                    mediePlanNr_supportbillag_vedlagt = mp.tblMedieplanNr.SupportBilagVedlagt,
                    medieplanNr_supoortbilag_vist = mp.tblMedieplanNr.SupportBilagVist,
                    tillad_farve_saer_rabat = mp.TilladFarveSærRabat,
                    tillad_mm_saer_rabat = mp.TilladMmSærRabat,
                    version = mp.Version,
                    web_tillaeg_opkraves = mp.WebTillægOpkræves,

                    medieplannlinjer = (from linjer in mp.tblMedieplanLinjers
                                        where linjer.MedieplanNr == medieplanNr & linjer.Version == version
                                        join re in entities.tblBladStamdatas on linjer.UgeavisID equals re.BladID into reres
                                        from re in reres.DefaultIfEmpty()

                                        select new AvisTIlGrid()
                                        {
                                            RabatGruppe = linjer.RabatGruppe,
                                            MedieplanNr = linjer.MedieplanNr,
                                            bemærkning = linjer.Bemærkning,
                                            BureauOrdreNr = linjer.BureauOrdreNr,
                                            ErWeekendGruppe = linjer.ErWeekendGruppe,
                                            FarveMax = linjer.FarveMax,
                                            FarveMin = linjer.FarveMin,

                                            FarvePris = linjer.FarvePris,
                                            FarveRabat = linjer.FarveRabat,
                                            FarveTillæg = linjer.FarveTillæg,
                                            FarveTotal = linjer.FarveTotal,
                                            ManueltÆndret = linjer.ManueltÆndret,
                                            MaterialeGodtgørelsePris = linjer.MaterialeGodtgørelsePris,
                                            MaterialeNr = linjer.MaterialeNr,
                                            MedIGrupper = linjer.MedIGrupper,
                                            MiljøTillæg = linjer.MiljøTillæg,
                                            Mm = linjer.Mm,
                                            MmPris = linjer.MmPris,
                                            MmRabat = linjer.MmRabat,
                                            MmTotal = linjer.MmTotal,

                                            MåGiveMaterialeGodtgørelse = linjer.MåGiveMaterialeGodtgørelse,
                                            MåGiveMmRabat = linjer.MåGiveMmRabat,
                                            NormalMmPris = linjer.NormalMmPris,
                                            PrisLåst = linjer.PrisLåst,
                                            SendeGruppe = linjer.SendeGruppe,

                                            SkalGiveMaterialeGodtgørelse = linjer.SkalGiveMaterialeGodtgørelse,
                                            Navn = re.Navn,
                                            Navn2 = re.Navn2,
                                            Total = linjer.Total,
                                            totalPris = linjer.TotalPris,
                                            UgeavisID = linjer.UgeavisID,
                                            fejl = entities.tblFejlTeksts.Select( 
                                               f => new Fejl()
                                               {
                                                   FejlTekst = f.FejlTekst
                                               }).ToList(),
                                           ansvar = entities.tblAnnoncekontrols.Select(e => new Ansvar() { Name = e.Ansvar }).Distinct().ToList()
                                        }).ToList()
                });

                return res.FirstOrDefault<MediePlan>();
            }
            catch (FormattedDbEntityValidationException ex)
            {
                throw new Exception("MediePlanDao GetMediePlanByNumber", ex.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblMedieplan"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Tuple<string, int> CreateOrUpdateMediePlan(tblMedieplan tblMedieplan)
        {
            try
            {
                //  var res =  DeleteIFExist(tblMedieplan.MedieplanNr);
                entities.tblMedieplans.AddOrUpdate(tblMedieplan);


                var w = entities.SaveChanges();
                return new Tuple<string, int>("status", w);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        private int DeleteIFExist(int mediePlanMR)
        {
            var res = entities.tblMedieplans.Where(w => w.MedieplanNr == mediePlanMR).FirstOrDefault();

            if (res.MedieplanNr == mediePlanMR)
            {
                entities.tblMedieplans.Attach(res);
                entities.tblMedieplans.Remove(res);
                return entities.SaveChanges();
            }

            return 0;
        }


        public string getMediePlanByKontaktPerson(string name)
        {
            try
            {
                var res = entities.tblMedieplans.Where(m =>
                    m.Kontaktperson.StartsWith(name) || m.Kontaktperson.Contains(name) ||
                    m.Kontaktperson.EndsWith(name)).Select(m => new
                    {
                        m.AnnoncørNo_,
                        m.AntalFarver,
                        m.BemærkningTilAnnoncør,
                        m.BemærkningTilBlade,
                        m.Beskrivelse,
                        m.BilagsBladeATT,
                        m.BilagsBladeTil,
                        m.BilagsBladeTilAdresse,
                        m.BilagsBladeTilNavn,
                        m.BilagsBladeTilPostNr,
                        m.BrugMaterialeFraUge,
                        m.BureauNo_,
                        m.Credit_Reason,
                        m.Document_Type,
                        m.DPKulørID,
                        m.Fakturering,
                        m.Format1,
                        m.Format2,
                        m.FællesBureauOrdreNr,
                        m.IndrykningsUge,
                        m.IndrykningsÅr,
                        m.InfoGodt,
                        m.KonsulentCode,
                        m.Kontaktperson,
                        m.KontaktpersonTilhører,
                        m.KunForhandlerBundForskellig,
                        m.MaterialeFølgerFra,
                        m.MaterialeFølgerFraLeverandør,
                        m.MaterialeGodtgørelseAlle,
                        m.MaterialeGodtgørelseTil,
                        m.MedieplanNr,
                        m.MiljøTillægOpkræves,
                        m.OpkrævDSVPMiljøTillæg,
                        m.OpkrævFynskeMiljøTillæg,
                        m.OpkrævJyskeMedierASTillæg,
                        m.OpkrævJyskeMiljøTillæg,
                        m.OpkrævNordjyskeTillæg,
                        m.OpkrævNorthMiljøTillæg,
                        m.OprettetDato,
                        m.OrdreDato,
                        m.Overskrift,
                        m.PlaceringID,
                        m.Previous_Version,
                        m.RekvisitionsNr,
                        m.RettelserEfterAnnoncekontrol,
                        m.SamletPris,
                        m.SammeBureauOrdreNr,
                        m.SammeMateriale,
                        m.SikkerhedsGodt,
                        m.Status
                    });

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("getMediePlanByKontaktPerson  ", e.InnerException);
            }
        }

        public string GetMediePlanByAnnoncoer(string anoncoer)
        {
            try
            {
                var res = entities.tblMedieplans.Where(m =>
                    m.AnnoncørNo_.StartsWith(anoncoer) || m.AnnoncørNo_.Contains(anoncoer) ||
                    m.AnnoncørNo_.EndsWith(anoncoer)).Select(m => new
                    {
                        m.AnnoncørNo_,
                        m.AntalFarver,
                        m.BemærkningTilAnnoncør,
                        m.BemærkningTilBlade,
                        m.Beskrivelse,
                        m.BilagsBladeATT,
                        m.BilagsBladeTil,
                        m.BilagsBladeTilAdresse,
                        m.BilagsBladeTilNavn,
                        m.BilagsBladeTilPostNr,
                        m.BrugMaterialeFraUge,
                        m.BureauNo_,
                        m.Credit_Reason,
                        m.Document_Type,
                        m.DPKulørID,
                        m.Fakturering,
                        m.Format1,
                        m.Format2,
                        m.FællesBureauOrdreNr,
                        m.IndrykningsUge,
                        m.IndrykningsÅr,
                        m.InfoGodt,
                        m.KonsulentCode,
                        m.Kontaktperson,
                        m.KontaktpersonTilhører,
                        m.KunForhandlerBundForskellig,
                        m.MaterialeFølgerFra,
                        m.MaterialeFølgerFraLeverandør,
                        m.MaterialeGodtgørelseAlle,
                        m.MaterialeGodtgørelseTil,
                        m.MedieplanNr,
                        m.MiljøTillægOpkræves,
                        m.OpkrævDSVPMiljøTillæg,
                        m.OpkrævFynskeMiljøTillæg,
                        m.OpkrævJyskeMedierASTillæg,
                        m.OpkrævJyskeMiljøTillæg,
                        m.OpkrævNordjyskeTillæg,
                        m.OpkrævNorthMiljøTillæg,
                        m.OprettetDato,
                        m.OrdreDato,
                        m.Overskrift,
                        m.PlaceringID,
                        m.Previous_Version,
                        m.RekvisitionsNr,
                        m.RettelserEfterAnnoncekontrol,
                        m.SamletPris,
                        m.SammeBureauOrdreNr,
                        m.SammeMateriale,
                        m.SikkerhedsGodt,
                        m.Status
                    });

                return JsonConvert.SerializeObject(res, Formatting.Indented, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetAvisTilMediePlan(int bladid)
        {
            try
            {
                var res = from a in entities.tblBladStamdatas
                          join
                              p in entities.tblPrisers on a.BladID equals p.BladID into ap
                          from p in ap.DefaultIfEmpty()
                          join g in entities.tblGeoKodes on a.GeoKodeID equals g.GeoKodeID into gp
                          from g in gp.DefaultIfEmpty()
                          join dl in entities.tblDelOmråde on a.DelOmrådeID equals dl.DelOmrådeID into dp
                          from dl in dp.DefaultIfEmpty()
                          join dk in entities.tblMedIGruppes on a.SalgsGruppeID equals dk.ID into grp
                          from dk in grp.DefaultIfEmpty()
                          join pyear in entities.tblPrislisterPrBladPrÅr on a.BladID equals pyear.BladID into gpry
                          from pyear in gpry.DefaultIfEmpty()
                          join pw in entities.tblPrislisterPrBladPrUges on a.BladID equals pw.BladID into gpw
                          from pw in gpw.DefaultIfEmpty()
                          where a.BladID == bladid
                          select new
                          {
                          };


                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<FundetMediePlaner> findMediePlanToolbar(int mediePlan = 0, string annnoncør = null,
            string bureau = null, byte fraUge = 0, byte tilUge = 0, short aar = 0,
            bool visInAktiveAnnoncer = false, bool mediePlanCheckBox = false, bool bookingCheckBox = false,
            bool rtAkCheckBox = false, bool faktureing = false, string avis = "")
        {
            try
            {
                var pre = PredicateBuilder.New<FundetMediePlaner>();
                
                pre = pre.Or(a => a.IndrykningsÅr == aar);
             //   pre = pre.Or(a => a.MedieplanNr == a.MediePlanLinlerNr);
              //  pre = pre.Or(s => s.Version == s.MediePlanLinjerVersion);
                if (mediePlan != 0)
                {
                    pre = pre.And(a => a.MedieplanNr == mediePlan);
                } else

                if (annnoncør != "")
                {
                    pre = pre.And(m => m.AnnoncørNo_.Equals(annnoncør));
                       
                } else

                if (bureau != "" )
                {
                    pre = pre.And(m =>
                        m.BureauNo_.Equals(bureau));
                } else

                if (fraUge > 0 && (tilUge > 1 && tilUge < 53) && mediePlan == 0)
                {
                    pre = pre.And(u => u.IndrykningsUge > fraUge && u.IndrykningsUge <= tilUge);
                
                } else

                    if (visInAktiveAnnoncer)
                {
                 //   pre = pre.And(planer => planer.Status.ToString().Length > 3);
                } else


                    if (mediePlanCheckBox && !bookingCheckBox)
                {
                    pre = pre.And(planer => planer.Status == 1);
                } else

                    if (bookingCheckBox && !mediePlanCheckBox)
                {
                    pre = pre.And(p => p.Status == 2);
                } else
                    if (faktureing)
                {
                    pre = pre.And(p => p.Version.ToString().Length > 2);
                } else
                    if (bookingCheckBox && mediePlanCheckBox)
                {
                    pre = pre.And(p =>
                      p.Status == 2 );
                    pre = pre.And(p => p.Status == 2);
                } else if( avis !="")
                {
                    pre.And(a => a.Navn == avis);
                }
                /*
                 * persons.LeftJoin(phoneNumbers,  person => person.Id,  phoneNumber => phoneNumber.PersonId,  (person, phoneNumber) => new
        {
            Person = person,
            PhoneNumber = phoneNumber?.Number
        }
);
                 * */

                return (from m in entities.tblMedieplans
                        join mp in entities.tblMedieplanLinjers on m.MedieplanNr equals mp.MedieplanNr 
                        join mp2 in entities.tblMedieplanLinjers on m.Version equals mp2.Version 

                        join st in entities.tblBladStamdatas on mp.UgeavisID equals st.BladID 
                        join na in entities.NavisionContacts on m.AnnoncørNo_ equals na.No_


                        join pl in entities.tblPlacerings on m.PlaceringID equals pl.PlaceringID into plm from pl in plm.DefaultIfEmpty()

                        select new
                        {


                            m.AnnoncørNo_,
                            AntalAviser = (from le in entities.tblMedieplanLinjers where le.MedieplanNr == m.MedieplanNr select new { le.MedieplanNr }).Count(),
                            m.AntalFarver,
                            m.Beskrivelse,
                            bureauNavn = na.Name,
                            m.BureauNo_,
                            m.Format1,
                            m.Format2,
                            m.IndrykningsUge,
                            m.IndrykningsÅr,
                            m.KonsulentCode,
                            m.Kontaktperson,
                            m.KontaktpersonTilhører,
                            m.MedieplanNr,
                            na.Name,
                            m.Overskrift,
                            m.Status,
                            m.Version,
                            MediePlanLinlerNr = mp.MedieplanNr,
                            MediePlanLinjerVersion = mp.Version,
                            st.Navn,


                        }).GroupBy(gr => new
                        {
                            gr.MedieplanNr,
                            gr.Status,
                            gr.Version,
                            gr.AnnoncørNo_,
                            gr.AntalAviser,
                            gr.AntalFarver,
                            gr.Beskrivelse,
                            gr.bureauNavn,
                            gr.BureauNo_,
                            gr.Format1,
                            gr.Format2,
                            gr.IndrykningsUge,
                            gr.IndrykningsÅr,
                            gr.KonsulentCode,
                            gr.Kontaktperson,
                            gr.KontaktpersonTilhører,
                            gr.Navn,
                            gr.Overskrift

                        }).Select(a => new FundetMediePlaner()
                        {
                            AntalAviser = entities.tblMedieplanLinjers.Where(l => l.MedieplanNr == a.Key.MedieplanNr).Select(s => new { s.MedieplanNr }).Distinct().Count(),

                            Beskrivelse = a.Key.Beskrivelse,
                            Format1 = a.Key.Format1,
                            Format2 = a.Key.Format1,
                            Kontaktperson = a.Key.Kontaktperson,
                            Overskrift = a.Key.Overskrift,

                            Status = a.Key.Status,
                            Version = a.Key.Version,
                            AnnoncørNo_ = a.Key.AnnoncørNo_,
                            AntalFarver = a.Key.AntalFarver,
                            BureauNo_ = a.Key.BureauNo_,
                            IndrykningsUge = a.Key.IndrykningsUge,
                            IndrykningsÅr = a.Key.IndrykningsÅr,
                            KonsulentCode = a.Key.KonsulentCode,
                            KontaktpersonTilhører = a.Key.KontaktpersonTilhører,
                            MedieplanNr = a.Key.MedieplanNr
                          //  bureauNavn = GetBureauName(a.Key.BureauNo_)
                        }).Where(pre)



                          .OrderBy(o => o.MedieplanNr).Distinct().ToList();                
       

              
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.InnerException);
                throw new Exception(ex.Message);
            }
        }

      
       
     
        public MediePlan GetMediePlanFortableOrdreNavision(int indrykningsuge)
        {
            var res = (from mp in entities.tblMedieplans
                       join mplnr in entities.tblMedieplanNrs on mp.MedieplanNr equals mplnr.MedieplanNr into mpmpnlr
                       from mplnr in mpmpnlr.DefaultIfEmpty()
                       join nav in entities.NavisionContacts on mp.AnnoncørNo_ equals nav.No_ into mpnav
                       from nav in mpnav.DefaultIfEmpty()
                       where mp.IndrykningsUge == indrykningsuge & mplnr.AktivVersion > 100 & mplnr.Status == 6
                       select new MediePlan()
                       {

                       }

                       ).SingleOrDefault();


            return res;
        }


        public bool FindOmBladUdKommer(int bladid, int uge, int år)
        {
            try
            {
                var res = (from p in entities.tblPrislisterPrBladPrUges
                           join pl in entities.tblPrislisters on p.PrislisteID equals pl.PrislisteID into ppl
                           from pl in ppl.DefaultIfEmpty()
                           where p.År == år && p.Uge == uge && p.BladID == bladid select new Udkommerikke()
                           {
                             PrislisteNavn =   pl.PrislisteNavn
                           }).FirstOrDefault();
                          
                if (res != null)
                {
                    if (res.PrislisteNavn.Equals("Udkommer ikke"))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return true;
             }
            catch (FormattedDbEntityValidationException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public MediePlan GetMediePlanFornavision(int indrykningsUge)
        {

            var res = (from mp in entities.tblMedieplans
                       join mpl in entities.tblMedieplanNrs on mp.MedieplanNr equals mpl.MedieplanNr into mpmpl

                       from mpl in mpmpl.DefaultIfEmpty()
                       where mp.Version == mpl.AktivVersion & mpl.Status == 6 & mpl.AktivVersion < 100 & mp.IndrykningsUge == indrykningsUge
                       select new MediePlan()
                       {
                           annoncoer_no = mp.AnnoncørNo_,
                           AntalFarver = mp.AntalFarver,
                           bemaerkning_til_annoncoer = mp.BemærkningTilAnnoncør,
                           BemærkningTilBlade = mp.BemærkningTilBlade,
                           opkraev_helsingoer_miljoetilaeg = mp.OpkrævHelsingørMiljøTillæg,
                           Beskrivelse = mp.Beskrivelse,
                           BilagsBladeATT = mp.BilagsBladeATT,
                           BilagsBladeTil = mp.BilagsBladeTil,
                           BilagsBladeTilAdresse = mp.BilagsBladeTilAdresse,
                           BilagsBladeTilNavn = mp.BilagsBladeTilNavn,
                           mediePlanNr_AktiveVesion = mpl.AktivVersion,
                           BilagsBladeTilPostNr = mp.BilagsBladeTilPostNr,
                           MedieplanNr = mp.MedieplanNr,
                           mediePlanNr_andvendtmiloetillaeg = mpl.AnvendtMiljøTillæg,
                           BrugMaterialeFraUge = mp.BrugMaterialeFraUge,
                           BureauNo_ = mp.BureauNo_,
                           Credit_Reason = mp.Credit_Reason,
                           Document_Type = mp.Document_Type,
                           DPKulørID = mp.DPKulørID,
                           Fakturering = mp.Fakturering,
                           Format1 = mp.Format1,
                           Format2 = mp.Format2,
                           FællesBureauOrdreNr = mp.FællesBureauOrdreNr,
                           IndrykningsUge = mp.IndrykningsUge,
                           IndrykningsÅr = mp.IndrykningsÅr,
                           mediePlanNr_anvendtPrisBeregner_version = mpl.AnvendtPrisberegningVersion,
                           InfoGodt = mp.InfoGodt,
                           KonsulentCode = mp.KonsulentCode,
                           Kontaktperson = mp.Kontaktperson,
                           kontaktperson_tilhoerer = mp.KontaktpersonTilhører,
                           version = Convert.ToInt16(mp.Version * Convert.ToInt16(10) + Convert.ToInt16(1)),
                           mediePlanNr_kommentar = mpl.Kommentar,
                           mediePlanNr_status = mp.Status,
                           OprettetDato = mp.OprettetDato
                       }).OrderByDescending(s => s.version).Single();






            return res;

        }

        public Tuple<string, int> GetLatestMedienr()
        {
            try
            {
                var res = entities.tblMedieplans.OrderByDescending(o => o.MedieplanNr).First<tblMedieplan>();
                return new Tuple<string, int>("MediePlanNr", res.MedieplanNr);
            }
            catch (EntryPointNotFoundException e)
            {
                throw new Exception(e.HelpLink);
            }
        }


        public int SetFakturing(int mediePlanNr, int version, int value)
        {
            try
            {
             return   entities.Database.ExecuteSqlCommand("update tblMedieplan set Fakturering=@value where MedieplanNr=@mediePlanNr and Version=@version", new SqlParameter("mediePlanNr", mediePlanNr), new SqlParameter("version", version), new SqlParameter("value", value));
            }catch(Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }
    }


    public class Udkommerikke
    {
        public Udkommerikke()
        {
        }

        public string PrislisteNavn { get;  set; }
    }

    
    public class MediePlan
    {
        public MediePlan()
        {
        }

        public string annoncoer_no { get; set; }
        public byte AntalFarver { get; set; }
        public string bemaerkning_til_annoncoer { get; set; }
        public string BemærkningTilBlade { get; set; }
        public string Beskrivelse { get; set; }
        public string BilagsBladeATT { get; set; }
        public short BilagsBladeTil { get; set; }
        public string BilagsBladeTilAdresse { get; set; }
        public string BilagsBladeTilNavn { get; set; }
        public int BilagsBladeTilPostNr { get; set; }
        public byte BrugMaterialeFraUge { get; set; }
        public string BureauNo_ { get; set; }
        public string Credit_Reason { get; set; }
        public byte Document_Type { get; set; }
        public byte Fakturering { get; set; }
        public byte Format1 { get; set; }
        public short Format2 { get; set; }
        public string FællesBureauOrdreNr { get; set; }
        public byte IndrykningsUge { get; set; }
        public short IndrykningsÅr { get; set; }
        public bool InfoGodt { get; set; }
        public string KonsulentCode { get; set; }
        public string Kontaktperson { get; set; }
        public byte kontaktperson_tilhoerer { get; set; }
        public bool KunForhandlerBundForskellig { get; set; }
        public byte MaterialeFølgerFra { get; set; }
        public string materiale_foelger_fra_leveerandoer { get; set; }
        public bool materiale_godtgoerle_alle { get; set; }
        public byte materiale_godtgoerelse_til { get; set; }
        public int MedieplanNr { get; set; }
        public bool? miljoe_tillaeg_opkraeves { get; set; }
        public bool? opkraev_dsvp_miljotillaeg { get; set; }
        public bool? opkraev_fynsk_miljoetilaeg { get; set; }
        public bool? opkraev_helsingoer_miljoetilaeg { get; set; }
        public bool? opkraev_jyskemedier_as_tilaeg { get; set; }
        public bool? opkraev_jyske_miljoetillaeg { get; set; }
        public bool? opkrav_nordjysk_miljoetillaeg { get; set; }
        public bool? opkrae_north_miljoetilaeg { get; set; }
        public DateTime OprettetDato { get; set; }
        public DateTime OrdreDato { get; set; }
        public string Overskrift { get; set; }
        public string placering_betegnelse { get; set; }
        public string kuloer { get; set; }
        public short mediePlanNr_AktiveVesion { get; set; }
        public decimal mediePlanNr_andvendtmiloetillaeg { get; set; }
        public byte mediePlanNr_anvendtPrisBeregner_version { get; set; }
        public string mediePlanNr_faktura_bemaerkning1 { get; set; }
        public string mediePlanNr_faktura_bemaerkning2 { get; set; }
        public string mediePlanNr_faktura_bemaerkning3 { get; set; }
        public string mediePlanNr_kommentar { get; set; }
        public bool mediePlanNr_materiale_modtaget { get; set; }
        public bool mediePlanNr_overfoert_fra_pris_forsporgelse { get; set; }
        public byte mediePlanNr_status { get; set; }
        public bool mediePlanNr_supportbillag_vedlagt { get; set; }
        public bool medieplanNr_supoortbilag_vist { get; set; }
        public bool tillad_farve_saer_rabat { get; set; }
        public bool tillad_mm_saer_rabat { get; set; }
        public short version { get; set; }
        public bool? web_tillaeg_opkraves { get; set; }
        public List<AvisTIlGrid> medieplannlinjer { get; set; }
        public byte PlaceringID { get; set; }
        public byte DPKulørID { get; set; }
        public string RekvisitionsNr { get; set; }
        public byte Statius { get; set; }
        public int? Previous_Version { get; internal set; }
        public bool RettelserEfterAnnoncekontrol { get; internal set; }
    }
}