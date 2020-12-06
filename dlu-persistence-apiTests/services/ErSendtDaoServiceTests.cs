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
    public class ErSendtDaoServiceTests
    {
        [TestMethod()]
        public void GetAllSkalSendesTest()
        {
            ErSendtDaoService erSendtDao = new ErSendtDaoService();
            erSendtDao.GetAllSkalSendes().ForEach(e =>
            {
                Console.WriteLine(e.AnnoncørNo_);
            });


           
        }
    }
}