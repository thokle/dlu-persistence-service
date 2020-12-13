using Microsoft.VisualStudio.TestTools.UnitTesting;
using dlu_persistence_api.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services.Tests
{
    [TestClass()]
    public class PrisUdsendingServiceTests
    {
        [TestMethod()]
        public void GetAllStambladTilUdsendingTilDeadlinesTest()
        {
            var ps = new PrisUdsendingService();

            var res = ps.GetAllStambladTilUdsendingTilDeadlines();

            res.ForEach(s =>
            {
                Console.WriteLine("Data {0}", s.Ejerforhold);
            });
        }
        [TestMethod()]
        public void GetAllDistinctEjerforhold()
        {
            var p = new PrisUdsendingService();

            var res = p.GetAllDistinctEjerforhold();

            res.ForEach(e =>
            {
                Console.WriteLine(" Data  {0}", e.EjerforholdData);
            });
        }
    }
}