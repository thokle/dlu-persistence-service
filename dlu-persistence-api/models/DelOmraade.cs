using System;

namespace dlu_persistence_api.models
{
    public class DelOmraade
    {
        int DelOmraadeID;
        private string DelOmraadeKode;
        string  DelOmraadeNavn;
        int DelOmraadeSortKey; 
        byte[] timestamp;
        
        public int DelOmraadeId
        {
            get => DelOmraadeID;
            set => DelOmraadeID = value;
        }

        public string DelOmraadeKode1
        {
            get => DelOmraadeKode;
            set => DelOmraadeKode = value;
        }

        public string DelOmraadeNavn1
        {
            get => DelOmraadeNavn;
            set => DelOmraadeNavn = value;
        }

        public int DelOmraadeSortKey1
        {
            get => DelOmraadeSortKey;
            set => DelOmraadeSortKey = value;
        }

        public byte[] Timestamp
        {
            get => timestamp;
            set => timestamp = value;
        }

      
    }
}