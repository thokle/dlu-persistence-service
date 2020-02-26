namespace dlu_persistence_api.models
{
    public class MediePlanNr
    {
        public int MedieplanNr { get; set; }
        public short AktivVersion { get; set; }
        public byte Status { get; set; }
        public bool SupportBilagVedlagt { get; set; }
        public bool SupportBilagVist { get; set; }
        public string FakturaBemaerkning1 { get; set; }
        public string FakturaBemaerkning2 { get; set; }
        public string FakturaBemaerkning3 { get; set; }
        public bool MaterialeModtaget { get; set; }
        public byte BrugtGruppeVersion { get; set; }
        public bool OverførtFraPrisforespoergsel { get; set; }
        public decimal AnvendtMiljoeTillaeg { get; set; }
        public byte AnvendtPrisberegningVersion { get; set; }
        public string Kommentar { get; set; }
    }
}
