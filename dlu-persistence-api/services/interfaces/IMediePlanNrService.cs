using System;

namespace dlu_persistence_api.services
{
    public interface IMediePlanNrService
    {
        //

        //
        string GetMediePlanNrByMedIePlanNr(int mediePlannr);
        Tuple<string, int> CreateOrUpDateMediePlanNr(tblMedieplanNr tblMedieplanNr);
    }
}