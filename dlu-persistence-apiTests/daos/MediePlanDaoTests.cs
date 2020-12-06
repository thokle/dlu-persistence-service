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
    public class MediePlanDaoTests
    {
        [TestMethod()]
        public void GetMediePlanByNumberTest()
        {
            var mp = new MediePlanDao();
            try
            {
                var res = mp.GetMediePlanByNumber(80004, 21);
                res.medieplannlinjer.ForEach(e =>
                {
                    e.fejl.ToList().ForEach(s =>
                    {
                        Console.WriteLine(" " + s.FejlTekst);
                    });
                });
            } catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
       
        }
    }
}