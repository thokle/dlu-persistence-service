using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;
using System.Linq;

namespace DLUPersistenceServiceModule.controllers

{
    public class UserController : NancyModule
    {
        public UserController(UserService service)
        {
            Get("/user/login", u =>
            {
                var username = Request.Headers["username"].SingleOrDefault().ToString();
                var password = Request.Headers["password"].SingleOrDefault().ToString();
                return service.GetUserbyEmailAndPassword(username, password);
            });

            Post("/user/create", o =>
            {

                var user = this.Bind<User>();
                return service.CreateUser(user);
            });
        }
    }
}