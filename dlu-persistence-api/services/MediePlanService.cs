using System;
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

        public Tuple<string, int> CreateOrUpdateMediePlan(tblMedieplan tblMedieplan)
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

        public string  GetMediePlanByNumber(int medieplanNr, int version)
        {
            return _mediePlanDao.GetMediePlanByNumber(medieplanNr, version);
        }

        public string findMediePlanToolbar(int mediePlan = 0, string annnoncør = null, string bureau = null, int fraUge = 0, int tilUge = 0, int aar = 0, bool visInAktiveAnnoncer = false, bool mediePlanCheckBox = false, bool bookingCheckBox = false, bool rtAkCheckBox = false, bool faktureing = false)
        {
            return _mediePlanDao.findMediePlanToolbar(mediePlan, annnoncør, bureau, fraUge, tilUge, aar, visInAktiveAnnoncer, mediePlanCheckBox, bookingCheckBox, rtAkCheckBox, faktureing);
        }

        public Tuple<string, int> GetLatestMedienr()
        {
            return _mediePlanDao.GetLatestMedienr();
        }

      
    }
}