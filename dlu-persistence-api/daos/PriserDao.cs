using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Markup;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class PriserDao: IDisposable
    {
        private DiMPdotNetEntities di;

        public PriserDao()
        {
            di = new DiMPdotNetEntities();
        }


        public string GetPrislisterPrÅrByBladId(int bladid)
        {
            var res = from p in di.tblPrislisterPrBladPrÅr
                where p.BladID == bladid
                select new
                {
                    tblPrislister = from ps in di.tblPrisers where ps.BladID == bladid select new { }
                };
            return JsonConvert.SerializeObject(res);
        }

        public string GetPrisLigePrUge(int bladId)
        {
            var res = from p in di.tblPrislisterPrBladPrUges
                where p.BladID == bladId
                select new
                {
                    
                };
            return JsonConvert.SerializeObject(res);
        }

        public Task<int> CreateOrUpdatePrisListePrBladPrÅr(tblPrislisterPrBladPrÅr tbl)
        {
            di.tblPrislisterPrBladPrÅr.AddOrUpdate(tbl);
            return di.SaveChangesAsync();
        }

        public string GetPrisLister()
        {

            var res = from p in di.tblPrislisters
                orderby p.PrislisteNavn
                select new
                {
                    PrislisteID = p.PrislisteID,
                    PrislisteNavn = p.PrislisteNavn

                };
            return JsonConvert.SerializeObject(res);
        }

        public void Dispose()
        {
            di?.Dispose();
        }
    }
}