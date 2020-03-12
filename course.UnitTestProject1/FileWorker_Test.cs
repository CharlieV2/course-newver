using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace course.UnitTestProject1
{
    [TestClass]
    public class FileWorker_Test
    {
        FileWorker fw = new FileWorker();


        [TestMethod]
        public void FileWorker_CheckBd()
        {
            string expected;
            string actual;

            // when not exist
            expected = "not exists";
            actual = fw.CheckBd("impossible bd name");
            Assert.AreEqual(expected, actual);

            // when empty
            File.WriteAllText(Variables.path + "test_bdname" + ".bd", "");

            expected = "empty";
            actual = fw.CheckBd("test_bdname");
            Assert.AreEqual(expected, actual);

            // when has data
            File.WriteAllText(Variables.path + "test_bdname" + ".bd", "some data");

            expected = "has data";
            actual = fw.CheckBd("test_bdname");
            Assert.AreEqual(expected, actual);


            File.Delete(Variables.path + "test_bdname" + ".bd");
        }

        [TestMethod]
        public void FileWorker_CreateBd()
        {
            bool expected;
            bool actual;

            fw.CreateBd("test_bdname");

            expected = true;
            actual = File.Exists(Variables.path + "test_bdname" + ".bd");

            File.Delete(Variables.path + "test_bdname" + ".bd");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FileWorker_SaveBd()
        {
            string expected;
            string actual;

            // add new sportsmen
            Sportsmen sportsmen = new Sportsmen();
            sportsmen.Country = "testCountry";
            sportsmen.Name = "testName";
            sportsmen.Surname = "testSurname";
            sportsmen.Age = 10;
            sportsmen.Sport = "testSport";
            sportsmen.Gold = 1;
            sportsmen.Silver = 2;
            sportsmen.Bronze = 3;
            Variables.sportsmens.Add(sportsmen);

            // create temp bd
            File.WriteAllText(Variables.path + "test_bdname" + ".bd", "");

            // test
            expected = "testCountry_testName_testSurname_10_testSport_1_2_3";

            fw.SaveBd("test_bdname");
            actual = File.ReadAllText(Variables.path + "test_bdname" + ".bd").Trim();

            Assert.AreEqual(expected, actual);

            File.Delete(Variables.path + "test_bdname" + ".bd");
        }

        [TestMethod]
        public void FileWorker_DeleteBd()
        {
            bool actual;

            // create new bd 
            File.WriteAllText(Variables.path + "test_bdname" + ".bd", "");

            // test
            fw.DeleteBD("test_bdname");

            actual = File.Exists(Variables.path + "test_bdname" + ".bd");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void FileWorker_ReadBd()
        {
            // create my sportsmen
            Sportsmen sportsmen = new Sportsmen();
            sportsmen.Country = "testCountry";
            sportsmen.Name = "testName";
            sportsmen.Surname = "testSurname";
            sportsmen.Age = 10;
            sportsmen.Sport = "testSport";
            sportsmen.Gold = 1;
            sportsmen.Silver = 2;
            sportsmen.Bronze = 3;

            // create bd with data my sportsmen
            File.WriteAllText(Variables.path + "test_bdname" + ".bd", 
                              "testCountry_testName_testSurname_10_testSport_1_2_3");

            // test
            fw.ReadBD("test_bdname");

            Assert.ReferenceEquals(sportsmen, Variables.sportsmens[0]);

            File.Delete(Variables.path + "test_bdname" + ".bd");
        }
    }
}
