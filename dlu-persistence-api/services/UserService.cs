using System.Threading.Tasks;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.services
{
    public class UserService: IUserService
    {
        private UserDao _dao;

        public UserService()
        {
            _dao = new UserDao();
        }
        public string GetUserbyEmailAndPassword(string username, string password)
        {

            return _dao.GetUserbyEmailAndPassword(username, password);
        }

        public Task<int> CreateUser(User user)
        {
            return _dao.CreateUser(user);
        }
    }
}