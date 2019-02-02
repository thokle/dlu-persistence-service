using System;
using System.Globalization;
using System.Linq;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class UgeaviserTilGridDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public UgeaviserTilGridDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }

        public string GetAllUgeAviserGridPostNr(int? postnr)
        {

            try
            {
                var res = from atg in _entities.UgeaviserTilGrids
                    where atg.PostNr == postnr
                    select new
                    {
                        atg.PostBy, atg.Adresse, atg.Adresse2, atg.Fax, atg.Kontaktperson, atg.Navn, atg.Navn2, 
                        atg.Oplag, atg.Tlf, atg.DagNavn, atg.DækningsGrad, atg.GruppeNavn, atg.MaterialedeadlineRubrik,
                        atg.MaterialedeadlineTekst, atg.OrdredeadlineRubrik, atg.OrdredeadlineTekst, atg.PostNr,
                        atg.RegionNavn, atg.BladID, atg.CVR, atg.DelOmrådeNavn, atg.GeoKodeNavn,atg.HovedGruppeNavn, atg.RegionSortKey,
                        atg.DelOmrådeSortKey, atg.HovedGruppeSortKey
                        
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetAllUgeAviserGridPostNr", e.InnerException);
            }
                
          
        }


        public string GetAllUgeAviserByByNavn(string name)
        {
            try
            {
                var res = from atg in _entities.UgeaviserTilGrids
                    where atg.PostBy == name
                    select new
                    {
                        atg.PostBy, atg.Adresse, atg.Adresse2, atg.Fax, atg.Kontaktperson, atg.Navn, atg.Navn2, 
                        atg.Oplag, atg.Tlf, atg.DagNavn, atg.DækningsGrad, atg.GruppeNavn, atg.MaterialedeadlineRubrik,
                        atg.MaterialedeadlineTekst, atg.OrdredeadlineRubrik, atg.OrdredeadlineTekst, atg.PostNr,
                        atg.RegionNavn, atg.BladID, atg.CVR, atg.DelOmrådeNavn, atg.GeoKodeNavn,atg.HovedGruppeNavn, atg.RegionSortKey,
                        atg.DelOmrådeSortKey, atg.HovedGruppeSortKey
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);

            }
            catch (Exception e)
            {
                
                throw new DaoExceptions("GetAllUgeAviserByByNavn",e.InnerException);
            }
        }
        public string GetAllUgerAviser()
        {
            try
            {
                var res = from atg in _entities.UgeaviserTilGrids
                    select new
                    {
                        atg.PostBy, atg.Adresse, atg.Adresse2, atg.Fax, atg.Kontaktperson, atg.Navn, atg.Navn2,
                        atg.Oplag, atg.Tlf, atg.DagNavn, atg.DækningsGrad, atg.GruppeNavn, atg.MaterialedeadlineRubrik,
                        atg.MaterialedeadlineTekst, atg.OrdredeadlineRubrik, atg.OrdredeadlineTekst, atg.PostNr,
                        atg.RegionNavn, atg.BladID, atg.CVR, atg.DelOmrådeNavn, atg.GeoKodeNavn, atg.HovedGruppeNavn,
                        atg.RegionSortKey,
                        atg.DelOmrådeSortKey, atg.HovedGruppeSortKey
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                
                throw new DaoExceptions("GetAllUgerAviser", e.InnerException);
            }   
        }
        
        
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}