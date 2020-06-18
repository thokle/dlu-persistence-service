using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class NavContact
    {
        private string bureauNavn;
        private string address;
        private string postNr;
        private string postBy;
        private string tlfNr;
        private string cVR;
        private byte infogodtgørelse;
        private byte sikkerhedsgodtgørelse;

        public string BureauNavn { get => bureauNavn; set => bureauNavn = value; }
        public string Address { get => address; set => address = value; }
        public string PostNr { get => postNr; set => postNr = value; }
        public string PostBy { get => postBy; set => postBy = value; }
        public string TlfNr { get => tlfNr; set => tlfNr = value; }
        public string CVR { get => cVR; set => cVR = value; }
        public byte Infogodtgørelse { get => infogodtgørelse; set => infogodtgørelse = value; }
        public byte Sikkerhedsgodtgørelse { get => sikkerhedsgodtgørelse; set => sikkerhedsgodtgørelse = value; }
    }
}
