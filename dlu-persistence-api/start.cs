using dlu_persistence_api.daos;
using System;
using System.Linq;

namespace dlu_persistence_api
{
    public class start
    {


        public static void Main(string[] args)
        {
            DiMPdotNetDevEntities diMPdotNetDevEntities = new DiMPdotNetDevEntities();

            diMPdotNetDevEntities.tblBladStamdatas.Select(a => new { a.BladID, a.Navn }).ToList().ForEach(p => Console.WriteLine("BladId {0} Navn {1}", p.BladID, p.Navn));
        }
    }
}
