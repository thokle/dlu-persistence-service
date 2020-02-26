using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class PriserService

    {

        private PriserDao _dao;

        public PriserService()
        {
            _dao = new PriserDao();

        }




        public int CreateOrUpdatePrisListePrBladPrÅr(tblPrislisterPrBladPrÅr tbl)
        {
            return _dao.CreateOrUpdatePrisListePrBladPrÅr(tbl);
        }





        public int CreatePrice(tblPriser tblPriser)
        {
            return _dao.CreatePrice(tblPriser);
        }






        public int AddPriserPrUge(int bladid, int prislisteId, int yearParameter)
        {
            return _dao.AddPriserPrUge(bladid, prislisteId, yearParameter);
        }

        public Task<int> UpdateWeekListId(tblPrislisterPrBladPrUge tblPrislisterPrBladPrUge)
        {
            return _dao.UpdateWeekListId(tblPrislisterPrBladPrUge);
        }

        public int DeletePris(int bladid, int placeringId, int prislisteid, int year)
        {
            return _dao.DeletePris(bladid, placeringId, prislisteid, year);
        }






    }
}