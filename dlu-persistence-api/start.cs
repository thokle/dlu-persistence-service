using dlu_persistence_api.daos;
using System;
using System.Linq;

namespace dlu_persistence_api
{
    public class start
    {


        public static void Main(string[] args)
        {

            dlu_persistence_api.services.WebAnnoncKontrolService webAnnoncKontrolService = new services.WebAnnoncKontrolService();

            webAnnoncKontrolService.AnnonceKontrolWebs(14, 42, 2020);

            
        }
    }
}
