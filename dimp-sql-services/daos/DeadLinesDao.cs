using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
              return   dimp.Database.SqlQuery<DeadLine>("SELECT UdkommerIkke, UdgivelsesDato, OrdreDeadline, OrdreTid, MaterialeDeadline, MaterialeTid, Uge FROM tblWEBUdgivelse WHERE (BladID =  @bladid) AND (Linje = @linje)",new SqlParameter("bladid", bladid), new SqlParameter("linje", type)).ToList();
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int CreateDeadLine(tblWEBUdgivelse wEBUdgivelse)
        {
            try
            {
                dimp.tblWEBUdgivelses.AddOrUpdate(wEBUdgivelse);
                return dimp.SaveChanges();
            }catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public class DeadLine
    {
        private bool udkommerIkke;
        private int udgivelsesDato;
        private int ordreDeadline;
        private string ordreTid;
        private int materialeDeadline;
        private string materialeTid;
        private string uge;

        public bool UdkommerIkke { get => udkommerIkke; set => udkommerIkke = value; }
        public int UdgivelsesDato { get => udgivelsesDato; set => udgivelsesDato = value; }
        public int OrdreDeadline { get => ordreDeadline; set => ordreDeadline = value; }
        public string OrdreTid { get => ordreTid; set => ordreTid = value; }
        public int MaterialeDeadline { get => materialeDeadline; set => materialeDeadline = value; }
        public string MaterialeTid { get => materialeTid; set => materialeTid = value; }
        public string Uge { get => uge; set => uge = value; }
    }
}
