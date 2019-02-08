using System;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
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

/// <summary>
/// 
/// </summary>
/// <param name="bladid"></param>
/// <returns></returns>
/// <exception cref="DaoExceptions"></exception>
        public string GetPrislisterPrÅrByBladId(int bladid)
        {
            try
            {
                var res = from p in di.tblPrislisterPrBladPrÅr
                    where p.BladID == bladid
                    select new
                    {
                        tblPrislister = from ps in di.tblPrisers where ps.BladID == bladid select new { }
                    };
                return JsonConvert.SerializeObject(res);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("PriserDao GetPrislisterPrÅrByBladId " , e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bladId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetPrisLigePrUge(int bladId)
        {
            try
            {
                var res = from p in di.tblPrislisterPrBladPrUges
                    where p.BladID == bladId
                    select new
                    {
                        p.PrislisteID, p.Uge, p.År, p.BladID
                    };
                return JsonConvert.SerializeObject(res);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetPrisLigePrUge " , e.InnerException);
            }
        }
/// <summary>
/// 
/// </summary>
/// <param name="tbl"></param>
/// <returns></returns>
/// <exception cref="DaoExceptions"></exception>
        public Task<int> CreateOrUpdatePrisListePrBladPrÅr(tblPrislisterPrBladPrÅr tbl)
        {
            try
            {
                di.tblPrislisterPrBladPrÅr.AddOrUpdate(tbl);
                return di.SaveChangesAsync();

            }
            catch (Exception e)
            {
                throw new DaoExceptions("CreateOrUpdatePrisListePrBladPrÅr ", e.InnerException);
            }
        }
/// <summary>
/// 
/// </summary>
/// <returns></returns>
/// <exception cref="DaoExceptions"></exception>
        public string GetPrisLister()
        {
            try
            {
                var res = from p in di.tblPrislisters
                    orderby p.PrislisteNavn
                    select new
                    {
                        p.PrislisteID, p.PrislisteNavn
                    };
                return JsonConvert.SerializeObject(res);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("GetPrisLister",e.InnerException);
            }
        }
/// <summary>
/// 
/// </summary>
/// <param name="bladid"></param>
/// <returns></returns>
/// <exception cref="DaoExceptions"></exception>
        public Task<int> AddPriserPrUge(int bladid)
        {
            try
            {
               var year =  System.DateTime.Today.Year
                var numnberofWeeksInYear = GetWeeksInYear(year);

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
            catch (Exception e)
            {
            throw new DaoExceptions("AddPriserPrUge " , e.InnerException);
            }
          
        }
/// <summary>
/// 
/// </summary>
/// <param name="year"></param>
/// <returns></returns>
        private int GetWeeksInYear(int year)
        {
            var dfi = DateTimeFormatInfo.CurrentInfo;
            var date1 = new DateTime(year, 12, 31);
            var cal = dfi.Calendar;
            return cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                dfi.FirstDayOfWeek);
        }
    }
}