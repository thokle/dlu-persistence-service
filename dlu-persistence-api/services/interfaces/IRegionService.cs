namespace dlu_persistence_api.services
{
    public interface IRegionService
    {
        string GetRegions();
        string GetRegsionById(int regionId);
    }
}