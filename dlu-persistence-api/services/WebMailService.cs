using dlu_persistence_api.daos;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public class WebMailService : IWebMailService
    {

        private WebMailDao _weBeMailDao;

        public WebMailService()
        {
            _weBeMailDao = new WebMailDao();

        }
        public WebMail GetWebMailByMail(string email)
        {
            return _weBeMailDao.GetWebMailByMail(email);
        }

        public string GetWebMailByPersonNavn(string personnavn)
        {

            return _weBeMailDao.GetWebMailByPersonNavn(personnavn);
        }

        public Task<int> CreateOrUpdate(tblWEBeMail mail)
        {
            return _weBeMailDao.CreateOrUpdate(mail);
        }
    }
}

