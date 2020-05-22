using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class RapportVisningsService
    {
        private RapportVisningsDao rapport;

        public RapportVisningsService()
        {
            rapport = new RapportVisningsDao();
        }

        public int GetInvoiceContactType(int mediePlan, int version)
        {
            return rapport.GetInvoiceContactType(mediePlan, version);
        }
    }
}
