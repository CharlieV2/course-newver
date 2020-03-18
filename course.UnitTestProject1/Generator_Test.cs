using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace course.UnitTestProject1
{
    [TestClass]
    public class Generator_Test
    {
        [TestMethod]
        public void Generator_RandomData()
        {
            Generator gen = new Generator();
            Sportsmen sportsmen = gen.RandomData();

            bool TestStatus = true;

            if (!gen.countryArray.Contains(sportsmen.Country)) TestStatus = false;

            if (!(gen.CanadaNameArray.Contains(sportsmen.Name) ||
                  gen.GermanyNameArray.Contains(sportsmen.Name) ||
                  gen.JapanNameArray.Contains(sportsmen.Name) ||
                  gen.RussianNameArray.Contains(sportsmen.Name) ||
                  gen.EnNameArray.Contains(sportsmen.Name) ||
                  gen.FrenchNameArray.Contains(sportsmen.Name))) TestStatus = false;

            if (!(gen.CanadaSurnameArray.Contains(sportsmen.Surname) ||
                  gen.GermanySurnameArray.Contains(sportsmen.Surname) ||
                  gen.JapanSurnameArray.Contains(sportsmen.Surname) ||
                  gen.RussianSurnameArray.Contains(sportsmen.Surname) ||
                  gen.EnSurnameArray.Contains(sportsmen.Surname) ||
                  gen.FrenchSurnameArray.Contains(sportsmen.Surname))) TestStatus = false;

            if (!gen.Sport.Contains(sportsmen.Sport)) TestStatus = false;

            if (sportsmen.Age.GetType() != typeof(int)) TestStatus = false;

            if (sportsmen.Gold.GetType() != typeof(int)) TestStatus = false;
            if (sportsmen.Silver.GetType() != typeof(int)) TestStatus = false;
            if (sportsmen.Bronze.GetType() != typeof(int)) TestStatus = false;

            Assert.AreEqual(true, TestStatus);
        }
    }
}
