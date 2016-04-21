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

            c.OnPCEndTurn += emptyMeth1;
            c.OnPCEndTurnForGame += emptyMeth2;

            c.QubeThrow();
            Assert.IsNotNull(c.AllPoints);
        }

        //methods for adding to delegate
        public void emptyMeth1()
        { }

        public void emptyMeth2(int p, string n)
        { }
    }
}
