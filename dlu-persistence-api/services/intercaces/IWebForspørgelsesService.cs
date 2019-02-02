using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IWebForspørgelsesService
    {
        string GetWebForespørgselByMedieplanNr(int mediePlanNr);
        string GetWebForespørgselByAnnoncørNo(string annoncørid);
        string GetWebForespørgselByMediebureau(string burea);
        Task<int> CreateOrUpdate(tblWEBForespørgsel forespørgsel);
    }
}