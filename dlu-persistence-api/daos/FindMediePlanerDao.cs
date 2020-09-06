using DDF_sql_services;
using dlu_persistence_api.exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class FindMediePlanerDao
    {
        private DiMPdotNetDevEntities devEntities;

        public FindMediePlanerDao()
        {
            devEntities = new DiMPdotNetDevEntities();
        }

        public List<models.FundneMediePlaner> FindMediePlaner()
        {
            try
            {
                return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL).ToList();
            }catch(SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNo(string AnnoncørNo, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {
            try
            {
                return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL2,new SqlParameter("AnnoncørNo", AnnoncørNo),  new SqlParameter("ugeStart", ugeStart) , new SqlParameter("ugeSlut", ugeSlut)
                    , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNoBureauNo(string AnnoncørNo, int BureauNo, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {
            try
            {
                return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL3, new SqlParameter("AnnoncørNo", AnnoncørNo), new SqlParameter("BureauNo", BureauNo), new SqlParameter("ugeStart", ugeStart), new SqlParameter("ugeSlut", ugeSlut)
                    , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNoBureauNoKonsulentCode(string KonsulentCode, string AnnoncørNo, int BureauNo, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {
            try
            {
                return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL4,new SqlParameter("KonsulentCode", KonsulentCode), new SqlParameter("AnnoncørNo", AnnoncørNo), new SqlParameter("BureauNo", BureauNo), new SqlParameter("ugeStart", ugeStart), new SqlParameter("ugeSlut", ugeSlut)
                    , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
            } catch (SqlException ex) { 
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNoBureauNoUgeavisID(int UgeavisID, int AnnoncørNo, int BureauNo, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {
            try
            {
                try
                {
                    return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL5,new SqlParameter("AnnoncørNo", AnnoncørNo) ,new SqlParameter("UgeavisID", UgeavisID), new SqlParameter("BureauNo", BureauNo), new SqlParameter("ugeStart", ugeStart), new SqlParameter("ugeSlut", ugeSlut)
                        , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
                }
                catch (SqlException ex)
                {
                    throw new FormattedDbEntityValidationException(ex);
                }
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNoKonsulentCode(string AnnoncørNo, string KonsulentKode,   int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {

                try
                {
                    return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL6, new SqlParameter("AnnoncørNo", AnnoncørNo),new SqlParameter("KonsulentKode", KonsulentKode) , new SqlParameter("ugeStart", ugeStart), new SqlParameter("ugeSlut", ugeSlut)
                        , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
                }
                catch (SqlException ex)
                {
                    throw new FormattedDbEntityValidationException(ex);
                }   
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNoUgeavisID(int AnnoncørNo, int UgeavisID,  int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {

            try
            {
                return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL7,new SqlParameter("AnnoncørNo", AnnoncørNo), new SqlParameter("UgeavisID", UgeavisID), new SqlParameter("ugeStart", ugeStart), new SqlParameter("ugeSlut", ugeSlut)
                    , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByBureauNo(int BureauNo,  int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {

            try
            {
                return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL8,new SqlParameter("BureauNo", BureauNo) , new SqlParameter("ugeStart", ugeStart), new SqlParameter("ugeSlut", ugeSlut)
                    , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByBureauNoKonsulentCode(int BureauNo,string KonsulentKode, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {

            try
            {
                return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL9, new SqlParameter("KonsulentKode", KonsulentKode) ,  new SqlParameter("BureauNo", BureauNo), new SqlParameter("ugeStart", ugeStart), new SqlParameter("ugeSlut", ugeSlut)
                    , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }


        public List<models.FundneMediePlaner> FillByBureauNoUgeavisID(int BureauNo,int UgeavisID, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {

            try
            {
                return devEntities.Database.SqlQuery<models.FundneMediePlaner>(SQLStringsUtil.SQL10, new SqlParameter("UgeavisID", UgeavisID), new SqlParameter("BureauNo", BureauNo), new SqlParameter("ugeStart", ugeStart), new SqlParameter("ugeSlut", ugeSlut)
                    , new SqlParameter("år", år), new SqlParameter("versionFra", verisonFra), new SqlParameter("versionTil", versionTil), new SqlParameter("medtagRettelser", medtagRettelser)).ToList();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByBureauOrdreNr()
        {
            try
            {
                throw new NotImplementedException();
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByKonsulentCode()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByMedieplanNr()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByStatusIkkeUdsendt()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByUgeavisID()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByUger()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }

        }
    }
}
