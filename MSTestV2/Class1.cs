using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestV2
{
    [TestClass]
    public class Class1
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(1, 3, 4)]
        [DataRow(2, 4, 6)]
        [DataRow(6, 1, 7)]
        public void AddTest(int a, int b, int result)
        {
            Assert.AreEqual(result, Calculator.Add(a, b));
        }
    }
}
