using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.models;

namespace dlu_persistence_api.services
{
   public class NavisionContactService
    {
        private NavisionContactDao navisionContact;

        public NavisionContactService()
        {
            navisionContact = new NavisionContactDao();
        }



        public NavContact GetNavisinForbyContactId(string contact)
        {
            return navisionContact.GetNavisinForbyContactId(contact);
        }

    }
}
