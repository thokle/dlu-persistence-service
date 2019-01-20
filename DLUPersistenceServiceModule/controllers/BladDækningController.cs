
using System.Web.DynamicData;
using  Nancy;
using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public class BladDækningController: NancyModule
    {
        public BladDækningController(BladDækningService service): base("bladdækning")
        {
         Get("bladid/{bladid:int", o => service.GetBladDækningByBladId(o.bladid));   
         Get("postnr/{postnr:int", o => service.GetBladDækningByPostnr(o.postnr));
         Post("add", async o =>
         {
             var tbl = this.Bind<tblBladDækning>();
           var res = await  service.OpretBladDækning(tbl);
            

         });
        }
    }
}