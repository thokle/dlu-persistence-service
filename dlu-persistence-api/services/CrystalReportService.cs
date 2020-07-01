using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
  public  class CrystalReportService
    {
        private CrystalReportDao crystalReport;

        public CrystalReportService()
        {
            crystalReport = new CrystalReportDao();
        }


        public Report GetReport(int mediePlan, int version)
        {
            return crystalReport.GetReport(mediePlan, version);
        }
    }
}
