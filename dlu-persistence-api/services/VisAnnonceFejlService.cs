using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;

namespace dlu_persistence_api.services
{
  public  class VisAnnonceFejlService
    {
        private VisAnnonceFejlDao visAnnonce;

        public VisAnnonceFejlService()
        {
            visAnnonce = new VisAnnonceFejlDao();
        }

        public List<VisAnnoceFejl> GetVisAnnoceFejls()
        {
            try
            {
                return visAnnonce.GetVisAnnoceFejls();
            } catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }
    }
}
