using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class WEBSendTilKollegaService : IWEBSendTilKollegaService
    {
        private WEBSendTilKollegaDao _dao;

        public WEBSendTilKollegaService()
        {
            _dao = new WEBSendTilKollegaDao();

        }

        public string WEBSendTilKollegaDaoByPersonID(int personId)
        {
            return _dao.WEBSendTilKollegaDaoByPersonID(personId);
        }

        public string WEBSendTilKollegaDaoByBladID(int bladId)
        {
            return _dao.WEBSendTilKollegaDaoByBladID(bladId);
        }

        public string WEBSendTilKollegaDaoByeMails(string emails)
        {
            return _dao.WEBSendTilKollegaDaoByeMails(emails);
        }

        public Task<int> CreateOrUpdata(tblWEBSendTilKollega tilKollega)
        {
            return _dao.CreateOrUpdata(tilKollega);
        }
    }
}