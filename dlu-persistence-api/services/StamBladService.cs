using dlu_persistence_api.daos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class StamBladService
    {
        private StamBladDao dao;


        public StamBladService()
        {
            dao = new StamBladDao();
        }




        public string GetTableGeoCode()
        {
            return dao.GetTblGetKode();
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
            return dao.GetNumbersOfstamBlad();
        }

        public string GetByNavnPostNr(int postnr)
        {
            return dao.GetByNavnPostNr(postnr);
        }

        public Tuple<string, int> GetLatestId()
        {
            return dao.GetLatestId();
        }

        public List<tblBladStamdata> GetStamBladEfterEjerforhold(string ejerforhold)
        {
            return dao.GetstamBladEfterEjerforhold(ejerforhold);
        }

        public Task<int> UpdateEjerforholdForAviser(string oldejeforhold, string newejerforhold)
        {
            return dao.UpdateEjerforholdForAviser(oldejeforhold, newejerforhold);
        }

       public string GetStamBladEmailByBladId(int bladid)
        {
            return dao.GetStamBladEmailByBladId(bladid);
        }
    }
}