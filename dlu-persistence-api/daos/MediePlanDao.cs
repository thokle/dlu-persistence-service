using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
    public class MediePlanDao: IDisposable
    {
        private DiMPdotNetEntities entities;
      
        public MediePlanDao()
        {
            using (entities =new DiMPdotNetEntities())
            {
             entities.Configuration.LazyLoadingEnabled = true;
            }

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
                var mediePlan = from m in entities.tblMedieplans
                    where m.MedieplanNr == medieplanNr
                    orderby m.MedieplanNr
                    select new
                    {
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
                        m.SikkerhedsGodt, m.Status
                    };

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
    
        public void Dispose()
        {
            entities?.Dispose();
        }


        public string getMediePlanByKontaktPerson(string name)
        {
            try
            {
                var res = from m in entities.tblMedieplans
                    where m.Kontaktperson == name
                    select new
                    {
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
                        m.SikkerhedsGodt, m.Status
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("getMediePlanByKontaktPerson  " , e.InnerException);
            }

        }
        
    }
}



        




