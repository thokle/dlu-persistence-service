using Microsoft.VisualStudio.TestTools.UnitTesting;
using dimp_sql_services.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimp_sql_services.services.Tests
{
    [TestClass()]
    public class DeadLinesServiceTests
    {
        [TestMethod()]
        public void GetEjerforholdDeadLinesTest()
        {

            var d = new DeadLinesService();

            d.GetEjerforholdDeadLines("Fynske Medier").ForEach(s =>
            {
                Console.WriteLine("Bladnavn {0} ", s.Navn);
                s.Deadliens.ForEach(a =>
                {
                    Console.WriteLine(a.BladID);
                });
            });

        }
    }
}