using Microsoft.VisualStudio.TestTools.UnitTesting;
using cgpaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace cgpaCalculator.Tests
{
    [TestFixture()]
    public class cgpaCalculatorTestClass
    {
        [Test()]
        public void calculateGPATest()
        {
            int subjectCount = 3;
            List<int> marks = new List<int>() { 90,80,70};
            string grade = cgpaCalculator.calculateGPA(subjectCount, marks);
            if (grade == "A")
            {
                Assert.IsTrue(true);
            }
            else
            { Assert.Fail(); }
        }
    }
}