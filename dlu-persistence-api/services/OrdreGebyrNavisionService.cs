using System.Threading.Tasks;
using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class OrdreGebyrNavisionService: IOrdreGebyrNavisionService
    {

        private OrdreGebyrNavisionDao _navisionDao;

        public OrdreGebyrNavisionService()
        {
            using (_navisionDao = new OrdreGebyrNavisionDao()) ;
        }
       
        public string GetOrderGebyNavisionByOrderId(int orderid)
        {
            return _navisionDao.GetOrderGebyNavisionByOrderId(orderid);
        }

       
      

        public string GetOrderGebyNavisionBySælgerkode(string saelgerkode)
        {
            return _navisionDao.GetOrderGebyNavisionBySælgerkode(saelgerkode);
        }

        public string GetOrderNavisionGebyrByBureau(string burea)
        {
            return _navisionDao.GetOrderNavisionGebyrByBureau(burea);
        }

        public Task<int> CreateOrUpate(tblOrdreGebyrNavision tblOrdreGebyrNavision)
        {
            return _navisionDao.CreateOrUpate(tblOrdreGebyrNavision);
        }
    }
}