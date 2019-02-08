
using dlu_persistence_api.services;
using Nancy;
using  Nancy.ModelBinding;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class PostNrTableController: NancyModule

    {
    public PostNrTableController(PostNrTableService service)
    {
        Get("/postnr/getall", o => service.GetPostNrListe());
    }
    }
}