using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class NewPriserDao
    {
        private DiMPdotNetDevEntities entities;

        public NewPriserDao()
        {
            entities = new DiMPdotNetDevEntities();
        }


        public int TruncateTable()
        {
            try
            {
                 entities.Database.ExecuteSqlCommand("truncate table tableNewPriserMeldtInd");
               return entities.SaveChanges();

            } catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<tableNewPriserMeldtInd> ResettableNewPriserMeldtInds()
        {
            try
            {
                GetAviserForStamData().ForEach(s =>
                {
                    var meldInd = new tableNewPriserMeldtInd();
                    meldInd.BladID = s.BladID;
                    meldInd.ErMeldtInd = false;
                    meldInd.Navn = s.Navn;
                    meldInd.StamBladEmail = s.StamdataEmail;
                      entities.tableNewPriserMeldtInds.AddOrUpdate(meldInd);
                    var res = SavePris(meldInd);
                    
                });

                return entities.tableNewPriserMeldtInds.ToList();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private object SavePris(tableNewPriserMeldtInd meldInd)
        {
            try
            {
                entities.tableNewPriserMeldtInds.AddOrUpdate(meldInd);
                return entities.SaveChanges();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        
        }

 

        public int UpDateStatus(string email)
        {
            try
            {
               return entities.Database.ExecuteSqlCommand("UPDATE tableNewPriserMeldtInd  SET ErMeldtInd = 1  WHERE  StamBladEmail=@email", new SqlParameter("email", email));

            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private List<StamBladTIlNewPriser> GetAviserForStamData()
        {
            try
            {
                return entities.Database.SqlQuery<StamBladTIlNewPriser>("select distinct(a.StamdataEmail) , a.BladID, a.Navn from tblBladStamdata a where a.StamdataEmail is not null and a.StamdataEmail !='' order by a.StamdataEmail;").ToList();

            } catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            }
    }
}
