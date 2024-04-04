using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
 
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        private const string Expected = "Hello World!!";
        [TestMethod]
        public void TestMethod()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                SimpleHelloWorld.Program.Main();
 
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}