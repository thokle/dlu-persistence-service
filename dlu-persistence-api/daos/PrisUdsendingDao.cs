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
                return devEntities.tblBladStamdatas.Select(s => new { StamdataEmail = s.StamdataEmail, Navn = s.Navn, BladID = s.BladID, Ophørt= s.Ophørt }).Where(w => w.Ophørt == false)
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
                return devEntities.tblBladStamdatas.Select(s => new { StamdataEmail = s.StamdataEmail, Navn = s.Navn, BladID = s.BladID, Ophørt = s.Ophørt , Ejerforhold = s.Ejerforhold})
                    .GroupBy(g => new { g.Ejerforhold, g.Navn, g.Ophørt, g.StamdataEmail, g.BladID  }).Where(w => w.Key.Ophørt == false)                  
                    .Select(se => new Udsending() {Ejerforhold = se.Key.Ejerforhold,  StamdataEmail = se.Key.StamdataEmail, Navn = se.Key.Navn, BladID = se.Key.BladID, Ophørt = se.Key.Ophørt }).Distinct().ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public List<models.Ejerforhold> GetAllDistinctEjerforhold()
        {
            try
            {
                return devEntities.tblBladStamdatas.Where(s => s.Ophørt == false).Select(s => new models.Ejerforhold() { EjerforholdData = s.Ejerforhold }).Distinct().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public class Udsending
    {
        public string StamdataEmail { get;  set; }
        public string Navn { get;  set; }
        public int BladID { get;  set; }
        public bool Ophørt { get; internal set; }

        public string Ejerforhold { get; set; }
    }
}
