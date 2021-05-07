using Gun_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        mainclass classgun = new mainclass();
        [TestMethod]
        public void TestMethod1()
        {
            string Actual = classgun.Gunreload();
            string Expected = "Your Gun Reload";

        }
    }
}
