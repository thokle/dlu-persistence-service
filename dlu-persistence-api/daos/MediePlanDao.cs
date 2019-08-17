using System;
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
        public string GetMediePlanByNumber(string medieplanNr)
        {
            try
            {
              
                var mediePlan = entities.tblMedieplans.Where(m => m.MedieplanNr.ToString().StartsWith(medieplanNr) || m.MedieplanNr.ToString().Contains(medieplanNr) || m.MedieplanNr.ToString().EndsWith(medieplanNr)).Select(m => new {
                    m.AnnoncørNo_, m.AntalFarver, m.BemærkningTilAnnoncør, m.BemærkningTilBlade, m.Beskrivelse,
                        m.BilagsBladeATT, m.BilagsBladeTil, m.BilagsBladeTilAdresse, m.BilagsBladeTilNavn,
                        m.BilagsBladeTilPostNr, m.BrugMaterialeFraUge, m.BureauNo_, m.Credit_Reason, m.Document_Type,
                        m.DPKulørID, m.Fakturering, m.Format1, m.Format2, m.FællesBureauOrdreNr, m.IndrykningsUge,
                        m.IndrykningsÅr, m.InfoGodt, m.KonsulentCode, m.Kontaktperson, m.KontaktpersonTilhører,
                        m.KunForhandlerBundForskellig, m.MaterialeFølgerFra, m.MaterialeFølgerFraLeverandør,
                        m.MaterialeGodtgørelseAlle, m.MaterialeGodtgørelseTil, m.MedieplanNr, m.MiljøTillægOpkræves,
                        m.OpkrævDSVPMiljøTillæg, m.OpkrævFynskeMiljøTillæg, m.OpkrævJyskeMedierASTillæg,
                        m.OpkrævJyskeMiljøTillæg, m.OpkrævNordjyskeTillæg, m.OpkrævNorthMiljøTillæg, m.OprettetDato,
                        m.OrdreDato,
                        m.Overskrift, m.PlaceringID, m.Previous_Version, m.RekvisitionsNr,
                        m.RettelserEfterAnnoncekontrol, m.SamletPris, m.SammeBureauOrdreNr, m.SammeMateriale,
                        m.SikkerhedsGodt, m.Status });
                   

                return JsonConvert.SerializeObject(mediePlan, Formatting.Indented);
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
        public Task<int> CreateOrUpdateMediePlan(tblMedieplan tblMedieplan)
        {
                 try
            {
                entities.tblMedieplans.AddOrUpdate(tblMedieplan);

                return entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new  FormattedDbEntityValidationException(e.InnerException);
                 
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

        public string findMediePlanToolbar(string mediePlan = null, string annnoncør = null, string bureau = null,
            int fraUge = 0, int tilUge = 0, int aar = 0,
            bool visInAktiveAnnoncer = false, int mediePlanCheckBox = 0, int bookingCheckBox = 0,
            bool rtAkCheckBox = false, bool faktureing = false)
        {

            var query = (from m in entities.tblMedieplans
                join ml in entities.tblMedieplanLinjers on m.MedieplanNr equals ml.MedieplanNr into mml
                from ml in mml.DefaultIfEmpty()
                join st in entities.tblBladStamdatas on ml.UgeavisID equals st.BladID into stml
                from st in stml.DefaultIfEmpty()
                select new
                {
                    m.MedieplanNr, ml.UgeavisID, m.AnnoncørNo_, m.BureauNo_, m.IndrykningsUge, m.IndrykningsÅr,
                    st.Ophørt, m.Status
                });



            if (mediePlan != "null")

            {
                query = query.Where(m =>
                    m.MedieplanNr.ToString().StartsWith(mediePlan) || m.MedieplanNr.ToString().Contains(mediePlan) ||
                    m.MedieplanNr.ToString().EndsWith(mediePlan));
            }

            if (annnoncør != "null")
            {

                query = query.Where(a =>
                    a.AnnoncørNo_.StartsWith(annnoncør) || a.AnnoncørNo_.Contains(annnoncør) ||
                    a.AnnoncørNo_.EndsWith(annnoncør));

            }

            if (bureau != "null")
            {
                query = query.Where(b =>
                    b.BureauNo_.StartsWith(bureau) || b.BureauNo_.Contains(bureau) || b.BureauNo_.EndsWith(bureau));
            }

            if (fraUge != 0 && tilUge != 0)
            {
                query = query.Where(fu => fu.IndrykningsUge > fraUge && tilUge <= fu.IndrykningsUge);
            }

            if (aar != 0)
            {
                query = query.Where(ar => ar.IndrykningsÅr == aar);
            }

            if (visInAktiveAnnoncer)
            {
                query = query.Where(ak => ak.Ophørt == true);
            }

            if (bookingCheckBox == 1)
            {
                query = query.Where(b => b.Status == 1);
            }

            if (mediePlanCheckBox == 1)
            {
                
            }

            if (rtAkCheckBox)
            {
            }

            if (faktureing)
            {
                
            }


            return JsonConvert.SerializeObject(query.Select(s => new
            {
               s.MedieplanNr,
                s.UgeavisID,
                s.AnnoncørNo_,
                s.BureauNo_,
                s.IndrykningsUge,
                s.IndrykningsÅr,
                s.Ophørt, 
                s.Status
            }), Formatting.Indented);
        }

     

        
        
    }
}



        




