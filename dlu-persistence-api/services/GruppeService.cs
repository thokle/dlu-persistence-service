using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class GruppeService: IGruppeService
    {
        private GrupperDao _dao;

        public GruppeService()
        {
            _dao = new GrupperDao();
        }


        public string GetGruppeByGruppeID(int id)
        {

            return _dao.GetGruppeByGruppeID(id);
        }

        public string GetGruppeByGruppeNavn(string gruppeNavn)
        {

            return _dao.GetGruppeByGruppeNavn(gruppeNavn);
        }

        public string GetGruppeByGruppeType(int type)
        {

            return _dao.GetGruppeByGruppeType(type);
        }

        public Task<int> CreteOrUpdate(tblGrupper tblGrupper)
        {
            return _dao.CreteOrUpdate(tblGrupper);
        }
    }
}