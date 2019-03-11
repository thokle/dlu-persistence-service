using System;
using System.Threading;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public interface IStamBladService
    {
        string GetStamBladById(int id);
        string GetStamBladByName(string name);
        string GetStamBladByPostNummer(int postnr);
        Task<int> CreaateOrUpdateStamBlad(tblBladStamdata tblBladStamdata);
        string GetTableGeoCode();
        string GetTablePostNr();
        string GetTablePostNrSøgning();
        string GetTableHoveedGruppe();
        string GetTableRegion();
        string GetTableDage();
        int GetNumbersOfStamblad();

    }
}