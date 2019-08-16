﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
   public class StambladKontaktService: IStambladKontaktPersonService
    {
        private StamBladKontakterDao stam;

        public StambladKontaktService()
        {
            stam = new StamBladKontakterDao();
        }

        public Task<int> AddOrUpdateStamBladKontkt(tblStambladKontakter tblStambladKontakter)
        {
            return stam.AddOrUpdateStamBladKontkt(tblStambladKontakter);
          
        }

        public string GetStamBladKontakterByStambladId(int bladId)
        {
            return stam.GetStamBladKontakterByStambladId(bladId);
        }
    }
}