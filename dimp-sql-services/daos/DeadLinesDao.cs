using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
namespace dimp_sql_services.daos
{
    class DeadLinesDao
    {
        private dimpSQLEntities dimp;

        public DeadLinesDao()
        {
            dimp = new dimpSQLEntities();
        }


        public List<DeadLine> GetDeadLine(int bladid , int type)
        {
            try
            {
              return   dimp.Database.SqlQuery<DeadLine>("SELECT BladID, Linje, UdkommerIkke, UdgivelsesDato, OrdreDeadline, OrdreTid, MaterialeDeadline, MaterialeTid, Uge FROM tblWEBUdgivelse WHERE (BladID =  @bladid) AND (Linje = @linje)", new SqlParameter("bladid", bladid), new SqlParameter("linje", type)).ToList();
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int CreateDeadLine(DeadLine wEBUdgivelse)
        {
            try
            {
                var web = new tblWEBUdgivelse()
                {
                    BladID = wEBUdgivelse.BladID,
                    Linje  = wEBUdgivelse.Linje,
                    MaterialeDeadline = wEBUdgivelse.MaterialeDeadline,
                    MaterialeTid = wEBUdgivelse.MaterialeTid,
                    OrdreDeadline = wEBUdgivelse.OrdreDeadline,
                    OrdreTid = wEBUdgivelse.OrdreTid,
                    UdgivelsesDato   = wEBUdgivelse.UdgivelsesDato,
                    UdkommerIkke = wEBUdgivelse.UdkommerIkke,
                    Uge = wEBUdgivelse.Uge

                };
                dimp.tblWEBUdgivelses.AddOrUpdate(web);
                return dimp.SaveChanges();
            }catch (FormattedDbEntityValidationException ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        public int Delete(int bladid, int linje)
        {
            try
            {
               var res= dimp.tblWEBUdgivelses.Where(e => e.BladID == bladid && e.Linje == linje)
                .FirstOrDefault();
              if(res !=null)
                {
                  
                    dimp.tblWEBUdgivelses.Attach(res);
                    dimp.tblWEBUdgivelses.Remove(res);
                }
                
               return dimp.SaveChanges();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }

    public class WEBUdgivelse
    {
        public WEBUdgivelse()
        {
        }

        public int BladID { get; set; }
        public short Linje { get; set; }
        public byte MaterialeDeadline { get; set; }
        public string MaterialeTid { get; set; }
        public byte OrdreDeadline { get; set; }
        public string OrdreTid { get; set; }
        public byte UdgivelsesDato { get; set; }
        public bool UdkommerIkke { get; set; }
        public string Uge { get; set; }
    }

    public class DeadLine
    {
        private int bladID;
        private short linje;
        private bool udkommerIkke;
        private byte udgivelsesDato;
        private byte ordreDeadline;
        private string ordreTid;
        private byte materialeDeadline;
        private string materialeTid;
        private string uge;

        public bool UdkommerIkke { get => udkommerIkke; set => udkommerIkke = value; }
        public byte UdgivelsesDato { get => udgivelsesDato; set => udgivelsesDato = value; }
        public byte OrdreDeadline { get => ordreDeadline; set => ordreDeadline = value; }
        public string OrdreTid { get => ordreTid; set => ordreTid = value; }
        public byte MaterialeDeadline { get => materialeDeadline; set => materialeDeadline = value; }
        public string MaterialeTid { get => materialeTid; set => materialeTid = value; }
        public string Uge { get => uge; set => uge = value; }
        public int BladID { get => bladID; set => bladID = value; }
        public short Linje { get => linje; set => linje = value; }
    }
}
