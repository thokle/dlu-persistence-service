using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
   public class SendeGruppeService
    {
        private SendGruppeDao sendGruppe;

        public SendeGruppeService()
        {
            sendGruppe = new SendGruppeDao();

        }


        public SendeGruppe GetSendGruppeByBladId(int id)
        {
            return sendGruppe.GetSendGruppeByBladId(id: id);
        }
    }
}
