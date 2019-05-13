using System;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class PriserDao
    {
        private readonly DiMPdotNetEntities di;

        public PriserDao()
        {
            di = new DiMPdotNetEntities();
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
                return JsonConvert.SerializeObject(res, Formatting.Indented);
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
        public Task<int> AddPriserPrUge(int bladid, int prislisteId)
        {
            try
            {
                var year = System.DateTime.Today.Year;
                var numnberofWeeksInYear = GetWeeksInYear(year);

                for (var i = 1; i < numnberofWeeksInYear; i++)
                {
                    var tblPrislisterPrBladPrUge = new tblPrislisterPrBladPrUge
                    {
                        Uge = (byte)i,
                        BladID = bladid,
                        PrislisteID = prislisteId
                    };
                    di.tblPrislisterPrBladPrUges.Add(tblPrislisterPrBladPrUge);
                }

                return di.SaveChangesAsync();
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }

        }

    public Task<int> CreatePrice(tblPriser tblPriser)
        {
            try
            {
                di.tblPrisers.AddOrUpdate(tblPriser);
                return di.SaveChangesAsync();
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }


        }

    public string  GetPrislister()
        {
            try
            {
                var res = from pl in di.tblPrislisters
                          orderby pl.PrislisteID
                          select new
                          {
                              pl.PrislisteID,
                              pl.PrislisteNavn


                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }

        }

        public string GetPlacering()
        {
            try
            {
                var res = from pla in di.tblPlacerings
                          orderby pla.PlaceringID
                          select new
                          {
                              pla.PlaceringID, pla.Betegnelse
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }
        }

        public string GetPriserFromBladId(int bladId)
        {
            try
            {
                var res = from psl in di.tblPrisers
                          where psl.BladID == bladId
                          orderby psl.År
                          select new PriserForBlad
                          {
                              
                              
                            AAr1 = psl.År , BladID1 = psl.BladID, ControlNavn1 = psl.ControlNavn, Farve4Max1 = psl.Farve4Max, Farve4Min1 = psl.Farve4Min, Farve4Pris1 = psl.Farve4Pris, FarveMax1 = psl.FarveMax, FarveMin1 = psl.FarveMin,
                            FarvePris1 = psl.FarvePris, FormatFra1 =psl.FormatFra, FormatTil1 =psl.FormatTil, PlaceringID1 = psl.PlaceringID, PrislisteID1 = psl.PlaceringID
                              
                          };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }
        }

        public string GetPrisListeFromBladidArPlacering(int bladId, int placering, int aar)
        {
            try
            {
                var res = from pl in di.tblPrisers
                          where pl.År == aar & pl.BladID == bladId & pl.PlaceringID == placering
                          select new PriserForBlad
                          {
                              AAr1 = pl.År,
                              BladID1 = pl.BladID,
                              ControlNavn1 = pl.ControlNavn,
                              Farve4Max1 = pl.Farve4Max,
                              Farve4Min1 = pl.Farve4Min,
                              Farve4Pris1 = pl.Farve4Pris,
                              FarveMax1 = pl.FarveMax,
                              FarveMin1 = pl.FarveMin,
                              FarvePris1 = pl.FarvePris,
                              FormatFra1 = pl.FormatFra,
                              FormatTil1 = pl.FormatTil,
                              PlaceringID1 = pl.PlaceringID,
                              PrislisteID1 = pl.PlaceringID

                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);

            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
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