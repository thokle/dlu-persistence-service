using System;
using System.Collections.Generic;
using dlu_persistence_api.models;

namespace dlu_persistence_api.services.interfaces
{
    public interface IWebAnnoncKontrolService
    {
        List<AnnonceKontrolWeb> AnnonceKontrolWebs(int ugeAvisID, int IndrykningsUge, int year);
        List<string> GetAvisNavn(int bladId);
        int Delete(int OrdreID, int BladID);

        int InsertSQL(int OrdreID, int BladID, string email, Boolean kontrolleretAfDLU, int ErrorID,
            string SidePlacering);

        int ManglerKontrol(int OrdreID);

        int AntaFejl(int OrdreID);

        int SelectFakturing(int OrdreID);

        int UpdateMediePlan(int Status, int OrdreID);

        int UpdateMediePlanNr(int Status, int OrdreID);

        int UpdateAnnonceKontrol(int OrdreID, int BladID);

    }
}