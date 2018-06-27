using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    class UT_MGroup
    {
        private static MGroup G;
        [TestInitialize]
        public void ClassInitialize()
        {
            G = new MGroup();
            G.Сipher = "";
            G.Population = 0;

        }
        [TestMethod]
        public void TestMethodID()
        {
         
            Assert.AreEqual(typeof(Guid), G.Id.GetType(), "Тип поля ID не совпадает с диаграммой");
        }
        
        public void TestMethodCipher()
        {
            Assert.AreEqual(typeof(String), G.Сipher.GetType(), "Тип поля Cipher не совпадает с диаграммой");
        }
        
        public void TestMethodPopulation()
        {
            Assert.AreEqual(typeof(Byte), G.Population.GetType(), "Тип поля Population не совпадает с диаграммой");
        }
    }
}
