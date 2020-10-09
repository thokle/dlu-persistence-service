using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;

namespace dlu_persistence_api.services
{
   public  class ForspørgelsesService
    {
        private ForspørgelsesDao dao;

        public ForspørgelsesService()
        {
            dao = new ForspørgelsesDao();
        }

        public List<models.WebForspørgelsesLinjer> GetWebForspørgelsesLinjers()
        {
            try
            {
                return dao.GetWebForspørgelsesLinjers();
            } catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }

        }

        public List<models.WebForspørgelses> GetWebForspørgelses()
        {
            try
            {
                return dao.GetWebForspørgelses();
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.WebForspørgelses> GetWebForspørgelsesByKonsulentCode(string konsulentCode)
        {
            try
            {
                return dao.GetWebForspørgelsesByKonsulentCode(konsulentCode);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.Forspørgelser> GetForspørgelsers()
        {
            try
            {
                return dao.GetForspørgelsers();
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }

        }
        public int AfslutForspørgelses(int mediePlanNr)
        {
            try
            {
                return dao.AfslutForspørgelses(mediePlanNr);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdateTableMediePlaneLinjer(int mediePlanNr)
        {
            try
            {
                return dao.UpdateTableMediePlaneLinjer(mediePlanNr);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdateTableMediePlanNr(int mediePlanNR)
        {
            try
            {
                return dao.UpdateTableMediePlanNr(mediePlanNR);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdateTableWebForspørgelses(int mediePlandNr)
        {

            try
            {
                return dao.UpdateTableWebForspørgelses(mediePlandNr);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public List<models.SendRykker> GetForspørgelsers(int forspørgelsesId)
        {
            try
            {
                return dao.GetForspørgelsers(forspørgelsesId);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }


        public PersonId GetPersonId(string email)
        {
            try
            {
                return dao.GetPersonId(email);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int InsertTblWebEmails(string email)
        {
            try
            {
                return dao.InsertTblWebEmails(email);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdateTableWebForspørgelses(int forespørgselID, int AntalUdsendinger)
        {
            try
            {
                return dao.UpdateTableWebForspørgelses(forespørgselID, AntalUdsendinger);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int UpdatseAntalUdsendiger(int AntalUdsendinger, int forespørgselID)
        {
            try
            {
                return dao.UpdatseAntalUdsendiger(AntalUdsendinger, forespørgselID);
            }
            catch (Exception ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public Decimal RunStoredProcedureOpretPrisForspørgelses(int? medieplanNr, string annoncørNo_, string mediebureau, string konsulentCode, byte? antalBlade, string format, byte? antalFarver, byte? placeringID, byte? antalIndrykninger, byte? types, bool? visPlaceringUB, DateTime svarInden, string bemærkning)
        {
            try
            {
                return dao.RunStoredProcedureOpretPrisForspørgelses( medieplanNr,  annoncørNo_,  mediebureau,  konsulentCode,  antalBlade,  format,  antalFarver,  placeringID,  antalIndrykninger,  types,  visPlaceringUB,  svarInden,  bemærkning);
            }
            catch(SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }

        public int RunStoredProcedureOpretForspørgelsesLinjer(int ForespørgselID, int BladID, decimal DLUMmPris, double DLUMmRabat, decimal DLUFarveTillæg, float DLUFarveRabat)
        {
            try
            {
                return dao.RunStoredProcedureOpretForspørgelsesLinjer(ForespørgselID, BladID, DLUMmPris, DLUMmRabat, DLUFarveTillæg, DLUFarveRabat);
            } catch (SqlException ex)
            {
                throw new FormattedDbEntityValidationException(ex);
            }
        }
    }
}
