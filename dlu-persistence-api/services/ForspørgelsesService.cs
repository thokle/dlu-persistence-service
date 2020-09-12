using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.exceptions;

namespace dlu_persistence_api.services
{
   public  class ForspørgelsesService
    {
        private ForspørgelsesDao dao;

        public ForspørgelsesService()
        {
            dao = new ForspørgelsesDao();
        }

        public List<models.WebForspørgelsesLinjer> GetWebForspørgelsesLinjers()
        {
            try
            {
                return dao.GetWebForspørgelsesLinjers();
            } catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }

        }

        public List<models.WebForspørgelses> GetWebForspørgelses()
        {
            try
            {
                return dao.GetWebForspørgelses();
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.WebForspørgelses> GetWebForspørgelsesByKonsulentCode(string konsulentCode)
        {
            try
            {
                return dao.GetWebForspørgelsesByKonsulentCode(konsulentCode);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

    }
}
