using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class Placering
    {

        public Placering()
        {
            this.tblMedieplans = new Collection<MediePlan>();
            this.Prisers = new Collection<Prisers>();
        }

        public byte PlaceringID { get; set; }
        public string Betegnelse { get; set; }
         public  Collection<MediePlan> tblMedieplans { get; set; }
      
        public  Collection<Prisers> Prisers { get; set; }
    }
}
