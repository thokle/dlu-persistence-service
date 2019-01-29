using dlu_persistence_api;
using  dlu_persistence_api.services;
using Nancy.ModelBinding;
using  Nancy;


namespace DLUPersistenceServiceModule.controllers
{
    public sealed class FakturaFejlTekstController: NancyModule 
    {
        public FakturaFejlTekstController(FakturaFejlTekstService service) : base("fakturaFejlTekst")
        {
            Get("", o => { return service.GetFejlTekster(); });
            Post("", o =>
            {
                var res = this.Bind<tblFakturaFejlTekst>();
                return service.CreateOrUpDate(res);

            });
            
        }
    }
}