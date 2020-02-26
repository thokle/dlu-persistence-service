using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
    public interface IPlaceringService
    {
        string GetPlaceringer();
        Task<int> OpretPlacering(tblPlacering tblPlacering);
    }
}