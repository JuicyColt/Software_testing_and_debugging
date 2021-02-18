using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1_Seldin;

namespace UnitTestProject.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void InsertLastLetterToTheBeginningTestMethod()
        {
            Assert.AreEqual(Module1.InsertLastLetterToTheBeginning("asdq"), "qasd");
            Assert.AreEqual(Module1.InsertLastLetterToTheBeginning("a"), "a");
            Assert.AreEqual(Module1.InsertLastLetterToTheBeginning("123123"), "312312");
        }

        [TestMethod]
        public void DeleteDuplicateLettersTestMethod()
        {
            Assert.AreEqual(Module1.DeleteDuplicateLetters("asdasdasd"), "asd");
            Assert.AreEqual(Module1.DeleteDuplicateLetters("123"), "123");
            Assert.AreEqual(Module1.DeleteDuplicateLetters("aswe1233asw"), "aswe123");
        }
    }
}
