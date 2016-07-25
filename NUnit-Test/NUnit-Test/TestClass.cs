using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit_Test {

    [TestFixture]
    public class TestClass {

        [Test]
        public void PositiveTest() {

            int x = 7;
            int y = 7;

            Assert.AreEqual(x, 7);

        }

        [Test]
        public void NegativeTest() {

            if (true)
                Assert.Fail("Negative test failed on purpose.");

        }

        [Test]
        public void ExceptionTest() {
            // No base case, infinite loop
           // Assert.That(() => ExceptionTest(), Throws.TypeOf<NotSupportedException>());
        }

        [Test, Ignore("Purposely Ignored")]
        public void NotImplementedException() {
            throw new NotImplementedException();
        }
    }
}
