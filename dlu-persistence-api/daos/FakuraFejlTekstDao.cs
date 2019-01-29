using System.ComponentModel.Design;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class FakuraFejlTekstDao
    {
        private DiMPdotNetEntities _entities;

        public FakuraFejlTekstDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }
        
        public  string GetFejlTekster()
        {
            var res = from fm in _entities.tblFakturaFejlTeksts
                orderby fm.FejlTekst
                select new
                {
                    fm.FejlTekst, fm.FejlKode

                };

            return JsonConvert.SerializeObject(res, Formatting.Indented);
        }
        
        public Task<int> CreateOrUpDate(tblFakturaFejlTekst tblFakturaFejlTekst)
        {
            _entities.tblFakturaFejlTeksts.AddOrUpdate(tblFakturaFejlTekst);
            return _entities.SaveChangesAsync();
        }
    }
}