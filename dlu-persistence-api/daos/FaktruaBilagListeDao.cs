using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
   public class FaktruaBilagListeDao
    {
        private DiMPdotNetDevEntities entities;

        public FaktruaBilagListeDao()
        {
            entities = new DiMPdotNetDevEntities();
          
        }

        public List<FakturaBiliagModen> GetFakturaBiliagModens()
        {
          var res =  entities.Database.SqlQuery<FakturaBiliagModen>(FakturaBilagListSQL.SQL);
            return res.ToList();
        }
    }

    public class FakturaBiliagModen
    {
        public Int32 MedieplanNr { get; set; }
        public Int16 BemærkningNr { get; set; }
        public string UgeavisNavn { get; set; }
        public DateTime Oprettet { get; set; }
        public string OprettetAf { get; set; }
        public Int16 Version { get; set; }
        public byte IndrykningsUge { get; set; }
        public byte Status { get; set; }
    }

    public class FakturaBilagListSQL
    {

        public static string SQL =
        
             "SELECT tblFaktureringsBilag.MedieplanNr, tblMedieplan.Version, tblFaktureringsBilag.BemærkningNr, tblFaktureringsBilag.UgeavisNavn, tblMedieplan.IndrykningsUge, " +
                       "  tblFaktureringsBilag.Oprettet, tblFaktureringsBilag.OprettetAf, tblMedieplanNr.Status  " +
"FROM            tblFaktureringsBilag INNER JOIN  " +
                        " tblMedieplanNr ON tblFaktureringsBilag.MedieplanNr = tblMedieplanNr.MedieplanNr INNER JOIN " +
                      "   tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version " +
" WHERE(tblFaktureringsBilag.ErRettet = 0)";
        


    }

}
