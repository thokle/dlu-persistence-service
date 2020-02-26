using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    public class FakturingsBilagDao
    {
        private DiMPdotNetDevEntities _entities;

        public FakturingsBilagDao()
        {
            _entities = new DiMPdotNetDevEntities();
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
                              fb.MedieplanNr,
                              fb.Oprettet,
                              fb.Tekst,
                              fb.BemærkningNr,
                              fb.ErRettet,
                              fb.OprettetAf,
                              fb.RettetAf,
                              fb.RettetKl,
                              fb.UgeavisNavn
                          };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetFakturingsBilagByMedieId ", e.InnerException);
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
                              fb.MedieplanNr,
                              fb.Oprettet,
                              fb.Tekst,
                              fb.BemærkningNr,
                              fb.ErRettet,
                              fb.OprettetAf,
                              fb.RettetAf,
                              fb.RettetKl,
                              fb.UgeavisNavn
                          };
                return JsonConvert.SerializeObject(res, formatting: Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetFakturingsBilagByOprettetAf ", e.InnerException);
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
                throw new FormattedDbEntityValidationException(e);
            }
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}