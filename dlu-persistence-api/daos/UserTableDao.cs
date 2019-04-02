using System;
using System.Data.Entity.Migrations;
using System.Linq;

using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class User
    {
        private string username;
        private string email;
        private string password;
        private int userId;
        private string firstname;
        private string lastname;
        private string jobfuncion;

        public User(string username, string email, string password, int userId, string firstname, string lastname, string jobfuncion)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.userId = userId;
            this.firstname = firstname;
            this.lastname = lastname;
            this.jobfuncion = jobfuncion;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public int UserId
        {
            get => userId;
            
        }

        public string Firstname
        {
            get => firstname;
            set => firstname = value;
        }

        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }

        public string Jobfuncion
        {
            get => jobfuncion;
            set => jobfuncion = value;
        }
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
                var user = _entities.UserTable2.SingleOrDefault(a => a.Password == password && a.UserName == username);

                var res = new User(user.UserName, user.Email, user.Password, user.UserID, user.firstname, user.lastname, user.jobfunction);

               
         
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
                table2.dateCreated = DateTime.Now;
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