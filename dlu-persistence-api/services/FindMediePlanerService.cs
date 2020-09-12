using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
namespace dlu_persistence_api.services
{
   public  class FindMediePlanerService
    {
        private FindMediePlanerDao planerDao;

        public FindMediePlanerService()
        {
            planerDao = new FindMediePlanerDao();
        }

        public List<models.FundneMediePlaner> FindMediePlaner()
        {
            try
            {
                return planerDao.FindMediePlaner();
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNo(string AnnoncørNo, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {
            try
            {
                return planerDao.FillByAnnoncørNo(AnnoncørNo, ugeStart, ugeSlut, år, verisonFra, versionTil, medtagRettelser);
            }catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNoBureauNo(int AnnoncørNo, int BureauNo, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {
            try
            {
                return planerDao.FillByAnnoncørNoBureauNo(AnnoncørNo,BureauNo, ugeStart, ugeSlut, år, verisonFra, versionTil, medtagRettelser);
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByAnnoncørNoBureauNoUgeavisID(int UgeavisID, int AnnoncørNo, int BureauNo, int ugeStart, int ugeSlut, int år, int verisonFra, int versionTil, bool medtagRettelser)
        {
            try
            {
                return planerDao.FillByAnnoncørNoBureauNoUgeavisID(AnnoncørNo,UgeavisID, BureauNo, ugeStart, ugeSlut, år, verisonFra, versionTil, medtagRettelser);
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.FundneMediePlaner> FillByMedieplanNr(int MedieplanNr, int verisonFra, int versionTil, bool medtagRettelser)
        {
            try
            {
                return planerDao.FillByMedieplanNr(MedieplanNr, verisonFra, versionTil, medtagRettelser);
            }
            catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }
    }
}
