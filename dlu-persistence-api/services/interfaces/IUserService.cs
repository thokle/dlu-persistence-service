using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IUserService
    {
       string  Login(string username, string password);
       Task<int> CreateUser(UserTable2 table2);
    }
}