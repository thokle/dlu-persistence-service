namespace dlu_persistence_api.services
{
    public interface IMediePlanService
    {
        string GetMediePlanById(int id);
        string GetMediePlanByName(string name);
        
        string CreateOrUpdate(tblMedieplan tblMedieplan);

    }
}