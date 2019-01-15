using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Markup;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace dlu_persistence_api.daos
{
    public class PriserDao: IDisposable
    {
        private DiMPdotNetEntities di;

        public PriserDao()
        {
            di = new DiMPdotNetEntities();
        }


        public string GetPrislisterPrÅrByBladId(int bladid)
        {
            var res = from p in di.tblPrislisterPrBladPrÅr
                where p.BladID == bladid
                select new
                {
                    tblPrislister = from ps in di.tblPrisers where ps.BladID == bladid select new { }
                };
            return JsonConvert.SerializeObject(res);
        }

        public string GetPrisLigePrUge(int bladId)
        {
            var res = from p in di.tblPrislisterPrBladPrUges
                where p.BladID == bladId
                select new
                {
                    p.PrislisteID, p.Uge, p.År, p.BladID
                };
            return JsonConvert.SerializeObject(res);
        }

        public Task<int> CreateOrUpdatePrisListePrBladPrÅr(tblPrislisterPrBladPrÅr tbl)
        {
            di.tblPrislisterPrBladPrÅr.AddOrUpdate(tbl);
            return di.SaveChangesAsync();
        }

        public string GetPrisLister()
        {

            var res = from p in di.tblPrislisters
                orderby p.PrislisteNavn
                select new
                {
                    PrislisteID = p.PrislisteID,
                    PrislisteNavn = p.PrislisteNavn

                };
            return JsonConvert.SerializeObject(res);
        }

        public Task<int> AddPriserPrUge(string bladid)
        {
            var numnberofWeeksInYear = GetWeeksInYear(2019);

            for (int i = 1; i < numnberofWeeksInYear; i++)
            {
                var tblPrislisterPrBladPrUge = new tblPrislisterPrBladPrUge();
                tblPrislisterPrBladPrUge.Uge = i;
                tblPrislisterPrBladPrUge.BladID = bladid;
                tblPrislisterPrBladPrUge.PrislisteID = 1;
                di.tblPrislisterPrBladPrUges.Add(tblPrislisterPrBladPrUge)
            }

         return   di.SaveChangesAsync();
        }
        
        public int GetWeeksInYear(int year)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime date1 = new DateTime(year, 12, 31);
            Calendar cal = dfi.Calendar;
            return  cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, 
                dfi.FirstDayOfWeek);
        }
        public void Dispose()
        {
            di?.Dispose();
        }
    }
}