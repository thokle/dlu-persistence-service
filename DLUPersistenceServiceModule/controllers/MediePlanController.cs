using System;
using dlu_persistence_api;
using Nancy;
using dlu_persistence_api.daos;

namespace DLUPersistenceServiceModule.controllers
{
    public class MediePlanController: NancyModule
    {
        private const bool RunAsync = true;

        public MediePlanController(MediePlanDao dao):base("mediePæan ")
        {
            Get("{userid:int}",   parameters  =>
            {
                var userId = (int)parameters.userid;
                return  Response.AsJson(dao.GetMediePlanByNumber(userId), HttpStatusCode.Accepted );
           });
        }
    }
}
