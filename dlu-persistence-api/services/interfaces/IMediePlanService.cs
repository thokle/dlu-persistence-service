using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IMediePlanService
    {
  
        string GetMediePlanByKontakt(string name);
         string getMediePlanByKontaktPerson(string name);
        string GetMediePlanByNumber(string medieplanNr);
        string GetMediePlanByAnnoncoer(string anoncoer);
        Task<int> CreateOrUpdate(tblMedieplan tblMedieplan);
        string findMediePlanToolbar(string mediePlan = null, string annnoncør = null, string bureau = null,
            int fraUge = 0, int tilUge = 0, int aar = 0,
            bool visInAktiveAnnoncer = false, int mediePlanCheckBox = false, bool bookingCheckBox = false,
            bool rtAkCheckBox = false, bool faktureing = false);
    }
}