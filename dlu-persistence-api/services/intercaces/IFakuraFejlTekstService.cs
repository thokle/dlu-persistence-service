using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IFakuraFejlTekstService
    {
        string GetFejlTekster();
        Task<int> CreateOrUpDate(tblFakturaFejlTekst tblFakturaFejlTekst);
    }
}