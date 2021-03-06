﻿using dlu_persistence_api.exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;


namespace dlu_persistence_api.daos
{
    public class BladKommentarDao
    {
        private DiMPdotNetDevEntities entities;

        public BladKommentarDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public List<BladKommentar> GetKommentarByStamBladId(int bladid)
        {
            try
            {
                var res = from bk in entities.tblBladKommentars
                          where bk.bladid == bladid
                          orderby bk.date
                          select new BladKommentar
                          {
                              bladid = bk.bladid,
                              tekst = bk.tekst,
                              date = bk.date
                          };
                return res.ToList<BladKommentar>();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }


        public Task<int> CreateBladKommentar(tblBladKommentar tblBladKommentar)
        {
            try
            {
                entities.tblBladKommentars.AddOrUpdate(tblBladKommentar);
                return entities.SaveChangesAsync();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }

        }

    }
}
