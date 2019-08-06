using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class UserDao
    {
        private DiMPdotNetDevEntities _entities;

        public UserDao()
        {
            _entities = new DiMPdotNetDevEntities();
            _entities.Configuration.LazyLoadingEnabled = true;
        }


        public string GetUserbyEmailAndPassword(string username, string password)
        {
            try
            {
                var res = from u in _entities.Users  where  u.username.Equals(username) && u.password.Equals(password)select new
                {
                  u.userID,
                  u.firstname,
                  u.lastname,
                  u.middlename,
                  u.username,
                  u.password,
                  u.color
                };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
   
            catch  (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        public Task<int> CreateUser(User user)
        {

            try
            {
                _entities.Users.AddOrUpdate(user);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
         
        }
    }
}