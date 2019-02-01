using System;
using System.Data.Entity.Migrations;

using System.Linq;

using System.Threading.Tasks;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;

namespace dlu_persistence_api.daos
{
    public class FakturingsBilagDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public FakturingsBilagDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }


        public string GetFakturingsBilagByMedieId(int medieId)
        {
            try
            {
                var res = from fb in _entities.tblFaktureringsBilags
                    where fb.MedieplanNr == medieId
                    orderby fb.MedieplanNr
                    select new
                    {
                        fb.MedieplanNr, fb.Oprettet, fb.Tekst, fb.BemærkningNr, fb.ErRettet, fb.OprettetAf,
                        fb.RettetAf, fb.RettetKl, fb.UgeavisNavn
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("GetFakturingsBilagByMedieId " , e.InnerException);
            }
        }

        public string GetFakturingsBilagByOprettetAf(string oprettetAf)
        {
            try
            {
                var res = from fb in _entities.tblFaktureringsBilags
                    where fb.OprettetAf == oprettetAf
                    orderby
                        fb.OprettetAf
                    select new
                    {
                        fb.MedieplanNr, fb.Oprettet, fb.Tekst, fb.BemærkningNr, fb.ErRettet, fb.OprettetAf,
                        fb.RettetAf, fb.RettetKl, fb.UgeavisNavn
                    };
                return JsonConvert.SerializeObject(res, formatting: Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("GetFakturingsBilagByOprettetAf ", e.InnerException);
            }
        }

        public Task<int> OpretFakturingsBilag(tblFaktureringsBilag tblFaktureringsBilag)
        {
            try
            {
                _entities.tblFaktureringsBilags.AddOrUpdate(tblFaktureringsBilag);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw  new FormatException(e.Message);
            }
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}