using System.Collections.Generic;

namespace dlu_persistence_api.daos
{
    public class PriceTilWeb
    {
        public int BladID { get;  set; }
        public string Navn { get;  set; }
        public List<TempWebPriser> tempPriser { get;  set; }
        public object placeringer { get; set; }
    }
}