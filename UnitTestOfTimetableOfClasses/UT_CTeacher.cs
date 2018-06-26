using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using LibOfTimetableOfClasses;


namespace UnitTestOfTimetableOfClasses
{
    
    [TestClass]
    public class UT_CTeacher
    {
        CTeacher NewTeacher = new CTeacher();

        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string name = "";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "Профессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod2()
        {
            //arrange
            string name = "Иван";
            string middleName = "";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "Профессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod3()
        {
            //arrange
            string name = "Иван";
            string middleName = "Иванов";
            string surname = "";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "Профессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod4()
        {
            //arrange
            string name = "Иван";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "";
            string academicRank = "Профессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod5()
        {
            //arrange
            string name = "Иван";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod6()
        {
            //arrange
            string name = "Иван";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "Профессор";
            bool expected = true;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod7()
        {
            //arrange
            string name = "Иван";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 143;
            string academicDegree = "Доктор наук";
            string academicRank = "Профессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod8()
        {
            //arrange
            string name = "Ив:%)(,/*-н";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "Профессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod9()
        {
            //arrange
            string name = "Иван";
            string middleName = "Ив%:?*,<>нов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "Профессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        //public void TestMethod10()
        //{
        //    //arrange
        //    string name = "Иван";
        //    string middleName = "Иванов";
        //    string surname = "Ивано*?:%;/*-()вич";
        //    byte sizeOfTeachingExperience = 32;
        //    string academicDegree = "Доктор наук";
        //    string academicRank = "Профессор";
        //    bool expected = false;
        //    //act
        //    bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
        //    //assert
        //    Assert.AreEqual(actual, expected);
        //}
        public void TestMethod11()
        {
            //arrange
            string name = "Иван";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "Профессор";
            bool expected = true;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        //public void TestMethod12()
        //{
        //    //arrange
        //    string name = "Иван";
        //    string middleName = "Иванов";
        //    string surname = "Иванович";
        //    byte sizeOfTeachingExperience = 32;
        //    string academicDegree = "Доктор наук";
        //    string academicRank = "Профессор";
        //    bool expected = true;
        //    //act
        //    bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
        //    //assert
        //    Assert.AreEqual(actual, expected);
        }
        public void TestMethod13()
        {
            //arrange
            string name = "Иван";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Докт(*?:%;№;%:?*()/*-ор наук";
            string academicRank = "Профессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod14()
        {
            //arrange
            string name = "Иван";
            string middleName = "Иванов";
            string surname = "Иванович";
            byte sizeOfTeachingExperience = 32;
            string academicDegree = "Доктор наук";
            string academicRank = "Проф(*?:%;№%;%:?*()/*-+ессор";
            bool expected = false;
            //act
            bool actual = NewTeacher.AddTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}
