﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class DPKuloerDaoService 
    {
        private DPKuloerDao kuloerDao;

        public DPKuloerDaoService()
        {
            kuloerDao = new DPKuloerDao();
        }
        public List<DPKulør> GetDPKuloer()
        {
            return kuloerDao.GetDPKuloer();
        }
    }
}