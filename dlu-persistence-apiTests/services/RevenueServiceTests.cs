using Microsoft.VisualStudio.TestTools.UnitTesting;
using dlu_persistence_api.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services;
namespace dlu_persistence_api.services.Tests
{
    [TestClass()]
    public class RevenueServiceTests
    {
        private RevenueService revenueService { get; set; }
        [TestMethod()]
        public void GetRevenueTest()
        {
            revenueService = new RevenueService();
            var res = revenueService.GetRevenue(12, 2020);
            Assert.IsTrue(res.OmSætning > 0);
        }
    }
}