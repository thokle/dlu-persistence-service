using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class NavisiomContactService: INavisiomContactService
    {

        private NavisionContactDao _dao;

        public NavisiomContactService()
        {
         _dao = new NavisionContactDao();
        }
        
        public string GetNavisionContactbySalesPersonId(string salesPersonId)
        {

           return  _dao.GetNavisionContactbySalesPersonId(salesPersonId);
        }
    }
}