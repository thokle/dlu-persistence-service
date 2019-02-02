using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    
    public class UgeAviserTilGridService: IUgeAviserTilGridServive
    {
        private UgeaviserTilGridDao _gridDao;

        public UgeAviserTilGridService()
        {
            _gridDao = new UgeaviserTilGridDao();
        }
        public string GetAllUgeAviserGridPostNr(int? postnr)
        {
            return _gridDao.GetAllUgeAviserGridPostNr(postnr);
        }

        public string GetAllUgeAviserByByNavn(string name)
        {
            return _gridDao.GetAllUgeAviserByByNavn(name);
        }

        public string GetAllUgerAviser()
        {
            return _gridDao.GetAllUgerAviser();
        }
    }
}