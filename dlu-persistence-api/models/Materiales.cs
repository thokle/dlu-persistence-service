using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class Materiales
    {

        public Materiales()
        {
            MedieplanLinjers = new Collection<MedieplanLinjer>();
        }

        public int MedieplanNr { get; set; }
        public int UgeavisID { get; set; }
        public string FilNavn { get; set; }
        public bool ErSendt { get; set; }
        public bool SkalSendes { get; set; }
        public string FilSti { get; set; }

        public  MediePlanNr tblMedieplanNr { get; set; }
     public  Collection<MedieplanLinjer> MedieplanLinjers { get; set; }
   
    }
}
