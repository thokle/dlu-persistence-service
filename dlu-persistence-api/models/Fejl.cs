using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
  public  class Fejl
    {
        private string fejltekst;

        public string FejlTekst { get => fejltekst; set => fejltekst = value; }
    }
}
