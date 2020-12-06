using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using dlu_persistence_api.models;
using dlu_persistence_api.services.interfaces;
using  dlu_persistence_api.daos;
using Microsoft.Extensions.DependencyInjection;

namespace dlu_persistence_api.services
{
    public class WebAnnoncKontrolService: IWebAnnoncKontrolService

    {

        private WebAnnonceKontrol _annonceKontrol;

        public WebAnnoncKontrolService()
        {
            _annonceKontrol = new WebAnnonceKontrol();
        }

        public List<AnnonceKontrolWeb> AnnonceKontrolWebs(int ugeAvisID, int IndrykningsUge, int year)
        {
            try
            {
                return _annonceKontrol.AnnonceKontrolWebs(ugeAvisID, IndrykningsUge, year);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public List<string> GetAvisNavn(int bladId)
        {
            try
            {
                return _annonceKontrol.GetAvisNavn(bladId);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public int Delete(int OrdreID, int BladID)
        {
            try
            {
                return _annonceKontrol.Delete(OrdreID, BladID);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public int InsertSQL(int OrdreID, int BladID, string email, bool kontrolleretAfDLU, int ErrorID, string SidePlacering)
        {
            try
            {
                return _annonceKontrol.InsertSQL(OrdreID, BladID, email, kontrolleretAfDLU, ErrorID, SidePlacering);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public int ManglerKontrol(int OrdreID)
        {
            try
            {
                return _annonceKontrol.ManglerKontrol(OrdreID);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public int AntaFejl(int OrdreID)
        {
            try
            {
                return _annonceKontrol.AntaFejl(OrdreID);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public byte SelectFakturing(int OrdreID)
        {
            try
            {
                return _annonceKontrol.SelectFakturing(OrdreID);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public int UpdateMediePlan(int Status, int OrdreID)
        {
            try
            {
                return _annonceKontrol.UpdateMediePlan(Status, OrdreID);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public int UpdateMediePlanNr(int Status, int OrdreID)
        {
            try
            {
                return _annonceKontrol.UpdateMediePlanNr(Status, OrdreID);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }

        public int UpdateAnnonceKontrol(int OrdreID, int BladID)
        {
            try
            {
                return _annonceKontrol.UpdateAnnonceKontrol(OrdreID, BladID);
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
        }
    }
}