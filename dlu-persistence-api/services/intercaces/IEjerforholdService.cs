using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IEjerforholdService
    {
        string GetEjerforold();
        Task<int> CreateOrUpDateEjerforhold(tblEjerforhold tblEjerforhold);
    }
}