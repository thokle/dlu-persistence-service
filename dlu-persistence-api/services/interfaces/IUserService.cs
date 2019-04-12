using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IUserService
    {
        string GetUserbyEmailAndPassword(string username, string password);
        Task<int> CreateUser(User user);
    }
}