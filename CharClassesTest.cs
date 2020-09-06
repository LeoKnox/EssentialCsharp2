using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class CharClassesTest
    {
        [TestMethod]
        public void IsClassTest()
        {
            var testInstance = new CharClasses();
            testInstance.CharacterClasses.Add("Fighter");
            testInstance.CharacterClasses.Add("Wizard");
            testInstance.CharacterClasses.Add("Rogue");

            // expect to pass
            Assert.IsTrue(testInstance.DoesClassExist("Rogue"));
            // expect to fail
            Assert.IsFalse(testInstance.DoesClassExist("Sloth"));
        }
    }
}
