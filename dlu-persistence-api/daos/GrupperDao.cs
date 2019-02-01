using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class GrupperDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public GrupperDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }
        
        public void Dispose()
        {
            _entities?.Dispose();
        }


        public string GetGruppeByGruppeID(int id)
        {
            try
            {
                var res = from gr in _entities.tblGruppers
                    where gr.GruppeID == id
                    orderby gr.GruppeID
                    select new
                    {
                        gr.GruppeID, gr.timestamp, gr.Version, gr.GruppeNavn, gr.GruppeType, gr.MaterialeModtager,
                        gr.OrdreEmail, gr.AntalBladeForValg, gr.GruppeHovedbladID
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("GetGruppeByGruppeID", e.InnerException);
            }
        }

        public string GetGruppeByGruppeNavn(string gruppeNavn)
        {
            try
            {
                var res = from gr in _entities.tblGruppers
                    where gr.GruppeNavn == gruppeNavn
                    orderby gr.GruppeNavn
                    select new
                    {
                        gr.GruppeID, gr.timestamp, gr.Version, gr.GruppeNavn, gr.GruppeType, gr.MaterialeModtager,
                        gr.OrdreEmail, gr.AntalBladeForValg, gr.GruppeHovedbladID
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetGruppeByGruppeNavn", e.InnerException);
            }
        }

        public string GetGruppeByGruppeType(int type)
        {
            try
            {
                var res = from gr in _entities.tblGruppers
                    where gr.GruppeID == type
                    orderby gr.GruppeNavn
                    select new
                    {
                        gr.GruppeID, gr.timestamp, gr.Version, gr.GruppeNavn, gr.GruppeType, gr.MaterialeModtager,
                        gr.OrdreEmail, gr.AntalBladeForValg, gr.GruppeHovedbladID
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
                
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetGruppeByGruppeType", e.InnerException);
            }
        }

        public Task<int> CreteOrUpdate(tblGrupper tblGrupper)
        {
            _entities.tblGruppers.AddOrUpdate(tblGrupper);
            return _entities.SaveChangesAsync();
        }
       
    }
}