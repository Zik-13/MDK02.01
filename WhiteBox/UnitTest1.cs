using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;

namespace WhiteBox
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ravnostoronyq_1_2_3()
        {
            int x = 5;
            int y = 6;
            int z = 7;
            string result ="Разносторнний";
            
            Treygolnik treygolnik = new Treygolnik();
            Assert.AreEqual(result, treygolnik.Info(x, y, z));
            
        }
    }
}
