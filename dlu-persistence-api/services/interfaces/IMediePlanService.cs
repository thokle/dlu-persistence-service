using System;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IMediePlanService
    {
  
        string GetMediePlanByKontakt(string name);
         string getMediePlanByKontaktPerson(string name);
        string  GetMediePlanByNumber(int medieplanNr, int version);
        string GetMediePlanByAnnoncoer(string anoncoer);
        Tuple<string, int> CreateOrUpdateMediePlan(tblMedieplan tblMedieplan);
 
        string findMediePlanToolbar(int mediePlan = 0, string annnoncør = null, string bureau = null, int fraUge = 0, int tilUge = 0, int aar = 0,
            bool visInAktiveAnnoncer = false, bool mediePlanCheckBox = false, bool bookingCheckBox = false, bool rtAkCheckBox = false, bool faktureing = false);
        Tuple<string, int> GetLatestMedienr();
    }
}