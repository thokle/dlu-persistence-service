using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Management.Instrumentation;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class MaterialeDao : IDisposable
    {
        private DiMPdotNetEntities _entities;

        public MaterialeDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }

        public string GetMaterialeByMediaNr(int ma)
        {
            var res = from m in _entities.tblMateriales
                where m.MedieplanNr == ma
                select new
                {
                    m.MedieplanNr, m.ErSendt, m.FilNavn, m.FilSti, m.SkalSendes, m.UgeavisID

                };

            return JsonConvert.SerializeObject(res, Formatting.Indented);

        }

        public Task<int> CreateMateriale(tblMateriale tblMateriale)
        {
            _entities.tblMateriales.AddOrUpdate(tblMateriale);
            return _entities.SaveChangesAsync();
        }

        public void Dispose()
        {
            _entities.Dispose();
        }
    }
}