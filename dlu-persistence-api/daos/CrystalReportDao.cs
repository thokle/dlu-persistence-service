using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class CrystalReportDao
    {
        private DiMPdotNetDevEntities DiMPdotNetDevEntities;

        public CrystalReportDao()
        {
            DiMPdotNetDevEntities = new DiMPdotNetDevEntities();
        }

        public Report GetReport(int mediePlan, int version)
        {
            try {
                var res = DiMPdotNetDevEntities.Database.SqlQuery<Report>("SELECT NavisionContact.[Invoice Document Type] as InvoiceType FROM tblMedieplan INNER JOIN NavisionContact ON tblMedieplan.BureauNo_ = NavisionContact.No_ WHERE (tblMedieplan.MedieplanNr = &mediePlan ) AND (tblMedieplan.Version = &version)", new SqlParameter("mediePlan", mediePlan), new SqlParameter("version", version));
                return res.SingleOrDefault();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        
        }
    }

    public class Report
    {
        private int invoiceType;

        public int InvoiceType { get =>invoiceType; set => invoiceType = value; }
    }
}
