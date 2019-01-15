using System.Web.UI.WebControls;
using  Nancy;
using dlu_persistence_api.services;
using dlu_persistence_api;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public class MediePlanLinjerController: NancyModule
    {
        public MediePlanLinjerController(MediePlanLinjerService service) : base("mediePlanlinjer")
        {
            
            Get("{medieid:int}", parameter =>
            {
                var res = service.GetMediePlanLinjerByMedieId(parameter.medieid);

                return res;
            });
            
            Post("create", parameter =>
            {
                var p = this.Bind<tblMedieplanLinjer>();
                    var res =     service.CreateOrUpDate(p);
                return res;
            });
            
            
        }
    }
}