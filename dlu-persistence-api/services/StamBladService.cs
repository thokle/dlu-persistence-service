using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class StamBladService: IStamBladService 
    {
        private StamBladsDao dao;

        public StamBladService()
        {
            dao = new StamBladsDao();
        }
        public string GetStamBladById(int id)
        {
            return dao.GetStamDataById(bladId: id);
        }

        public string GetStamBladByName(string name)
        {
            return dao.GetStamBladByName(name: name);
        }

        public string GetStamBladByPostNummer(int postnr)
        {
            return dao.GetStamBladByPostNummer(postNr: postnr);
        }

        public string CreaateOrUpdateStamBlad(tblBladStamdata tblBladStamdata)
        {

            return dao.OpretNytStamBlad(stamData: tblBladStamdata);
        }
    }
}