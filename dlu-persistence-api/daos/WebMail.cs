namespace dlu_persistence_api.daos
{
    public class WebMail
    {
        public WebMail()
        {
        }

        public int PersonID { get; set; }
        public string eMail { get; set; }
        public string GetWebMailByPersonNavn { get; set; }
        public string PersonNavn { get; internal set; }
    }
}