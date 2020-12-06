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
    public class SkalSendesServiceTests
    {
        [TestMethod()]
        public void SkaSendesTest()
        {
            var skalSendes = new SkalSendesService();
            var res = skalSendes.SkaSendes();

            res.ForEach(e =>
            {
                Console.WriteLine(e.AnnoncørNo_);
            });

        }
        [TestMethod]
        public void SkalSendesByUge()
        {
            var skalSendes = new SkalSendesService();
            var res = skalSendes.SkalSendesByUge(1, 2);

            res.ForEach(e =>
            {
                Console.WriteLine(e.AnnoncørNo_);
            });

        }
    }
}