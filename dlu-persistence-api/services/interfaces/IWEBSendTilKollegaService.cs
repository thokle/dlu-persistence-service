using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IWEBSendTilKollegaService
    {
        string WEBSendTilKollegaDaoByPersonID(int personId);
        string WEBSendTilKollegaDaoByBladID(int bladId);
        string WEBSendTilKollegaDaoByeMails(string emails);
        Task<int> CreateOrUpdata(tblWEBSendTilKollega tilKollega);
    }
}