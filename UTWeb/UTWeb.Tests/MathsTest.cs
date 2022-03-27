using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTWeb.Tests
{
    [TestFixture]
    class MathsTest
    {
        [Test]
        public void AddTestPostiveRes()
        {
            Maths maths = new Maths();

            var res = maths.Add(10, 30);

            Assert.AreEqual(40, res);
        }
    }
}
