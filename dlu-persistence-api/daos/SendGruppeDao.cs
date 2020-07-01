using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    public class SendGruppeDao
    {

        private DiMPdotNetDevEntities devEntities;

        public SendGruppeDao()
        {
            devEntities = new DiMPdotNetDevEntities();
        }

        public SendeGruppe GetSendGruppeByBladId(int id)
        {
            try
            {


               return devEntities.Database.SqlQuery<SendeGruppe>("SELECT  top(1)    tblGrupper.GruppeNavn as Gruppe " +
                                                            " FROM  tblGrupper INNER JOIN " +
                             " tblMedIGruppe ON tblGrupper.GruppeID = tblMedIGruppe.GruppeID AND tblGrupper.Version = tblMedIGruppe.Version INNER JOIN " +
                        "  tblBladStamdata ON tblMedIGruppe.ID = tblBladStamdata.BladID  where tblBladStamdata.BladID = @bladid", new SqlParameter("bladid", id)).ToList().FirstOrDefault();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            }
    }

    public class SendeGruppe
    {

        private string gruppe;

        public string Gruppe { get => gruppe; set => gruppe = value; }
    }
}
