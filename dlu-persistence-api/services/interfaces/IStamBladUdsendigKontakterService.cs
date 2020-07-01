﻿using System.Threading.Tasks;
using System.Collections;
using dlu_persistence_api.models;
using System.Collections.Generic;

namespace dlu_persistence_api.services.interfaces
{
    public interface IStamBladUdsendigKontakterService
    {
        List<UdsendingKontakter> GetUdsendingKontakterPrBladId(int bladId);
       Task<int> AddOrUpdateKontakterPrBlad(tblBladUdsendingKontakter tblBlad);
    }
}
