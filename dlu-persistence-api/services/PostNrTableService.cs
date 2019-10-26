using dlu_persistence_api.daos;

namespace dlu_persistence_api.services
{
    public class PostNrTableService 
    {
        private  PostNrTableDao _dao;

        public PostNrTableService()
        {
            _dao = new PostNrTableDao();
        }

      

        public string GetPostNrAfByNavn(string bynavn)
        {
            return _dao.GetPostNrAfByNavn(bynavn);
        }

        public string GetByBYPostNr(int postnr)
        {
            return _dao.GetByBYPostNr(postnr);
        }
    }
}