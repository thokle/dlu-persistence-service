using Microsoft.VisualStudio.TestTools.UnitTesting;
using dlu_persistence_api.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos.Tests
{
    [TestClass()]
    public class MediePlanAviserDaoTests
    {
        [TestMethod()]
        public void GetAllUgeAvisTilGridTest()
        {
            MediePlanAviserDao mediePlanAviserDao = new MediePlanAviserDao();

            var res = mediePlanAviserDao.GetAllUgeAvisTilGrid(14, 2018, 0);
          var ans =   res.ansvar;
        }
    }
}