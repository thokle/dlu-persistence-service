using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    public class MateraleøudsendingDao
    {
        
        private DiMPdotNetDevEntities devEntities;

        public MateraleøudsendingDao()
        {
            devEntities = new DiMPdotNetDevEntities();
            devEntities.Configuration.LazyLoadingEnabled = true;
        }
        
        public List<SendMateriale> GetSendMateriales(int medieplan, int version)
        {
            string sql = " SELECT     tblBladStamdata.BladID, tblBladStamdata.Navn, tblMedieplanLinjer.BureauOrdreNr, tblMateriale.FilNavn, CASE WHEN tblMateriale.ErSendt is NULL then 0 else 1 END ErSendt, " +
                    "   tblBladStamdata.MedieNetKode, tblBladStamdata.MaterialeEmail,  tblMateriale.FilSti, CASE WHEN tblMateriale.SkalSendes IS NULL then 0 ELSE 1 end SkalSedes, tblMedieplanLinjer.MaterialeNr " +
 " FROM  tblMedieplanLinjer INNER JOIN "+
 "                 tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID LEFT OUTER JOIN "+
 "                   tblMateriale ON tblMedieplanLinjer.MedieplanNr = tblMateriale.MedieplanNr AND tblMedieplanLinjer.UgeavisID = tblMateriale.UgeavisID " + 
 " WHERE(tblMedieplanLinjer.MedieplanNr = @MedieplanNr) AND(tblMedieplanLinjer.Version = @Version) " +
 " ORDER BY tblBladStamdata.Navn";
         var res =  devEntities.Database.SqlQuery<SendMateriale>(sql, new SqlParameter("MedieplanNr", medieplan), new SqlParameter("Version", version)).ToList();
            return res.ToList();
        }

        
    }

    public class SendMateriale
    {
       public int BladID { get; set; }
        public string Navn { get; set; }
        public string BureauOrdreNr { get; set; }
        public string FilNavn { get; set; }
        public Int32 ErSendt { get; set; }
        public string MedieNetKode { get; set; }
        public string MaterialeEmail { get; set; }
        public string FilSti { get; set; }
        public Int32 SkalSendes { get; set; }
        public string MaterialeNr { get; set; }
    }
}
