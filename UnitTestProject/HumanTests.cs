using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kube;

namespace UnitTestProject
{
    [TestClass]
    public class HumanTests
    {
        [TestMethod]
        //два похожих места, это дублирование? (возможно, надо менять)
        public void qubeHumanThrowTest()
        {
            Human h = new Human();
            h.QubeThrow();
            Assert.IsNotNull(h.LocalPoints);
        }

        [TestMethod]
        public void humanEndTurnTest()
        {
            Human h = new Human();

            h.AllPoints = 10;
            h.LocalPoints = 10;
            h.OnEndTurn += emptyMeth1;

            h.EndTurn();

            Assert.IsNotNull(h.AllPoints);
            Assert.IsNotNull(h.LocalPoints);
        }

        //method for adding to delegate
        public void emptyMeth1(int p, string n)
        { }

        [TestMethod]
        public void humanMyTimeTest()
        {
            Human h = new Human();

            h.AllowToReplay = false;
            h.MyTime();

            Assert.IsTrue(h.AllowToReplay);
        }
    }
}
