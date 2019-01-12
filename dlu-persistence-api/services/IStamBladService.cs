using System;
using System.Threading;

namespace dlu_persistence_api.services
{
    public interface IStamBladService
    {
        string GetStamBladById(int id);
        string GetStamBladByName(string name);
        string GetStamBladByPostNummer(int postnr);
        string CreaateOrUpdateStamBlad(tblBladStamdata tblBladStamdata);

    }
}