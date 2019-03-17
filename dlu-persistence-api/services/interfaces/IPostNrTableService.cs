namespace dlu_persistence_api.services
{
    public interface IPostNrTableService
    {
        string GetPostNrListe();
        string GetPostNrAfByNavn(string bynavn);
        string GetByBYPostNr(int postnr);

    }
}