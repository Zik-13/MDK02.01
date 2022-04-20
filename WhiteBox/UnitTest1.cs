using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;

namespace WhiteBox
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ravnostoronyq_5_6_7_Raznostoronniy()
        {
            int x = 5;
            int y = 6;
            int z = 7;
            string result ="Разносторнний";
            
            Treygolnik treygolnik = new Treygolnik();
            Assert.AreEqual(result, treygolnik.Info(x, y, z));          
        }

        [TestMethod]
        public void Ravnostoronyq_6_6_7_Ravnoberyniq()
        {
            int x = 6;
            int y = 6;
            int z = 7;
            string result = "Равнобедренный";

            Treygolnik treygolnik = new Treygolnik();
            Assert.AreEqual(result, treygolnik.Info(x, y, z));
        }

        [TestMethod]
        public void Ravnostoronyq_6_6_6_Ravnostoronyq()
        {
            int x = 6;
            int y = 6;
            int z = 6;
            string result = "Равностороний";

            Treygolnik treygolnik = new Treygolnik();
            Assert.AreEqual(result, treygolnik.Info(x, y, z));
        }
    }
}
