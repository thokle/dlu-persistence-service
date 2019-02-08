namespace dlu_persistence_api.services
{
    public interface IUgeAviserTilGridServive
    {
        string GetAllUgeAviserGridPostNr(int? postnr);
        string GetAllUgeAviserByByNavn(string name);
        string GetAllUgerAviser();
    }
}