namespace dlu_persistence_api.models
{
    public class PriceListWeekModel
    {
        public int PrislisteId
        {
            get => prislisteID;
            set => prislisteID = value;
        }

        public int Uige
        {
            get => uige;
            set => uige = value;
        }

        public int AAr
        {
            get => aAr;
            set => aAr = value;
        }

        public int BladId
        {
            get => bladID;
            set => bladID = value;
        }
        public string PrisListeNavn { get => prisListeNavn; set => prisListeNavn = value; }

        private  int prislisteID;
       private int uige;
       private  int aAr;
       private  int bladID;
        private string prisListeNavn;
    }
}