using Microsoft.VisualStudio.TestTools.UnitTesting;
using dlu_persistence_api.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace dlu_persistence_api.daos.Tests
{
    [TestClass()]
    public class WebAnnonceKontrolTests
    {

        dlu_persistence_api.daos.WebAnnonceKontrol service = new dlu_persistence_api.daos.WebAnnonceKontrol();
        [TestMethod()]
        public void AnnonceKontrolWebsTest()
        {
            var res = service.AnnonceKontrolWebs(14, 42, 2020);
            res.ForEach(e =>
            {
                Console.WriteLine("OrdreNr {0} SlutVIst {1}", e.OrdreNr, e.SlutVist);
            });
        }
        [TestMethod()]
        public void DeleteTest()
        {
            var res = service.Delete(183804, 12);
            Assert.AreEqual(1, res);
        }

        [TestMethod()]
        public void InsertTest()
        {

            var res = service.InsertSQL(183802, 12, "test", true, 2, "2");
            Assert.AreEqual(1, res);
        }

        [TestMethod()]
        public void ManglerKontrolTest()
        {
            var res = service.ManglerKontrol(183868);
            Assert.AreEqual(0, res);
        }
    }
}