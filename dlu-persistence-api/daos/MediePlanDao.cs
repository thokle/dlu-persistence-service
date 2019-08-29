﻿using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
    public class MediePlanDao
    {
        private DiMPdotNetDevEntities entities;
        private IQueryable<tblMedieplan> res;

        public MediePlanDao()
        {
            entities = new DiMPdotNetDevEntities();

            entities.Configuration.LazyLoadingEnabled = true;
          
        }

        
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medieplanNr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetMediePlanByNumber(int medieplanNr)
        {

            try
            {


                var res = entities.tblMedieplans.Select(mp => new
                {
                    annoncoer_no = mp.AnnoncørNo_,
                    mp.AntalFarver,
                    bemaerkning_til_annoncoer = mp.BemærkningTilAnnoncør,
                    mp.BemærkningTilBlade,
                    mp.Beskrivelse,
                    mp.BilagsBladeATT,
                    mp.BilagsBladeTil,
                    mp.BilagsBladeTilAdresse,
                    mp.BilagsBladeTilNavn,
                    mp.BilagsBladeTilPostNr,
                    mp.BrugMaterialeFraUge,
                    mp.BureauNo_,
                    mp.Credit_Reason,
                    mp.Document_Type,
                    mp.Fakturering,
                    mp.Format1,
                    mp.Format2,
                    mp.FællesBureauOrdreNr,
                    mp.IndrykningsUge,
                    mp.IndrykningsÅr,
                    mp.InfoGodt,
                    mp.KonsulentCode,
                    mp.Kontaktperson,
                    kontaktperson_tilhoerer = mp.KontaktpersonTilhører,
                    mp.KunForhandlerBundForskellig,
                    mp.MaterialeFølgerFra,
                    materiale_foelger_fra_leveerandoer = mp.MaterialeFølgerFraLeverandør,
                    materiale_godtgoerle_alle = mp.MaterialeGodtgørelseAlle,
                    materiale_godtgoerelse_til = mp.MaterialeGodtgørelseTil,
                    mp.MedieplanNr,
                    miljoe_tillaeg_opkraeves = mp.MiljøTillægOpkræves,
                    opkraev_dsvp_miljotillaeg = mp.OpkrævDSVPMiljøTillæg,
                    opkraev_fynsk_miljoetilaeg = mp.OpkrævFynskeMiljøTillæg,
                    opkraev_helsingoer_miljoetilaeg = mp.OpkrævHelsingørMiljøTillæg,
                    opkraev_jyskemedier_as_tilaeg = mp.OpkrævJyskeMedierASTillæg,
                    opkraev_jyske_miljoetillaeg = mp.OpkrævJyskeMiljøTillæg,
                    opkrav_nordjysk_miljoetillaeg = mp.OpkrævNordjyskeTillæg,
                    opkrae_north_miljoetilaeg = mp.OpkrævNorthMiljøTillæg,
                    mp.OprettetDato,
                    mp.OrdreDato,
                    mp.Overskrift,

                    placering_betegnelse = mp.tblPlacering.Betegnelse,
                    kuloer = mp.tblDPKulør.Kulør,
                    mediePlanNr_AktiveVesion = mp.tblMedieplanNr.AktivVersion,
                    mediePlanNr_andvendtmiloetillaeg = mp.tblMedieplanNr.AnvendtMiljøTillæg,
                    mediePlanNr_anvendtPrisBeregner_version = mp.tblMedieplanNr.AnvendtPrisberegningVersion,
                    mediePlanNr_faktura_bemaerkning1 = mp.tblMedieplanNr.FakturaBemærkning1,
                    mediePlanNr_faktura_bemaerkning2 = mp.tblMedieplanNr.FakturaBemærkning2,
                    mediePlanNr_faktura_bemaerkning3 = mp.tblMedieplanNr.FakturaBemærkning3,
                    mediePlanNr_kommentar = mp.tblMedieplanNr.Kommentar,
                    mediePlanNr_materiale_modtaget =mp.tblMedieplanNr.MaterialeModtaget,
                    mediePlanNr_overfoert_fra_pris_forsporgelse  = mp.tblMedieplanNr.OverførtFraPrisforespørgsel,
                   mediePlanNr_status =  mp.tblMedieplanNr.Status,
               mediePlanNr_supportbillag_vedlagt =     mp.tblMedieplanNr.SupportBilagVedlagt,
             medieplanNr_supoortbilag_vist =       mp.tblMedieplanNr.SupportBilagVist,
                tillad_farve_saer_rabat = mp.TilladFarveSærRabat,
                 tillad_mm_saer_rabat =   mp.TilladMmSærRabat,
               version =   mp.Version,
               web_tillaeg_opkraves = mp.WebTillægOpkræves,
                    medieplannlinjer = mp.tblMedieplanLinjers.Select(mplj => new {
                        mplj.MedieplanNr,
                   bemaerkning =      mplj.Bemærkning,
                        mplj.BureauOrdreNr,
                        mplj.ErWeekendGruppe,
                        mplj.FarveMax,
                        mplj.FarveMin,
                        mplj.FarvePris,
                        mplj.FarveRabat,
                   farve_tillaeg =      mplj.FarveTillæg,
                        mplj.FarveTotal,
                 manueltaendret =       mplj.ManueltÆndret,
                 materiale_godtgoerelses_pris =        mplj.MaterialeGodtgørelsePris,
                        mplj.MaterialeNr,
                        mplj.MedIGrupper,
                     miljoetillaeg =    mplj.MiljøTillæg,
                        mplj.Mm,
                        mplj.MmPris,
                        mplj.MmRabat,
                        mplj.MmTotal,
                   maa_give_materiale_godtgoerlse =      mplj.MåGiveMaterialeGodtgørelse,
                        mplj.MåGiveMmRabat,
                        mplj.NormalMmPris,
                pris_laast =         mplj.PrisLåst,
                        mplj.RabatGruppe,
                        mplj.SendeGruppe,

                        mplj.SkalGiveMaterialeGodtgørelse
                     
                    }
                   
               
               
             


                    ).Take(1)

                }).Where(mp => mp.MedieplanNr == medieplanNr);

                return JsonConvert.SerializeObject(res, Formatting.Indented, new JsonSerializerSettings()
                {

                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore


                });
            }
            catch (Exception e)
            {
                throw new DaoExceptions("MediePlanDao GetMediePlanByNumber", e.InnerException);
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
         entities.tblMedieplans.AddOrUpdate(tblMedieplan);

                 var res = entities.SaveChanges();
                return new Tuple<string, int>("status", res);
            }
            catch (Exception  e)
            {
                throw new  Exception(e.HelpLink);
                 
            }
        }
    
      


        public string getMediePlanByKontaktPerson(string name)
        {
            try
            {
                var res = entities.tblMedieplans.Where(m => m.Kontaktperson.StartsWith(name) || m.Kontaktperson.Contains(name) || m.Kontaktperson.EndsWith(name)).Select(m => new
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
                throw new  DaoExceptions("getMediePlanByKontaktPerson  " , e.InnerException);
            }

        }

        public string GetMediePlanByAnnoncoer(string anoncoer)
        {
            try
            {
                var res = entities.tblMedieplans.Where(m => m.AnnoncørNo_.StartsWith(anoncoer) || m.AnnoncørNo_.Contains(anoncoer) || m.AnnoncørNo_.EndsWith(anoncoer)).Select(m => new {
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
                          join pyear in entities.tblPrislisterPrBladPrÅr on a.BladID equals  pyear.BladID into gpry
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

        public string findMediePlanToolbar(string mediePlan = null, string annnoncør = null, string bureau = null, int fraUge = 0, int tilUge = 0, int aar = 0,
            bool visInAktiveAnnoncer = false, bool mediePlanCheckBox = false, bool bookingCheckBox = false, bool rtAkCheckBox = false, bool faktureing = false)
        {
            var mp = entities.Set<tblMedieplan>();
            var mlt = entities.Set<tblMedieplanLinjer>();

       
            var query = from m in entities.tblMedieplans
                join ml in entities.tblMedieplanLinjers on m.MedieplanNr equals ml.MedieplanNr into mml
                from ml in mml.DefaultIfEmpty()
                join mlnr in entities.tblMedieplanLinjers on m.MedieplanNr equals mlnr.MedieplanNr into mlnrm
                from mlnr in mlnrm.DefaultIfEmpty()
                join mmlt in entities.tblMateriales on m.MedieplanNr equals mmlt.MedieplanNr into mmlmt
                from mmlt in mmlmt.DefaultIfEmpty()
                        select new
                        {
                            m.Beskrivelse,
                            m.Fakturering,
                            m.MedieplanNr,
                            m.AnnoncørNo_, 
                            m.AntalFarver,
                            m.BemærkningTilAnnoncør,
                            m.BemærkningTilBlade,
                    
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
                            
                            m.MiljøTillægOpkræves,
                            m.OpkrævDSVPMiljøTillæg,
                            m.OpkrævFynskeMiljøTillæg,
                            m.OpkrævHelsingørMiljøTillæg,
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

                        };
                   
                     if (mediePlan !="null")
            {
                query = query.Where(m => m.MedieplanNr.ToString().StartsWith(mediePlan) || m.MedieplanNr.ToString().Contains(mediePlan) || m.MedieplanNr.ToString().EndsWith(mediePlan));
            }
                     if(annnoncør !="null")
            {

                res = res.Where(a => a.AnnoncørNo_.StartsWith(annnoncør) || a.AnnoncørNo_.Contains(annnoncør) || a.AnnoncørNo_.EndsWith(annnoncør));
            
            }
             if (bureau !="null")
            {
                res = res.Where(b => b.BureauNo_.StartsWith(bureau) || b.BureauNo_.Contains(bureau) || b.BureauNo_.EndsWith(bureau));
            } 
             if(fraUge !=0 && tilUge !=0)
            {
                res = res.Where(fu => fu.IndrykningsUge > fraUge && tilUge <= fu.IndrykningsUge);
            } if (aar !=0)
            {
                res = res.Where(ar => ar.IndrykningsÅr == aar);
            } if(visInAktiveAnnoncer)
            {
             
            }

            var resultat = query.Select(m => new {
                m.Beskrivelse,
                m.Fakturering,
                m.MedieplanNr,
                m.AnnoncørNo_,
                m.AntalFarver,
                m.BemærkningTilAnnoncør,
                m.BemærkningTilBlade,

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

                m.MiljøTillægOpkræves,
                m.OpkrævDSVPMiljøTillæg,
                m.OpkrævFynskeMiljøTillæg,
                m.OpkrævHelsingørMiljøTillæg,
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

             return JsonConvert.SerializeObject(resultat.Take(10), Formatting.Indented);







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
        
    }
}



        




