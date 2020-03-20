using System;
using System.Collections.Generic;
using System.IO;
using course.HelpClasses;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace course.UnitTestProject1
{
    [TestClass]
    public class ChartDataHandler_Test
    {
        ChartDataHandler dataHandler = new ChartDataHandler();

        private Sportsmen CreateSportsmen(string country = "testCountry", string sport = "testSport", int age = 0, int gold = 0, int silver = 0, int bronze = 0)
        {
            Sportsmen sportsmen = new Sportsmen();

            sportsmen.Country = country;
            sportsmen.Name = "testName";
            sportsmen.Surname = "testSurname";
            sportsmen.Sport = sport;
            sportsmen.Age = age;
            sportsmen.Gold = gold;
            sportsmen.Silver = silver;
            sportsmen.Bronze = bronze;

            return sportsmen;
        }


        [TestMethod]
        public void ChartDataHandler_Data44()
        {
            Variables.sportsmens.Clear();

            // create sportsmens for test
            Variables.sportsmens.Add(CreateSportsmen(age: 20, gold: 2, silver: 2, bronze: 2));
            Variables.sportsmens.Add(CreateSportsmen(age: 20, gold: 3, silver: 3, bronze: 3));
            Variables.sportsmens.Add(CreateSportsmen(age: 40, gold: 6, silver: 6, bronze: 6));


            // set expected lists
            List<string> expectedAge = new List<string>();
            List<double> expectedAvrgAwards = new List<double>();

            expectedAge.Add("20");
            expectedAge.Add("40");

            expectedAvrgAwards.Add(7.5);
            expectedAvrgAwards.Add(18);


            // test
            var testResult = dataHandler.Data_44("testSport");

            Assert.ReferenceEquals(expectedAge, testResult.Item1);
            Assert.ReferenceEquals(expectedAvrgAwards, testResult.Item2);
        }

        [TestMethod]
        public void ChartDataHandler_Data45()
        {
            Variables.sportsmens.Clear();

            // create sportsmens for test
            Variables.sportsmens.Add(CreateSportsmen("Country1"));
            Variables.sportsmens.Add(CreateSportsmen("Country1"));
            Variables.sportsmens.Add(CreateSportsmen("Country1"));
            Variables.sportsmens.Add(CreateSportsmen("Country2", "testSport_notforsearch"));
            Variables.sportsmens.Add(CreateSportsmen("Country2"));

            // set expected dictionary
            Dictionary<string, int> expectedDictionary = new Dictionary<string, int>();

            expectedDictionary.Add("Country1", 3);
            expectedDictionary.Add("Country2", 1);

            // test
            CollectionAssert.AreEqual(expectedDictionary, dataHandler.Data_45("testSport"));
        }

    }
}
