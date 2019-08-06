using System;
using System.Data.Entity.Core.Common;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class StamBladService: IStamBladService 
    {
        private StamBladsDao dao;
      

        public StamBladService()
        {
            dao = new StamBladsDao();
        }
        public string GetStamBladById(int id)
        {
            return dao.GetStamDataById(bladId: id);
        }

        public string GetStamBladByName(string name)
        {
            return dao.GetStamBladByName(name: name);
        }

        public string GetStamBladByPostNummer(int postnr)
        {
            return dao.GetStamBladByPostNummer(postNr: postnr);
        }

        public Tuple<string, int> CreaateOrUpdateStamBlad(tblBladStamdata tblBladStamdata)
        {

            return dao.OpretNytStamBlad(stamData: tblBladStamdata);
        }

        public string GetTableGeoCode()
        {
            return dao.GetTblGetKode();
        }

        public string GetTablePostNr()
        {
            return dao.GetTblPostNr(); 
        }

        public string GetTablePostNrSøgning()
        {
             return dao.GetPostNrSøgning();
        }

        public string GetTableHoveedGruppe()
        {
            return dao.GetTableHovedGruppe();
        }

        public string GetTableRegion()
        {
            return dao.GetTblRegion();
        }

        public string GetTableDage()
        {
            return dao.GetTableDage();
        }

        public int GetNumbersOfStamblad()
        {
            return dao.GetNumbersOfStamblad();
        }

        public string GetByNavnPostNr(int postnr)
        {
            return dao.GetByNavnPostNr(postnr);
        }

        public Tuple<string, int> GetLatestId()
        {
            return dao.GetLatestId();
        }

        public string GetStamBladEfterEjerforhold(string ejerforhold)
        {
            return dao.GetStamBladEfterEjerforhold(ejerforhold);
        }

        public Task<int> UpdateEjerforholdForAviser(string oldejeforhold, string newejerforhold)
        {
            return dao.UpdateEjerforholdForAviser(oldejeforhold, newejerforhold);
        }

        public string GetAllIds()
        {
            return dao.GetAllIds();
        }
    }
}