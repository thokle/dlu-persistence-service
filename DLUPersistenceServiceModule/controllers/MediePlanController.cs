using System;
using Nancy;
using dlu_persistence_api.daos;
using dlu_persistence_api.models;
namespace DLUPersistenceServiceModule.controllers
{
    public class MediePlanController: NancyModule
    {
        private const bool RunAsync = true;

        public MediePlanController(MediePlanDao dao):base()
        {
            Get("/{userid:int}",  ( parameters) =>
            {
                var userId = (int)parameters.userid;
                return  dao.GetMediePlanByNumber(userId);
           });
        }
    }
}
