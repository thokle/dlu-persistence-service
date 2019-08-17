using System.Threading.Tasks;
using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class MediePlanService: IMediePlanService
    {
        private MediePlanDao _mediePlanDao;

        public MediePlanService()
        {
            _mediePlanDao =  new MediePlanDao();
           
        }
      
        public string GetMediePlanByKontakt(string name)
        {
            return _mediePlanDao.getMediePlanByKontaktPerson(name);
        }

        public Task<int> CreateOrUpdate(tblMedieplan tblMedieplan)
        {
            return _mediePlanDao.CreateOrUpdateMediePlan(tblMedieplan);

        }

        public string GetAvisTilMediePlan(int bladid)
        {
            return _mediePlanDao.GetAvisTilMediePlan(bladid);
        }

        public string getMediePlanByKontaktPerson(string name)
        {
            return _mediePlanDao.getMediePlanByKontaktPerson(name);
        }

        public string GetMediePlanByAnnoncoer(string anoncoer)
        {
            return _mediePlanDao.GetMediePlanByAnnoncoer(anoncoer);
        }

        public string GetMediePlanByNumber(string medieplanNr)
        {
            return _mediePlanDao.GetMediePlanByNumber(medieplanNr);
        }

        public string findMediePlanToolbar(string mediePlan = null, string annnoncør = null, string bureau = null,
            int fraUge = 0, int tilUge = 0, int aar = 0, bool visInAktiveAnnoncer = false,
            int mediePlanCheckBox = false, bool bookingCheckBox = false, bool rtAkCheckBox = false,
            bool faktureing = false)
        {
            return _mediePlanDao.findMediePlanToolbar(mediePlan, annnoncør, bureau, fraUge, tilUge, aar, visInAktiveAnnoncer, mediePlanCheckBox, bookingCheckBox, rtAkCheckBox, faktureing);
        }
    }
}