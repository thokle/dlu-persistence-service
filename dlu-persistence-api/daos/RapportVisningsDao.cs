using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
  class RapportVisningsDao
    {
        private DiMPdotNetDevEntities entities;

        public RapportVisningsDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        //SELECT NavisionContact.[Invoice Document Type] FROM tblMedieplan INNER JOIN NavisionContact ON tblMedieplan.BureauNo_ = NavisionContact.No_ WHERE (tblMedieplan.MedieplanNr = " & _medieplanNr & ") AND (tblMedieplan.Version = " & _version & ")"

        public int GetInvoiceContactType(int mediePlan, int version)
        {
           return (from mp in entities.tblMedieplans join na in entities.NavisionContacts on mp.BureauNo_ equals na.No_ where mp.MedieplanNr == mediePlan && mp.Version == version select new
            {
                na.Invoice_Document_Type
            }).First().Invoice_Document_Type;
        }  
    }
}
