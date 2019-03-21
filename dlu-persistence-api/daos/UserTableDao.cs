using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public struct User
    {
        private string _username;
        private string _email;
        private string _password;
        private int userId;
    }

    public class UserTableDao
    {
        private DiMPdotNetEntities _entities;

        public UserTableDao()
        {
            _entities = new DiMPdotNetEntities();
            _entities.Configuration.LazyLoadingEnabled = true;
        }

        public string Login(string username, string password)
        {
            try
            {
                var user = _entities.UserTable2.Where(a => a.Password == password && a.UserName == username).SingleOrDefault();

                User res = new User();
                user.Email = user.Email;
                user.Password = user.Password;
                user.UserName = user.UserName;
                user.UserID = user.UserID;
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }

        }


        public Task<int> CreateUser(UserTable2 table2)
        {
            try
            {
                   _entities.UserTable2.AddOrUpdate(table2);
                   return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }
    }
}