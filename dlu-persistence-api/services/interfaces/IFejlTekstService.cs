using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IFejlTekstService
    {
        string GetFejlTekstDaoByMedieId(int medieId);
        Task<int> CreateOrUpDateFejlTekst(tblFakturaFejl t);
        string GetFejlodeTekstDaoByAnsvarlig(string ansvartlig);
    }
}