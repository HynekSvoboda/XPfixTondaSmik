using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XP_2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form = new Form1();
        XP_2.HerniPostava postava=new XP_2.HerniPostava();
        XP_2.Hrac hrac = new XP_2.Hrac();
        [TestMethod]
        public void TestMethodNeg()
        {
            string jmeno = postava.Vratjmeno();
            Assert.IsNull(jmeno);
        }
        [TestMethod]
        public void TestMethodPos()
        {
            string jmeno = postava.Vratjmeno();
            Assert.IsNotNull(jmeno);
        }
        [TestMethod]
        public void TestMethodNeg1()
        {
            string jmeno = postava.Vratjmeno();
            Assert.IsTrue(jmeno.Length > 10);
        }
        [TestMethod]
        public void TestMethodPos1()
        {
            string jmeno = postava.Vratjmeno();
            Assert.IsFalse(jmeno.Length > 10);
        }
        [TestMethod]
        public void TestMethodNeg2()
        {
            string jmeno = postava.Vratjmeno();
            Assert.IsTrue(jmeno.Contains("&"));
        }
        [TestMethod]
        public void TestMethodPos2()
        {
            string jmeno = postava.Vratjmeno();
            Assert.IsTrue(jmeno.Contains("Tonda"));
        }
        [TestMethod]
        public void TestMethodNeg3()
        {
            string specializace = hrac.Specializace;
            Assert.AreSame(specializace, "Kouzelník");
        }
        [TestMethod]
        public void TestMethodPos3()
        {
            string specializace = hrac.Specializace;
            Assert.AreSame(specializace, "Berserker");
        }

        [TestMethod]
        public void TestMethodNeg4()
        {
            double aktualni1 = hrac.pridanyxp;
            int aktualni2 = hrac.pridanyxp;
            Assert.AreSame(aktualni1, aktualni2);
        }
        [TestMethod]
        public void TestMethodPos4()
        {
            int aktualni = hrac.pridanyxp;
            Assert.AreEqual(aktualni, hrac.pridanyxp);
        }
        [TestMethod]
        public void TestMethodNeg5()
        {
            int X = hrac.ZmenaPozice1();
            int Y = hrac.ZmenaPozice2();
            Assert.IsTrue(X < Y);
        }
        [TestMethod]
        public void TestMethodPos5()
        {
            int X = hrac.ZmenaPozice1();
            int Y = hrac.ZmenaPozice2();
            Assert.IsFalse(X > Y);
        }
    }
}
