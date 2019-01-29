using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IFakturingBilagService
    {
        string GetFakturingsBilagByMedieId(int medieId);
        string GetFakturingsBilagByOprettetAf(string oprettetAf);
        Task<int> OpretFakturingsBilag(tblFaktureringsBilag tblFaktureringsBilag);
    }
}