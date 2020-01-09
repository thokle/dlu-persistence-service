using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace dlu_persistence_api.daos
{
    public class FundetMediePlaner
    {
        public FundetMediePlaner()
        {
        }

    
        public string AnnoncørNo_ { get; internal set; }
        public string BureauNo_ { get; internal set; }
        public byte Format1 { get; internal set; }
        public short Format2 { get; internal set; }
        public byte AntalFarver { get; internal set; }
        public byte IndrykningsUge { get; internal set; }
        public string Beskrivelse { get; internal set; }
        public string KonsulentCode { get; internal set; }
        public byte Status { get; internal set; }
        public short Version { get; internal set; }
        public int MedieplanNr { get; internal set; }
        public string Kontaktperson { get; internal set; }
        public byte KontaktpersonTilhører { get; internal set; }
        public string Overskrift { get; internal set; }
       
        public string navision_name { get; internal set; }
        public short IndrykningsÅr { get; internal set; }
        public int AntalAviser { get; set; }
       // public DateTime OprettetDate { get; set; }
    }
}