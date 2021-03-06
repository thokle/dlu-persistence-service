﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.services.interfaces;
namespace dlu_persistence_api.services
{
 public class PrisUdsendingService : IPrisUdsendingService
    {
        private PrisUdsendingDao udsendingDao;

        public PrisUdsendingService()
        {
            udsendingDao = new PrisUdsendingDao();
        }

        public List<Udsending> GetAllStambladTilUdsending()
        {
            return udsendingDao.GetAllStambladTilUdsending();
        }

        public List<Udsending> GetAllStambladTilUdsendingTilDeadlines()
        {
            return udsendingDao.GetAllStambladTilUdsendingTilDeadlines();
        }

        public List<models.Ejerforhold> GetAllDistinctEjerforhold()
        {
            return udsendingDao.GetAllDistinctEjerforhold();
        }
    }

   
}
