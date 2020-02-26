using dlu_persistence_api.exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
namespace dlu_persistence_api.daos
{
    public class EjerforholdDao : IDisposable

    {
        private DiMPdotNetDevEntities _entities;

        public EjerforholdDao()
        {
            _entities = new DiMPdotNetDevEntities();


            _entities.Configuration.LazyLoadingEnabled = true;


        }

        public tblEjerforhold GetEjerForholdName(string name)
        {

            try
            {
                var res = from ej in _entities.tblEjerforholds
                          where ej.Ejerforhold == name
                          orderby ej.Ejerforhold
                          select new tblEjerforhold
                          {
                              Ejerforhold = ej.Ejerforhold,
                              EjerforholdID = ej.EjerforholdID,
                              WebTillægRubrik = ej.WebTillægRubrik,
                              WebTillægTekst = ej.WebTillægTekst

                          };
                return res.Single<tblEjerforhold>();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }

        }

        public List<EjerForhold> GetAllEjerforhold()
        {
            try
            {
                var res = from ej in _entities.tblEjerforholds
                          orderby ej.Ejerforhold ascending
                          select new EjerForhold()
                          {
                              Ejerforhold = ej.Ejerforhold,
                              EjerforholdID = ej.EjerforholdID,
                              WebTillægRubrik = ej.WebTillægRubrik,
                              WebTillægTekst = ej.WebTillægTekst

                          };
                return res.ToList<EjerForhold>();
            }
            catch (Exception e)
            {

                throw new FormattedDbEntityValidationException(e.InnerException);
            }


        }
        public Task<int> OpretEjerforhold(tblEjerforhold tblEjerforhold)
        {
            try
            {
                _entities.tblEjerforholds.AddOrUpdate(tblEjerforhold);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}