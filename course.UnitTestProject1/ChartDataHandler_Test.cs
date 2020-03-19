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

        private Sportsmen CreateSportsmen(int age, int gold, int silver, int bronze)
        {
            Sportsmen sportsmen = new Sportsmen();

            sportsmen.Country = "testCountry";
            sportsmen.Name = "testName";
            sportsmen.Surname = "testSurname";
            sportsmen.Sport = "testSport";
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
            Variables.sportsmens.Add(CreateSportsmen(20, 2, 2, 2));
            Variables.sportsmens.Add(CreateSportsmen(20, 3, 3, 3));
            Variables.sportsmens.Add(CreateSportsmen(40, 6, 6, 6));


            // set expected lists
            List<string> expectedAge = new List<string>();
            List<double> expectedAvrgAwards = new List<double>();

            expectedAge.Add("20");
            expectedAge.Add("40");

            expectedAvrgAwards.Add(7.5);
            expectedAvrgAwards.Add(18);

            var testResult = dataHandler.Data_44("testSport");

            Assert.ReferenceEquals(expectedAge, testResult.Item1);
            Assert.ReferenceEquals(expectedAvrgAwards, testResult.Item2);
        }
    }
}
