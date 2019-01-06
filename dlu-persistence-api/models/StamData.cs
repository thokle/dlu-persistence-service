﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.models;
using Newtonsoft.Json;

namespace dlu_persistence_api
{
   public  class StamData
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StamData()
        {
            this.tblMedIGruppes = new HashSet<tblMedIGruppe>();
            this.tblMedieplanLinjers = new HashSet<tblMedieplanLinjer>();
            this.tblPrisers = new List<Prisers>();
            this.tblPrislisterPrBladPrUges = new HashSet<tblPrislisterPrBladPrUge>();
            this.tblPrislisterPrBladPrÅr = new HashSet<tblPrislisterPrBladPrÅr>();
        }

        public int BladID { get; set; }
        public string Navn { get; set; }
        public string Navn2 { get; set; }
        public string Adresse { get; set; }
        public string Adresse2 { get; set; }
        public Nullable<int> PostNr { get; set; }
        public string Tlf { get; set; }
        public string Fax { get; set; }
        public string CVR { get; set; }
        public string FIK { get; set; }
        public string Kontaktperson { get; set; }
        public Nullable<byte> HovedgruppeID { get; set; }
        public Nullable<byte> MedlemMåned { get; set; }
        public Nullable<byte> MedlemÅr { get; set; }
        public Nullable<System.DateTime> MedlemSiden { get; set; }
        public string Ejerforhold { get; set; }
        public string Koncern { get; set; }
        public bool Ophørt { get; set; }
        public bool VisPåWWW { get; set; }
        public Nullable<byte> RegionID { get; set; }
        public Nullable<byte> DelOmrådeID { get; set; }
        public string DiMPDelOmrådeKode { get; set; }
        public Nullable<byte> GeoKodeID { get; set; }
        public Nullable<int> Totalområde { get; set; }
        public Nullable<byte> TotalområdePct { get; set; }
        public Nullable<int> Primær { get; set; }
        public Nullable<byte> PrimærPct { get; set; }
        public string WWWDækningSomTekst { get; set; }
        public Nullable<int> Oplag { get; set; }
        public Nullable<byte> UgedagID { get; set; }
        public string Format { get; set; }
        public string OrdredeadlineTekst { get; set; }
        public string OrdredeadlineRubrik { get; set; }
        public string MaterialedeadlineTekst { get; set; }
        public string MaterialedeadlineRubrik { get; set; }
        public string OrdreEmail { get; set; }
        public string OrdrecheckEmail { get; set; }
        public Nullable<byte> OrdrecheckSendeDagID { get; set; }
        public string SendetidOrdrecheck { get; set; }
        public Nullable<bool> SendIndeværendeUge { get; set; }
        public string StamdataEmail { get; set; }
        public string PrisforespørgselEmails { get; set; }
        public string OrienteringEmails { get; set; }
        public string Emails { get; set; }
        public string KontaktpersonerEmails { get; set; }
        public string BogholderiEmails { get; set; }
        public string BogholderiKontaktperson { get; set; }
        public string MedieNetKode { get; set; }
        public Nullable<byte> MatGodtBeløb { get; set; }
        public string Hjemmeside { get; set; }
        public string RedaktionEmail { get; set; }
        public string AnnonceEmail { get; set; }
        public string MaterialeEmail { get; set; }
        public string AnnonceKontrolEmail { get; set; }
        public string BilagsbladeEmail { get; set; }
        public int FakturaGruppeID { get; set; }
        public Nullable<int> SalgsGruppeID { get; set; }
        public string GruppeRabat { get; set; }
        public string SamannonceringsRabat { get; set; }
        public Nullable<bool> MåGiveFarveRabat { get; set; }
        public bool GiverWebTillæg { get; set; }
        public Nullable<byte> OrdreDeadlineTekstDag { get; set; }
        public string OrdreDeadlineTekstKl { get; set; }
        public Nullable<byte> MaterialeDeadlineTekstDag { get; set; }
        public string MaterialeDeadlineTekstKl { get; set; }
        public Nullable<byte> OrdreDeadlineRubrikDag { get; set; }
        public string OrdreDeadlineRubrikKl { get; set; }
        public Nullable<byte> MaterialeDeadlineRubrikDag { get; set; }
        public string MaterialeDeadlineRubrikKl { get; set; }
        public bool Overført { get; set; }
        public byte[] timestamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMedIGruppe> tblMedIGruppes { get; set; }
        public virtual tblDage tblDage { get; set; }
        public virtual tblDage tblDage1 { get; set; }
        public virtual tblDelOmråde tblDelOmråde { get; set; }
        public virtual tblGeoKode tblGeoKode { get; set; }
        public virtual tblHovedGruppe tblHovedGruppe { get; set; }
        public virtual tblPostNr tblPostNr { get; set; }
        public virtual tblRegion tblRegion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMedieplanLinjer> tblMedieplanLinjers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    
        [System.Runtime.Serialization.IgnoreDataMember]
        public virtual ICollection<Prisers> tblPrisers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPrislisterPrBladPrUge> tblPrislisterPrBladPrUges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<tblPrislisterPrBladPrÅr> tblPrislisterPrBladPrÅr { get; set; }
    }
}
