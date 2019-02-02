using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IWebMailService
    {
        string GetWebMailByMail(string email);
        string GetWebMailByPersonNavn(string personnavn);
        Task<int> CreateOrUpdate(tblWEBeMail mail);
    }
}