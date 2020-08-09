using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
   public class PrisUdsendingDao
    {
        private DiMPdotNetDevEntities devEntities;

        public PrisUdsendingDao()
        {
            devEntities = new DiMPdotNetDevEntities();
        }

        public List<Udsending> GetAllStambladTilUdsending()
        {
            try
            {
                return devEntities.tblBladStamdatas.Select(s => new Udsending() { StamdataEmail = s.StamdataEmail, Navn = s.Navn, BladID = s.BladID, Ophørt= s.Ophørt }).Where(w => w.Ophørt == false)
                    .GroupBy(g => new { g.StamdataEmail, g.Navn, g.BladID, g.Ophørt })
                    .Select(se => new Udsending() { StamdataEmail = se.Key.StamdataEmail, Navn = se.Key.Navn,  BladID = se.Key.BladID , Ophørt = se.Key.Ophørt}).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public List<Udsending> GetAllStambladTilUdsendingTilDeadlines()
        {
            try
            {
                return devEntities.tblBladStamdatas.Select(s => new Udsending() { StamdataEmail = s.StamdataEmail, Navn = s.Navn, BladID = s.BladID, Ophørt = s.Ophørt }).Where(w => w.Ophørt == false)
                  
                    .Select(se => new Udsending() { StamdataEmail = se.StamdataEmail, Navn = se.Navn, BladID = se.BladID, Ophørt = se.Ophørt }).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }


    }

    public class Udsending
    {
        public string StamdataEmail { get;  set; }
        public string Navn { get;  set; }
        public int BladID { get;  set; }
        public bool Ophørt { get; internal set; }
    }
}
