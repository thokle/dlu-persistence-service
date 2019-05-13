using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class BladTilLaegDAO
    {
        private DiMPdotNetEntities di;

        public BladTilLaegDAO()
        {
            di = new DiMPdotNetEntities();
        }

        public string getBladWebTilaeg(int bladId)
        {
            try
            {
                return "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
