using System;

namespace dlu_persistence_api.daos
{
    public class BladKommentar
    {
        public int? bladid { get; set; }
        public string tekst { get; set; }
        public DateTime date { get; set; }
    }
}