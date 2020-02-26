
using dlu_persistence_api;
using dlu_persistence_api.models;
using dlu_persistence_api.services;
using Nancy;
using Nancy.Extensions;
using Newtonsoft.Json;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class MediePlanÆnmdringsController : NancyModule
    {
        public MediePlanÆnmdringsController(MediePlanÆndringsService service)
        {
            Get("/mediePlanAendringer/medieid/{medieid}/{version}", o => service.GetMediePlanÆndringerByMedieId(o.medieid, o.version));
            Post("/mediePlanAendringer/create", o =>
            {
                var body = Nancy.IO.RequestStream.FromStream(Request.Body).AsString();
                var res = service.CreateOrUpdate(this.convert(body));

                return Response.AsJson(res);
            });
        }

        private tblMedieplanÆndringer convert(string body)
        {
            var aenderingsTekst = JsonConvert.DeserializeObject<AenderingsTekst>(body);

            var res = new tblMedieplanÆndringer();
            res.MedieplanNr = aenderingsTekst.MedieplanNr;
            res.Version = aenderingsTekst.Version;
            res.ÆndringsTekst = aenderingsTekst.AendringsTekst;
            return res;
        }
    }
}