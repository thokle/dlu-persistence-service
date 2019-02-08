using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class StamBladController : NancyModule

    {
        public StamBladController(StamBladService stamBladDao)

        {
            Get("{id:int}", parametes =>
            {
                int bladid = parametes.id;
                return stamBladDao.GetStamBladById(bladid);
            });

            Get("/stamblad/postnr/{postnr:int}", parameter => { return stamBladDao.GetStamBladByPostNummer(parameter.postnr); });

            Get("/stamblad/navn/{name:string}", parameter => stamBladDao.GetStamBladByName(parameter.name));


            Post("/stamblad", o =>
            {
                var JSOn = this.Bind<tblBladStamdata>();
                stamBladDao.CreaateOrUpdateStamBlad(JSOn);
                return Response.AsJson(JSOn);
            });

            Get("/stamblad/GeoCodes", o => { return stamBladDao.GetTableGeoCode(); });

            Get("/stamblad/allpostnr", o => { return stamBladDao.GetTablePostNr(); });

            Get("/stamblad/postnrsog", o => { return stamBladDao.GetTablePostNrSøgning(); });

            Get("/stamblad/regions", o => { return stamBladDao.GetTableRegion(); });


            Get("/stamblad/dage", o => { return stamBladDao.GetTableDage(); });
        }
    }
}