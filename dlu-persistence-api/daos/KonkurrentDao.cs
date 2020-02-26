using System;
using System.Collections.Generic;
using System.Linq;

namespace dlu_persistence_api.daos
{
    public class KonkurrentDao
    {
        private DiMPdotNetDevEntities entities;

        public KonkurrentDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public List<Konkurent> GetKonkurrentDækningByID()
        {
            try
            {
                return entities.tblKonkurrenters.Select(ku => new Konkurent()
                {
                    BladTypeMappingFraDO = ku.BladTypeMappingFraDO,
                    KonkurentKode = ku.KonkurentKode,
                    KonkurrentID = ku.KonkurrentID,
                    KonkurrentNavn = ku.KonkurrentNavn

                }).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

    }

    public class Konkurent
    {
        public string BladTypeMappingFraDO { get; internal set; }
        public string KonkurentKode { get; internal set; }
        public byte KonkurrentID { get; internal set; }
        public string KonkurrentNavn { get; internal set; }
    }
}
