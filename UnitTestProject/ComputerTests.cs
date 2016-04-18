using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kube;

namespace UnitTestProject
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void qubeComputerThrowTest()
        {
            Computer c = new Computer();
            c.QubeThrow();
            Assert.IsNotNull(c.AllPoints);
        }
    }
}
