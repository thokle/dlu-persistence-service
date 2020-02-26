using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
  public  class AnnonceKontrolService
    {
        private DiMPdotNetDevEntities entities;

        public AnnonceKontrolService()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public List<AnnoncekontrolModel>  GetAnnonceKontrol(int år, int uge)
        {
           return (from a in entities.tblBladStamdatas
             join mplr in entities.tblMedieplanLinjers on a.BladID equals mplr.UgeavisID into amplr
             from mplr in amplr.DefaultIfEmpty()
             join mpl in entities.tblMedieplans on mplr.MedieplanNr equals mpl.MedieplanNr into mplmlr
             from mpl in mplmlr.DefaultIfEmpty()
             join mplv in entities.tblMedieplans on mplr.Version equals mplv.Version into mplvmplr
             from mplv in mplvmplr.DefaultIfEmpty()
             join ank in entities.tblAnnoncekontrols on mpl.MedieplanNr equals ank.MedieplanNr into ankmpl
             from ank in ankmpl.DefaultIfEmpty()
             join aktv in entities.tblMedieplanNrs on mpl.Version equals aktv.AktivVersion into aktvl
             from aktv in aktvl.DefaultIfEmpty()
             where mpl.IndrykningsUge <= 1 & ank.ErKontrolleret == false & mpl.IndrykningsÅr == System.DateTime.Now.Year - 1 && aktv.Status == 3
             select new AnnoncekontrolModel()
             {
                 BladId = a.BladID, Navn = a.Navn, IndRykningsUge = mpl.IndrykningsUge
             }).ToList();

        }
    }

    public class AnnoncekontrolModel
    {
        public AnnoncekontrolModel()
        {
        }

        public int BladId { get; set; }
        public string Navn { get; set; }
        public byte IndRykningsUge { get; set; }
    }
}
