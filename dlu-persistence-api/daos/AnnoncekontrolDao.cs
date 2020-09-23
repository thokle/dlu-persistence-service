using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{/// <summary>
 /// 
 /// </summary>
    public class AnnoncekontrolDao : IDisposable
    {
        private DiMPdotNetDevEntities _entities;


        public AnnoncekontrolDao()
        {
            _entities = new DiMPdotNetDevEntities();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediePlan"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetAnnoceKontrolByMediePlanId(int mediePlan)
        {

            try
            {
                var res = from an in _entities.tblAnnoncekontrols
                          where an.MedieplanNr == mediePlan
                          select new
                          {

                              an.MedieplanNr,
                              an.Ansvar,
                              an.Fejlkode,
                              an.ErKontrolleret,
                              an.FaktureresTil,
                              an.KontrollørEmail,
                              an.KontrolTidspunkt,
                              an.SidePlacering,
                              an.tblFejlTekst.FejlTekst,
                              an.IndrykketPåSide,
                              an.UgeavisID,
                              an.KontrolleretAfDLU
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);

            }
            catch (Exception a)
            {

                throw new DaoExceptions(" AnnoncekontrolDao GetAnnoceKontrolByMediePlanId", a.InnerException);
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetAnnonceKontrolByEmail(string email)
        {
            try
            {
                var res = from an in _entities.tblAnnoncekontrols
                          where an.KontrollørEmail == email
                          select new
                          {
                              an.MedieplanNr,
                              an.Ansvar,
                              an.Fejlkode,
                              an.ErKontrolleret,
                              an.FaktureresTil,
                              an.KontrollørEmail,
                              an.KontrolTidspunkt,
                              an.SidePlacering,
                              an.tblFejlTekst.FejlTekst,
                              an.IndrykketPåSide,
                              an.UgeavisID,
                              an.KontrolleretAfDLU
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);

            }
            catch (Exception e)
            {
                throw new DaoExceptions(" AnnoncekontrolDao GetAnnonceKontrolByEmail", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblAnnoncekontrol"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Task<int> CreateOrUpdate(tblAnnoncekontrol tblAnnoncekontrol)
        {
            try
            {
             
                _entities.tblAnnoncekontrols.AddOrUpdate(tblAnnoncekontrol);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        public List<AnnoceKontrol> GetSQLAnnoceKontrols()
        {
            try
            {

            return    _entities.Database.SqlQuery<AnnoceKontrol>("SELECT DISTINCT tblBladStamdata.Navn, tblBladStamdata.BladID, tblMedieplan.IndrykningsUge " +
                                                            " FROM tblMedieplanNr INNER JOIN " +
                                                            " tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version INNER JOIN " +
                                                              " tblMedieplanLinjer ON tblMedieplan.Version = tblMedieplanLinjer.Version AND " +
                      " tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr INNER JOIN " +
                      " tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID LEFT OUTER JOIN " +
                      " tblAnnoncekontrol ON tblMedieplanLinjer.MedieplanNr = tblAnnoncekontrol.MedieplanNr AND " +
                      " tblMedieplanLinjer.UgeavisID = tblAnnoncekontrol.UgeavisID " +
                      " WHERE(tblAnnoncekontrol.ErKontrolleret = 0) AND (tblMedieplanNr.Status = 3) " +

                        " ORDER BY tblBladStamdata.Navn, tblMedieplan.IndrykningsUge DESC").ToList();
            }catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<AnnoceKontrol> GetSQLAnnoceKontrolsByWeek(int uge)
        {
            try
            {
                return _entities.Database.SqlQuery<AnnoceKontrol>("SELECT DISTINCT tblBladStamdata.Navn, tblBladStamdata.BladID , tblMedieplan.IndrykningsUge  " +
" FROM         tblMedieplanNr INNER JOIN " +
"  tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND tblMedieplanNr.AktivVersion = tblMedieplan.Version INNER JOIN " +
"  tblMedieplanLinjer ON tblMedieplan.Version = tblMedieplanLinjer.Version AND " +
" tblMedieplan.MedieplanNr = tblMedieplanLinjer.MedieplanNr INNER JOIN " +
" tblBladStamdata ON tblMedieplanLinjer.UgeavisID = tblBladStamdata.BladID LEFT OUTER JOIN " +
" tblAnnoncekontrol ON tblMedieplanLinjer.MedieplanNr = tblAnnoncekontrol.MedieplanNr AND " +
" tblMedieplanLinjer.UgeavisID = tblAnnoncekontrol.UgeavisID " +
" WHERE(tblMedieplan.IndrykningsUge <=@uge) AND(tblMedieplan.IndrykningsÅr = YEAR({ fn NOW() })) AND(tblMedieplanNr.Status = 3) AND " +
" (tblAnnoncekontrol.ErKontrolleret IS NULL) OR " +
" (tblMedieplan.IndrykningsÅr = YEAR({ fn NOW() }) -1) AND(tblMedieplanNr.Status = 3) AND(tblAnnoncekontrol.ErKontrolleret = 0) " +
" ORDER BY tblBladStamdata.Navn, tblMedieplan.IndrykningsUge DESC", new SqlParameter("uge", uge)).ToList();
            } catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}