using dlu_persistence_api.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
   public class NewPriserService : INewPriserService
    {
        private NewPriserDao newPriser;

        public NewPriserService()
        {
            newPriser = new NewPriserDao();
        }

        public List<tableNewPriserMeldtInd> GetPriserDerMeldtInd()
        {
            return newPriser.GetPriserDerMeldtInd();
        }

        public List<tableNewPriserMeldtInd> ResettableNewPriserMeldtInds()
        {
            return newPriser.ResettableNewPriserMeldtInds();
        }

        public int TruncateTable()
        {
            return newPriser.TruncateTable();
        }

        public int UpDateStatus(string email)
        {
            return newPriser.UpDateStatus(email);
        }
        
}
