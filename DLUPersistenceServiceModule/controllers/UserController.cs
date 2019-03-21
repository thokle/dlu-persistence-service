using System.Linq;
using dlu_persistence_api;
using Nancy.ModelBinding;
using Nancy;
using Nancy.Responses;
using dlu_persistence_api.daos;
namespace DLUPersistenceServiceModule.controllers
{
    public class UserController: NancyModule
    {
        public UserController(UserTableDao dao)
        {
            Get("/user/get/", o =>
            {
                var username = Request.Headers["useranme"].SingleOrDefault().ToString();
                var password = Request.Headers["password"].SingleOrDefault().ToString();
                return dao.Login(username, password);
            } );
            
            Post("/user/create", o =>
            {
                var user = this.Bind<UserTable2>();
                return dao.CreateUser(user);
            });
        }
    }
}