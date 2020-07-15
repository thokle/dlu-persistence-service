namespace dlu_persistence_api.daos
{
    public class StamBladTIlNewPriser
    {
        private string stamdataEmail;
        private int bladID;
        private string navn;

        public string StamdataEmail { get => stamdataEmail; set => stamdataEmail = value; }
        public int BladID { get => bladID; set => bladID = value; }
        public string Navn { get => navn; set => navn = value; }
    }
}