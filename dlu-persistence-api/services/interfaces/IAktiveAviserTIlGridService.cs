namespace dlu_persistence_api.services.interfaces
{
    interface IAktiveAviserTIlGridService
    {
        string GetAllAvisetTilGrid();
        string getAktivAvisByNavn(string navn);
        string getAktiveAvisByDaekningGrad(int daek);

    }
}
