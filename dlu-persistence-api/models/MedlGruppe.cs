using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
  public  class MedlGruppe
    {
        public int GruppeID { get; set; }
        public int ID { get; set; }
        public bool ErTillægsAvis { get; set; }
        public byte Version { get; set; }

        public  StamData tblBladStamdata { get; set; }
        public  Grupper tblGrupper { get; set; }
    }
}
