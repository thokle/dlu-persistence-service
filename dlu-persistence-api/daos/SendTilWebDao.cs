using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class SendTilWebDao
    {
        private DiMPdotNetDevEntities entities;
    
        public SendTilWebDao()
        {
            entities = new DiMPdotNetDevEntities();
        }


        public int GetAviserTilWeb()
        {
            return entities.tblBladStamdatas.Where(h => h.HovedgruppeID < 2).Where(h => h.Ophørt == false).Where(v => v.VisPåWWW == true).ToList().Count();

        }

        public List<SendTilWeb> GetBladeTilWeb()
        {

            try
            {
                return entities.tblBladStamdatas.Where(h => h.HovedgruppeID < 2).Where(o => o.Ophørt == false).Where(v => v.VisPåWWW == true).Select(s => new SendTilWeb()
                {
                    BladID = s.BladID,
                    Tlf = s.Tlf,
                    StamdataEmail = s.StamdataEmail
                }).ToList();
            } catch(SqlException e)
            {
                throw new Exception(e.Message);
            }
        
        }

        public List<SendTIlWebBladDaekning> GetBladDaeknbingByBladId(int bladid)
        {
            try
            {
                return entities.Database.SqlQuery<SendTIlWebBladDaekning>("SELECT tblBladDækning.PostNr, tblPostNr.PostBy FROM tblBladDækning INNER JOIN tblPostNr ON tblBladDækning.PostNr = tblPostNr.PostNr WHERE(tblBladDækning.BladID =@bladID) ORDER BY tblBladDækning.PostNr", new SqlParameter("bladID", bladid)).ToList();

                } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateDækningstekst(int BladID, string dækingtekst)
        {
            try
            {
                var blad = entities.tblBladStamdatas.Where(b => b.BladID == BladID).FirstOrDefault();
                blad.WWWDækningSomTekst = dækingtekst;

                entities.tblBladStamdatas.AddOrUpdate(blad);
        return        entities.SaveChanges();


            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
                  }

        public int UpdateTlf(string tlf, int bladid)
        {
            try
            {
                var blad = entities.tblBladStamdatas.Where(b => b.BladID == bladid).FirstOrDefault();
                blad.Tlf = tlf;

                entities.tblBladStamdatas.AddOrUpdate(blad);
                return entities.SaveChanges();


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BladMMPris> GetBladMMPris(int år , int bladid, string prislistenavn, int placeringsid)
        {
            try
            {
                return entities.Database.SqlQuery<BladMMPris>("SELECT tblPriser.mmPris as MmPris FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE (tblPriser.BladID =@BladID ) AND (tblPriser.År = @År )" +
                                                              "  AND (tblPriser.PlaceringID = @placeringId) AND (tblPriser.FormatFra < 2) AND (tblPrislister.PrislisteNavn =@prislisteNavn)", 
                                                              new SqlParameter("BladID", bladid),
                                                              new SqlParameter("År", år), 
                                                              new SqlParameter("placeringId", placeringsid),
                                                              new SqlParameter("prislisteNavn", prislistenavn)).ToList();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BladFarvePris> GetBladFarvePris(int år, int bladid, string prislistenavn)
        {
            try
            {
                return entities.Database.SqlQuery<BladFarvePris>("SELECT tblPriser.FarvePris FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE(tblPriser.BladID =@BladID) AND(tblPriser.År =@År) AND(tblPriser.PlaceringID = 1) AND(tblPriser.FormatFra < 2) AND(tblPrislister.PrislisteNavn =@prislisteNavn ",
                                                              new SqlParameter("BladID", bladid),
                                                              new SqlParameter("År", år),
                                                             
                                                              new SqlParameter("prislisteNavn", prislistenavn)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BladFarve4Pris> GetBladFarve4Pris(int år, int bladid, string prislistenavn)
        {
            try
            {
                return entities.Database.SqlQuery<BladFarve4Pris>("SELECT tblPriser.Farve4Pris FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE(tblPriser.BladID =@BladID) AND(tblPriser.År =@År) AND(tblPriser.PlaceringID = 1) AND(tblPriser.FormatFra < 2) AND(tblPrislister.PrislisteNavn =@prislisteNavn ",
                                                              new SqlParameter("BladID", bladid),
                                                              new SqlParameter("År", år),

                                                              new SqlParameter("prislisteNavn", prislistenavn)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BladFarveMin> GetBladFarveMin(int år, int bladid, string prislistenavn)
        {
            try
            {
                return entities.Database.SqlQuery<BladFarveMin>("SELECT tblPriser.FarveMin FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE(tblPriser.BladID =@BladID) AND(tblPriser.År=@År) AND(tblPriser.PlaceringID = 1) AND(tblPriser.FormatFra < 2) AND(tblPrislister.PrislisteNavn =@prislisteNavn ",
                                                              new SqlParameter("BladID", bladid),
                                                              new SqlParameter("År", år),
                                                              new SqlParameter("prislisteNavn", prislistenavn)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<BladFarve4Min> GetBladFarve4Min(int år, int bladid, string prislistenavn)
        {
            try
            {
                return entities.Database.SqlQuery<BladFarve4Min>("SELECT tblPriser.Farve4Min FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE(tblPriser.BladID =@BladID) AND(tblPriser.År=@År) AND(tblPriser.PlaceringID = 1) AND(tblPriser.FormatFra < 2) AND(tblPrislister.PrislisteNavn =@prislisteNavn ",
                                                              new SqlParameter("BladID", bladid),
                                                              new SqlParameter("År", år),
                                                              new SqlParameter("prislisteNavn", prislistenavn)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BladFarveMax> GetBladBladFarveMax(int år, int bladid, string prislistenavn)
        {
            try
            {
                return entities.Database.SqlQuery<BladFarveMax>("SELECT tblPriser.FarveMax FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE(tblPriser.BladID =@BladID) AND(tblPriser.År=@År) AND(tblPriser.PlaceringID = 1) AND(tblPriser.FormatFra < 2) AND(tblPrislister.PrislisteNavn =@prislisteNavn ",
                                                              new SqlParameter("BladID", bladid),
                                                              new SqlParameter("År", år),
                                                              new SqlParameter("prislisteNavn", prislistenavn)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BladFarve4Max> GetBladBladFarve4Max(int år, int bladid, string prislistenavn)
        {
            try
            {
                return entities.Database.SqlQuery<BladFarve4Max>("SELECT tblPriser.Farve4Max FROM tblPriser INNER JOIN tblPrislister ON tblPriser.PrislisteID = tblPrislister.PrislisteID WHERE(tblPriser.BladID =@BladID) AND(tblPriser.År=@År) AND(tblPriser.PlaceringID = 1) AND(tblPriser.FormatFra < 2) AND(tblPrislister.PrislisteNavn =@prislisteNavn ",
                                                              new SqlParameter("BladID", bladid),
                                                              new SqlParameter("År", år),
                                                              new SqlParameter("prislisteNavn", prislistenavn)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


    public class SendTilWeb
    {
        public int BladID { get; set; }
        public string Tlf { get; internal set; }
        public string StamdataEmail { get; internal set; }
    }
    public class SendTIlWebBladDaekning

    {
        private int postnr;
        private string postby;

        public int Postnr { get => postnr; set => postnr = value; }
        public string Postby { get => postby; set => postby = value; }
    }

    public class BladMMPris
    {
        private Decimal mmPris;

        public decimal MmPris { get => mmPris; set => mmPris = value; }
    }
    public class BladFarvePris
    {

        private Decimal farvePris;

        public decimal FarvePris { get => farvePris; set => farvePris = value; }
    }

    public class BladFarve4Pris
    {

        private Decimal farve4Pris;

        public decimal Farve4Pris { get => farve4Pris; set => farve4Pris = value; }
    }

    public class BladFarveMin
    {

        private Decimal farveMin;

        public decimal FarveMin { get => farveMin; set => farveMin = value; }
    }

    public class BladFarve4Min
    {

        private Decimal farve4Min;

        public decimal Farve4Min { get => farve4Min; set => farve4Min = value; }
    }


    public class BladFarveMax
    {

        private Decimal farveMax;

        public decimal FarveMax { get => farveMax; set => farveMax = value; }
    }

    public class BladFarve4Max
    {

        private Decimal farve4Max;

        public decimal Farve4Max { get => farve4Max; set => farve4Max = value; }
    }
}
