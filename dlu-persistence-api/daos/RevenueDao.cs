using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class RevenueDao
    {
        private DiMPdotNetDevEntities entities;

        private static string sql = "SELECT SUM(tblMedieplan.SamletPris) AS Omsætning FROM tblMedieplanNr INNER JOIN tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version WHERE(tblMedieplanNr.Status = 3 OR tblMedieplanNr.Status > 4) AND(tblMedieplan.IndrykningsUge = @uge) AND(tblMedieplan.IndrykningsÅr = @aar)";

        public RevenueDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public Revenue GetRevenue(int uge, int aar)
        {
            try
            {
                return entities.Database.SqlQuery<Revenue>(sql, new SqlParameter("uge", uge), new SqlParameter("aar", aar)).Single<Revenue>();
            }catch(SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex.InnerException);
            }
        }
    }
}
