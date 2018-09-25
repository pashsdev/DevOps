using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using DevOpsLibrary;

namespace DevOpsTest
{
    [TestFixture]
    public class Whitelist
    {
        [TestCase(1,2,3)]
        //[TestCase(3,2,4)]
        public void AddTest(Int64 a, Int64 b,Int64 expectedResult)
        {
            Calculator calc = new Calculator();
            Int64 result = calc.Add(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
