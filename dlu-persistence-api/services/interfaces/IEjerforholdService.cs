using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IEjerforholdService
    {

        Task<int> CreateOrUpDateEjerforhold(tblEjerforhold tblEjerforhold);

        string GetAllEjerforhold();

    }
}