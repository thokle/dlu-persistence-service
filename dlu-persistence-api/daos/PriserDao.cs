using System;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class PriserDao
    {
        private readonly DiMPdotNetDevEntities di;

        public PriserDao()
        {
            di = new DiMPdotNetDevEntities();
           
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bladId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public List<PriceListWeekModel> GetPrisLigePrUge(int bladId, int year)
        {
            try
            {
                var res = from p in di.tblPrislisterPrBladPrUges from u in di.tblPrislisters 
                    where p.BladID == bladId & p.År == year & p.PrislisteID == u.PrislisteID
                    select new PriceListWeekModel()
                    {
                        Uige = p.Uge,
                        AAr = p.År,
                        BladId = p.BladID,
                         PrislisteId = p.PrislisteID,
                         Navn = u.PrislisteNavn
                         

                    };
                return res.ToList<PriceListWeekModel>();
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
        public int CreateOrUpdatePrisListePrBladPrÅr(tblPrislisterPrBladPrÅr tbl)
        {
            try
            {
                di.tblPrislisterPrBladPrÅr.AddOrUpdate(tbl);
                return di.SaveChanges();
                 

            }  catch (Exception e)
            {
                throw new DaoExceptions("CreateOrUpdatePrisListePrBladPrÅr ", e.InnerException);
            }
        }
/// <summary>
/// 
/// </summary>
/// <returns></returns>
/// <exception cref="DaoExceptions"></exception>
        public List<Prislister> GetPrisLister()
        {
            try
            {
                var res = from p in di.tblPrislisters
                    orderby p.PrislisteNavn
                    select new Prislister()
                    {
                       PrislisteID=  p.PrislisteID, PrislisteNavn = p.PrislisteNavn
                    };
                return res.ToList();
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
        public int AddPriserPrUge(int bladid, int prislisteId, int yearParameter)
        {
            try
            {
                var year = 0;
                if (yearParameter == 0)
                {
                     year = System.DateTime.Today.Year;
                } else
                {
                    year = yearParameter;
                }
               
                var numnberofWeeksInYear = GetWeeksInYear(year);

                for (var i = 1; i < numnberofWeeksInYear; i++)
                {
                    var tblPrislisterPrBladPrUge = new tblPrislisterPrBladPrUge
                    {
                        Uge = (byte)i,
                        BladID = bladid,
                        PrislisteID = prislisteId,
                        År = (short)yearParameter
                    
                    };
                    di.tblPrislisterPrBladPrUges.Add(tblPrislisterPrBladPrUge);
                }

                return di.SaveChanges();
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }

        }

    public int CreatePrice(tblPriser tblPriser)
        {
            try
            {
                di.tblPrisers.AddOrUpdate(tblPriser);
          var res = di.SaveChanges();
               
                return res;
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }


        }

    public List<Prislister>  GetPrislister()
        {
            try
            {
                var res = from pl in di.tblPrislisters
                          orderby pl.PrislisteID
                          select new Prislister
                          {
                              PrislisteID = pl.PrislisteID,
                              PrislisteNavn = pl.PrislisteNavn

                          };


                return res.ToList();
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Placering> GetPlacering()
        {
            try
            {
                var res = from pla in di.tblPlacerings
                          orderby pla.PlaceringID
                          select new Placering
                          {
                             PlaceringID =  pla.PlaceringID, Betegenlse =  pla.Betegnelse
                          };
                return res.ToList();
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message);
            }
        }

    

      

        public List<Priser> GetPrislisteFortable(int bladid, int aar, int prislisteId)
        {
            try
            {
                var res = from pl in di.tblPrisers
                          join d in di.tblPrislisters on pl.PrislisteID equals d.PrislisteID into ds
                          from d in ds.DefaultIfEmpty()
                          join pi in di.tblPlacerings on pl.PlaceringID equals pi.PlaceringID into p
                          from pi in p.DefaultIfEmpty()
                          where pl.BladID == bladid & pl.År == aar & pl.PrislisteID == prislisteId  orderby pl.PrislisteID ascending select
                        new Priser
                        {
                            År = pl.År,
                            Betegnelse = pi.Betegnelse,
                            BladID = pl.BladID,
                            Farve4Max = pl.Farve4Max,
                            Farve4Min = pl.Farve4Min,
                            Farve4Pris = pl.Farve4Pris,
                            FarveMax = pl.FarveMax,
                            FarveMin = pl.FarveMin,
                            FarvePris = pl.FarvePris,
                            FormatFra = pl.FormatFra,
                            FormatTil = pl.FormatTil,
                            PrislisteNavn = d.PrislisteNavn,
                          mmPris =   pl.mmPris,
                         PlaceringID = pl.PlaceringID,
                         PrislisteID = pl.PrislisteID,
                    
                         
                    
                        
                       
                            
                         };

                return res.ToList<Priser>();

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

        public Task<int> UpdateWeekListId(tblPrislisterPrBladPrUge tblPrislisterPrBladPrUge)
        {
             di.tblPrislisterPrBladPrUges.AddOrUpdate(tblPrislisterPrBladPrUge);
            return di.SaveChangesAsync();   
        }


    
        public int DeletePris(int bladid, int placeringId, int prislisteid,  int year)
        {
            try {

              var res =   di.tblPrisers.Where(c => c.BladID == bladid).Where(c => c.PlaceringID == placeringId).Where(c => c.PrislisteID == prislisteid).Where(c => c.År == year).First();
                di.tblPrisers.Remove(res);
                return di.SaveChanges();
                
                } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
 
        

        }

        public BladYear GetCreateYearsFromBladId(int bladid)
        {

            var res = from pu in di.tblPrisers where pu.BladID == bladid select new BladYear() { year = pu.År};

            return res.Single<BladYear>();
        }
    }

   
}