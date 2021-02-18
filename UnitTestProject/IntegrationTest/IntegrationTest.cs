using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1_Seldin;

namespace UnitTestProject.IntegrationTest
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void InsertLastLetterToTheBeginningTestMethod()
        {
            string expected = "qasd";
            string actual = Module1.InsertLastLetterToTheBeginning("asdq");
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void DeleteDuplicateLettersTestMethod()
        {
            string expected = "asd";
            string actual = Module1.DeleteDuplicateLetters("asdasdasd");
            Assert.AreEqual(actual, expected);
        }
    }
}
