using System.Threading.Tasks;

namespace dlu_persistence_api.services.interfaces
{
    interface IKommentartService
    {
        string GetKommentarByStamBladId(int bladid);
        Task<int> CreateBladKommentar(tblBladKommentar tblBladKommentar);
    }
}
