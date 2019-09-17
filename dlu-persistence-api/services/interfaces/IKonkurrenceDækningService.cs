using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IKonkurrenceDækningService
    {
        string GetKomkurrenceDækningPrPostNr(int postnr);
        string GetKonkurrenceDækningPrDaeknngGrad(int daekg);
        Task<int> CreateOrUpdate(tblKonkurrentDækning tblKonkurrentDækning);
        string GetKonkurrenter();
    }
}