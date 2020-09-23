using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
  public  class SendRykker
    {
        private int bladID;
        private string navn;
        private string prisforespørgselEmails;
        private Int16 antalUdsendinger;

        public int BladID { get => bladID; set => bladID = value; }
        public string Navn { get => navn; set => navn = value; }
        public string PrisforespørgselEmails { get => prisforespørgselEmails; set => prisforespørgselEmails = value; }
        public short AntalUdsendinger { get => antalUdsendinger; set => antalUdsendinger = value; }
    }
}
