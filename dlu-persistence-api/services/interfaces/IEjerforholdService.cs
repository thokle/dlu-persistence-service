using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IEjerforholdService
    {
        string GetEjerForholdName(string name);
        Task<int> CreateOrUpDateEjerforhold(tblEjerforhold tblEjerforhold);

        string GetAllEjerforhold();

    }
}