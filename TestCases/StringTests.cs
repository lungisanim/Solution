using Microsoft.VisualStudio.TestTools.UnitTesting;
using Consola;

namespace TestCases
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void stringTestSmallNumber()
        {
            string s = "Wow Example!";
            string e = "WwEapeo xml!";
            long n = 1;

            Utilities.jumbledString(s, n);
            string resultant = Utilities.jumbledString(s, n);

            Assert.AreEqual(e, resultant);
        }
    }
}
