namespace dlu_persistence_api.services
{
    public interface IKontaktService
    {
        string GetKontakterPrBlad(int bladid);
        string GetKontaktTitler();
        string GetKontakterArbOmråderKontkter();
    }
}