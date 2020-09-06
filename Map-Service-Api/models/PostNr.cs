﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_Service_Api.models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Kommuner
    {
        public string href { get; set; }
        public string kode { get; set; }
        public string navn { get; set; }
    }

    public class PostNr
    {
        public string href { get; set; }
        public string nr { get; set; }
        public string navn { get; set; }
        public object stormodtageradresser { get; set; }
        public List<double> bbox { get; set; }
        public List<double> visueltcenter { get; set; }
        public List<Kommuner> kommuner { get; set; }
        public DateTime ændret { get; set; }
        public DateTime geo_ændret { get; set; }
        public int geo_version { get; set; }
        public string dagi_id { get; set; }
    }


}
