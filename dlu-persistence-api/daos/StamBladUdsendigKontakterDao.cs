﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using dlu_persistence_api.models;
using System.Collections.Generic;
namespace dlu_persistence_api.daos
{

    public class StamBladUdsendigKontakterDao
    {
        private DiMPdotNetDevEntities entities;

        public StamBladUdsendigKontakterDao()
        {
            entities = new DiMPdotNetDevEntities();
            entities.Configuration.LazyLoadingEnabled = false;
            
        }


        public List<UdsendingKontakter> GetUdsendingKontakterPrBladId(int bladId)
        {
            try
            {

                var res =

                    from tuk in entities.tblBladUdsendingKontakters
                    join tl in entities.tblKontaktTitlers on tuk.titel equals tl.TitelID into tuktl
                    from tukl in tuktl.DefaultIfEmpty()


                    join du in entities.tblStambladUdsendingEmailTypers on tuk.type equals du.id where tuk.bladid == bladId
                    select new UdsendingKontakter
                    {
                        Email = tuk.mail,
                        KontaktType = du.titel,
                        Name = tuk.navn,
                        Id = tuk.id,
                        BladId = tuk.bladid,
                        Telefonnummer = tuk.telefonnummer,
                        Titel = tukl.Titel,
                      
                     
                        
                    };



                return res.ToList<UdsendingKontakter>();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }

        public  Task<int> AddOrUpdateKontakterPrBlad(tblBladUdsendingKontakter tblBlad)
        {
            entities.tblBladUdsendingKontakters.AddOrUpdate(tblBlad);
            return entities.SaveChangesAsync();
               
        }
    }


   
}
