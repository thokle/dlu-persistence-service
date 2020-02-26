using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
   public  class ChangeStatusService
    {

        private DiMPdotNetDevEntities entities;

        public ChangeStatusService()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public string ChangeStatus(  int mediePlanNr, int oldversion, int oldstatus, int newVersion, int newStatus){


            var resultat = "";
            try
            {
              var update =   entities.Database.ExecuteSqlCommand("update dbo.tblMedieplanNr set AktivVersion = @newVersion, Status = @newStatus Where MedieplanNr = @mediePlanNr and Status = @oldStatus and AktivVersion = @oldVersion", new SqlParameter("mediePlanNr", mediePlanNr), new SqlParameter("oldversion", oldversion), new SqlParameter("oldstatus", oldstatus), new SqlParameter("newStatus", newStatus), new SqlParameter("newVersion", newVersion));

                var delete = entities.Database.ExecuteSqlCommand("delete dbo.tblMedieplan where Version = @oldVersion and MedieplanNr = @mediePlanNr and Status = @oldstatus;", new SqlParameter("oldVersion", oldversion), new SqlParameter("mediePlanNr", mediePlanNr ), new SqlParameter("oldstatus", oldstatus));
                var delete2 = entities.Database.ExecuteSqlCommand("delete dbo.tblMedieplanLinjer where MedieplanNr = @mediePlanNr and Version = @oldversion", new SqlParameter("mediePlanNr", mediePlanNr), new SqlParameter("oldversion", oldversion));

                if(update==1&& delete == 1 && delete2 == 1)
                {
                    resultat = "MediePlan " + mediePlanNr + " Med version " + oldversion + " og status " + oldstatus + " er  rullet til  version " + newVersion + " status " + newStatus;                 }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return resultat;

        }
    }
}
