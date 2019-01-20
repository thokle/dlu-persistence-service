using System;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class PriserDao : IDisposable
    {
        private readonly DiMPdotNetEntities di;

        public PriserDao()
        {
            di = new DiMPdotNetEntities();
        }

        public void Dispose()
        {
            di?.Dispose();
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
                    p.PrislisteID, p.PrislisteNavn
                };
            return JsonConvert.SerializeObject(res);
        }

        public Task<int> AddPriserPrUge(int bladid)
        {
            var numnberofWeeksInYear = GetWeeksInYear(2019);

            for (var i = 1; i < numnberofWeeksInYear; i++)
            {
                var tblPrislisterPrBladPrUge = new tblPrislisterPrBladPrUge();
                tblPrislisterPrBladPrUge.Uge = (byte) i;
                tblPrislisterPrBladPrUge.BladID = bladid;
                tblPrislisterPrBladPrUge.PrislisteID = 1;
                di.tblPrislisterPrBladPrUges.Add(tblPrislisterPrBladPrUge);
            }

            return di.SaveChangesAsync();
        }

        public int GetWeeksInYear(int year)
        {
            var dfi = DateTimeFormatInfo.CurrentInfo;
            var date1 = new DateTime(year, 12, 31);
            var cal = dfi.Calendar;
            return cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                dfi.FirstDayOfWeek);
        }
    }
}