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
    public class StamBladUdsendigKontakterServiceTests
    {
        [TestMethod()]
        public void GetUdsendingKontakterPrBladIdTest()
        {
            StamBladUdsendigKontakterService stamBladUdsendigKontakterService = new StamBladUdsendigKontakterService();
            var blad = stamBladUdsendigKontakterService.GetUdsendingKontakterPrBladId(14);
            blad.ForEach(i =>
            {
                Console.WriteLine(i.Name);
            });
        }

        [TestMethod()]
        public void GetUdsendingKontakterPrNavn()
        {
            StamBladUdsendigKontakterService stamBladUdsendigKontakterService = new StamBladUdsendigKontakterService();
            var blad = stamBladUdsendigKontakterService.GetUdsendingKontaktersByNavn("BT ");
            blad.ForEach(i =>
            {
                Console.WriteLine(i.Name);
            });
        }
    }
}