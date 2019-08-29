using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IMediePlanLinjerService
    {
        string GetMediePlanLinjerByMedieId(int medieoid);
        int CreateOrUpdateMediePlanLinjer(System.Collections.Generic.List<tblMedieplanLinjer> tblMedieplanLinjer);
    }  
}