﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.models;
namespace dlu_persistence_api.daos
{
    public class MediePlanDao
    {
        private DiMPdotNetEntities entities;

        public MediePlanDao()
        {
            this.entities = new DiMPdotNetEntities();
            entities.Configuration.LazyLoadingEnabled = true; 
        }



        public async Task<List<MediePlan>> GetMediePlanByPartialNumber(int medieplanNr)
        {
            return await entities.tblMedieplans.Where(e->e.MedieplanNr = medieplanNr);
        }
    }



        




