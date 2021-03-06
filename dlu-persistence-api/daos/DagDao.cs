﻿using System.Collections.Generic;
using System.Linq;
namespace dlu_persistence_api.daos
{
    public class DagDao
    {
        private DiMPdotNetDevEntities entities;
        public DagDao()
        {

            entities = new DiMPdotNetDevEntities();
        }

        public List<Dage> GetTblDages()
        {
            var res = from d in entities.tblDages
                      orderby d.DagID
                      select new Dage()
                      {
                          DagID = d.DagID,
                          DagNavn = d.DagNavn,
                          DagType = d.DagType
                      };
            return res.ToList<Dage>();
        }
    }
}
