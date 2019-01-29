using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class KontaktService: IKontaktService
    {
        private KontaktDao _kontaktDao;

        public KontaktService()
        {
            _kontaktDao = new KontaktDao();
        }
        public string GetKontakterPrBlad(int bladid)
        {
            return _kontaktDao.GetKontakterPrBlad(bladid);
        }

        public string GetKontaktTitler()
        {
            return _kontaktDao.GetKontaktTitler();
        }

        public string GetKontakterArbOmråderKontkter()
        {
            return _kontaktDao.GetKontakterArbOmråderKontkter();
        }
    }
}