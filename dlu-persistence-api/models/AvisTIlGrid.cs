using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.models
{
    public class AvisTIlGrid
    {
        public string Adresse { get; set; }
        public string Adresse2 { get; set; }
        public string AnnonceEmail { get; set; }
        public string AnnonceKontrolEmail { get; set; }
        public string BilagsbladeEmail { get; set; }
        public int BladID { get; set; }
        public string BogholderiEmails { get; set; }
        public string CVR { get; set; }
        public string DiMPDelOmraadeKode { get; set; }
        public string Ejerforhold { get; set; }
        public string Emails { get; set; }
        public int FakturaGruppeID { get; set; }
        public string Fax { get; set; }
        public string Format { get; set; }
        public bool GiverWebTillaeg { get; set; }
        public string GruppeRabat { get; set; }
        public string Hjemmeside { get; set; }
        public string Koncern { get; set; }
        public string koncern { get; internal set; }
        public string Kontaktperson { get; set; }
        public string KontaktpersonerEmails { get; set; }
        public string MaterialedeadlineRubrik { get; set; }
        public string MaterialeDeadlineRubrikDag { get; set; }
        public string MaterialeDeadlineRubrikKl { get; set; }
        public string MaterialedeadlineTekst { get; set; }
        public string MaterialeDeadlineTekstDag { get; set; }
        public string MaterialeDeadlineTekstKl { get; set; }
        public string MaterialeEmail { get; set; }
        public byte? MatGodtBeloeb { get; set; }
        public string MedlemMaaned { get; set; }
        public byte? Medlemaar { get; set; }
        public bool? MaaGiveFarveRabat { get; set; }
        public string Navn { get; set; }
        public string Navn2 { get; set; }
        public bool Ophoert { get; set; }
        public string OrdrecheckEmail { get; set; }
        public string OrdrecheckSendeDagID { get; set; }
        public string OrdredeadlineRubrik { get; set; }
        public string OrdreDeadlineRubrikDag { get; set; }
        public string OrdreDeadlineRubrikKl { get; set; }
        public string OrdredeadlineTekst { get; set; }
        public string OrdreDeadlineTekstDag { get; set; }
        public string OrdreDeadlineTekstKl { get; set; }
        public string OrdreEmail { get; set; }
        public string OrienteringEmails { get; set; }
        public bool Overfoert { get; set; }
        public int? Primaer { get; set; }
        public byte? PrimaerPct { get; set; }
        public string PrisforespoergselEmails { get; set; }
        public string RedaktionEmail { get; set; }
        public string SamannonceringsRabat { get; set; }
        public string SendetidOrdrecheck { get; set; }
        public bool? SendIndevaerendeUge { get; set; }
        public string StamdataEmail { get; set; }
        public string Tlf { get; set; }
        public int? Totalomraade { get; set; }
        public int? TotalomraadePct { get; set; }
        public bool VisPaaWWW { get; set; }
        public string WWWDaekningSomTekst { get; set; }
        public decimal? Farve4Max { get; set; }
        public decimal? Farve4Min { get; set; }
        public decimal? Farve4Pris { get; set; }
        public decimal? FarveMax { get; set; }
        public decimal? FarveMin { get; set; }
        public decimal? FarvePris { get; set; }
        public int FormatFra { get; set; }
        public int FormatTil { get; set; }

        public decimal? MmPris { get; set; }
        public string RegionNavn { get; set; }
        public int DaekningsGrad { get; set; }
        public int Oplag { get; set; }
        public string DagNavn { get; set; }
        public string GeoKodeNavn { get; set; }
        public string HovedGruppeNavn { get; set; }
        public int Husstande { get; set; }
        public int MaxDaekningsGrad { get; set; }
        public string PostBy { get; set; }
        public int? PostNr { get; set; }
        public string Betegnelse { get; set; }
        public string PrislisteNavn { get; set; }
        public decimal? totalPris { get; set; }
        public string bemærkning { get; set; }

        public decimal? TotalIncltillæg { get; set; }
        public float FarveRabat { get; set; }
        public decimal FarveTillæg { get; set; }
        public decimal FarveTotal { get; set; }
        public short Mm { get; set; }
        public float MmRabat { get; set; }
        public decimal MmTotal { get; set; }

        public float farveTotal { get; set; }
        public int MedieplanNr { get; set; }
        public string BureauOrdreNr { get; set; }
        public bool ErWeekendGruppe { get; set; }
        public bool ManueltÆndret { get; set; }
        public decimal MaterialeGodtgørelsePris { get; set; }
        public string MaterialeNr { get; set; }
        public string MedIGrupper { get; set; }
        public decimal MiljøTillæg { get; set; }
 
        public bool? MåGiveMmRabat { get; set; }
        public decimal NormalMmPris { get; set; }
        public bool MåGiveMaterialeGodtgørelse { get; set; }
        public bool PrisLåst { get; set; }
        public string SendeGruppe { get; set; }
        public string RabatGruppe { get; set; }
        public decimal OldMmtotal { get; set; }
        public bool SkalGiveMaterialeGodtgørelse { get; set; }
        public double? web_tillæg { get; set; }
        public decimal avis_tillæg { get; set; }
        public decimal andet_tillæg {get; set;}
        public string webtillæg_type { get; set; }
        public decimal oldTotalPris { get; set; }
        public double? sum_bladtilæg { get;  set; }
        public decimal oldFarveTotal { get; set; }
        public List<webtilLæg> webtillages { get; set; }
        public List<string> tillæg { get; set; }
        public int BureaoOrdreNr { get; set; }
        public decimal Total { get;  set; }
        public int UgeavisID { get;  set; }
        public string bureauOrdreNr { get; set; }
        public decimal? calTotalPris()
        {
          return  this.Farve4Max + Farve4Min + Farve4Pris + FarveMax + FarveMin + FarvePris;
        }
    }
}
