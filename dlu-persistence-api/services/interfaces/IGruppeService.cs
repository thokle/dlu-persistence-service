using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IGruppeService
    {
        string GetGruppeByGruppeID(int id);
        string GetGruppeByGruppeNavn(string gruppeNavn);
        string GetGruppeByGruppeType(int type);
        Task<int> CreteOrUpdate(tblGrupper tblGrupper);
    }
}