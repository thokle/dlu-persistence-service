using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class Revenue
    {
        private decimal? omSætning;

        public decimal? OmSætning { get => omSætning; set => omSætning = value; }
    }
}
