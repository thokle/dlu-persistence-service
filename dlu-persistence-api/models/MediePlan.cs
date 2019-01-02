using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class MediePlan
   {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediePlan()
        {
            MedieplanLinjers = new HashSet<MedieplanLinjer>();
        }

        public int MedieplanNr { get; set; }

        public short Version { get; set; }
        public string AnnoncørNo_ { get; set; }
        public string BureauNo_ { get; set; }
        public byte Format1 { get; set; }
        public short Format2 { get; set; }
        public byte AntalFarver { get; set; }
        public byte DPKulørID { get; set; }
        public byte PlaceringID { get; set; }
        public byte IndrykningsUge { get; set; }
        public short IndrykningsÅr { get; set; }
        public string Beskrivelse { get; set; }
        public string Overskrift { get; set; }
        public string Kontaktperson { get; set; }
        public byte KontaktpersonTilhører { get; set; }
        public byte Fakturering { get; set; }
        public string RekvisitionsNr { get; set; }
        public short BilagsBladeTil { get; set; }
        public string BilagsBladeTilNavn { get; set; }
        public string BilagsBladeTilAdresse { get; set; }
        public int BilagsBladeTilPostNr { get; set; }
        public string BilagsBladeATT { get; set; }
        public byte MaterialeGodtgørelseTil { get; set; }
        public byte MaterialeFølgerFra { get; set; }
        public string MaterialeFølgerFraLeverandør { get; set; }
        public byte BrugMaterialeFraUge { get; set; }
        public bool MaterialeGodtgørelseAlle { get; set; }
        public bool SikkerhedsGodt { get; set; }
        public bool InfoGodt { get; set; }
        public decimal SamletPris { get; set; }
        public System.DateTime OprettetDato { get; set; }
        public System.DateTime OrdreDato { get; set; }
        public string KonsulentCode { get; set; }
        public byte Status { get; set; }
        public bool RettelserEfterAnnoncekontrol { get; set; }
        public bool TilladFarveSærRabat { get; set; }
        public bool TilladMmSærRabat { get; set; }
        public byte Document_Type { get; set; }
        public string Credit_Reason { get; set; }
        public int? Previous_Version { get; set; }
        public bool SammeMateriale { get; set; }
        public bool KunForhandlerBundForskellig { get; set; }
        public bool SammeBureauOrdreNr { get; set; }
        public string FællesBureauOrdreNr { get; set; }
        public string BemærkningTilAnnoncør { get; set; }
        public string BemærkningTilBlade { get; set; }
        public bool? WebTillægOpkræves { get; set; }
        public bool? MiljøTillægOpkræves { get; set; }
        public bool? OpkrævJyskeMiljøTillæg { get; set; }
        public bool? OpkrævFynskeMiljøTillæg { get; set; }
        public bool? OpkrævNorthMiljøTillæg { get; set; }
        public bool? OpkrævDSVPMiljøTillæg { get; set; }
        public bool? OpkrævNordjyskeTillæg { get; set; }
        public bool? OpkrævJyskeMedierASTillæg { get; set; }

        public virtual tblDPKulør tblDPKulør { get; set; }
        public virtual tblMedieplanNr tblMedieplanNr { get; set; }
        public virtual tblPlacering tblPlacering { get; set; }
       
        public virtual ICollection<MedieplanLinjer> MedieplanLinjers { get; set; }
    }
}

