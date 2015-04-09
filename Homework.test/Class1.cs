using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebApplication1.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CalYear()
        {
            Year.year cal = new Year.year();
            int inputAge = 30;
            int expect = 1988;

            Assert.AreEqual(expect, cal.GetBirthYear(inputAge, Year.year.YearFormat.w));
        }
    }
}
