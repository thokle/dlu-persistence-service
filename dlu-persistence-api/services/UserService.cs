using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class UserService: IUserService
    {
        private UserTableDao  _tableDao;

        public UserService()
        {
            _tableDao = new UserTableDao();
        }
        public string Login(string username, string password)
        {
            return _tableDao.Login(username, password);
        }

        public Task<int> CreateUser(UserTable2 table2)
        {
            return _tableDao.CreateUser(table2);
        }
    }
}