using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class EjeforholdDao
    {
        private DiMPdotNetEntities _entities;

        public EjeforholdDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }


        public string GetEjerforold()
        {
            try
            {
                var res = from ef in _entities.tblEjerforholds
                    orderby ef.Ejerforhold
                    select new
                    {
                        ef.Ejerforhold, ef.EjerforholdID, ef.WebTillægRubrik, ef.WebTillægTekst
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }



        public Task<int> CreateOrUpDateEjerforhold(tblEjerforhold tblEjerforhold)
        {

            _entities.tblEjerforholds.AddOrUpdate(tblEjerforhold);
            return _entities.SaveChangesAsync();
        }
    }
    }
