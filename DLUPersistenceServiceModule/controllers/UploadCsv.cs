using dlu_persistence_api;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public class UploadCsv : NancyModule
    {
        public UploadCsv(UpdateBladDaekning daekning)
        {
            Get("/updateBladDaekning", o => daekning.importCSV());
        }


    }
}