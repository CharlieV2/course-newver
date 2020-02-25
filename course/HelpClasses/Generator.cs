using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public class Generator
    {
        #region InfoBase
        string[] countryArray = { "Japan", "Germany", "Russian", "French", "Gr. Britain", "USA", "Canada" };

        string[] JapanNameArray = { "Ai", "Aiko", "Akako", "Akane", "Akemi", "Aki", "Chika", "Chikako ", "Cho ", "Dai ", "Hoshi ", "Akeno ", "Akiyama ", "Fudo ", "Naruto ", "Sasuke ", "Botan ", "Daiki ", "Haru ", "Jiro ", "Kanaye ", "Kano ", "Kazuo ", "Rafu ", "Nikk" };
        string[] JapanSurnameArray = { "Sato", "Sudjuki", "Ito", "Yamat", "Kato", "Sasaki", "Uchiha", "Uzumaki", "Yamaguti", "Hayasi", "Abe", "Goto", "Ocade", "Ono", "Takano", "Seke", "Homma" };

        string[] GermanyNameArray = { "Adolf", "Ben", "Paul", "Jonas", "Elias", "Leon", "Finn", "Fynn", "Noah", "Luis", "Luke", "Felix", "Luca", "Maximilian", "Henry", "Max", "Oskar", "Emil", "Liam", "Jacob", "Moritz", "Anton", "Mia", "Emma", "Sofia", "Lina", "Mila", "Amelie", "Lilly" };
        string[] GermanySurnameArray = { "Miller", "Scholz", "Tailor", "Weaver", "Baker", "Koch", "Bauer", "Richter", "Klein", "Wolf", "Schwarz", "Lange", "Werner", "Krause", "Maier", "Jung", "Hneitler", "Friedrich", "Frank", "Roth", "Beck", "Lorenz", "Franke" };

        string[] RussianNameArray = { "Alexander", "Alexey", "Anton", "Andrei", "Artur", "Bogdan", "Boris", "Valeriy", "Vitaliy", "Gleb", "Grigoriy", "Denis", "Zahar", "Ivan", "Ignat", "Igor", "Kirill", "Oksana", "Lara", "Olesya", "Yuliya" };
        string[] RussianSurnameArray = { "Smirnov", "Popov", "Kuznecov", "Sobolev", "Maslov", "Moiseev", "Shukin", "Sidorov", "Egorov", "Savin", "Guseev", "Titon", "Shilov", "Mishin", "Phokin", "Nosov" };

        string[] FrenchNameArray = { "Arno", "Jean", "Michel", "Alain", "Patrick", "Nicolas", "Christian", "Daniel", "Pierre", "Aim", "Bles", "Gustav", "Camill", "Rafael", "Natali", "Lulu", "Lor", "Clar", "Adel", "Anet", "Agata" };
        string[] FrenchSurnameArray = { "Azule", "Arno", "Arkur", "Arias", "Buzho", "Bosh", "Benua", "Zharr", "Dumash", "Labule", "Ledu", "Mereli", "Peti", "Reber" };

        string[] EnNameArray = { "Amelia", "Olivia", "Oliver", "Jack", "Harry", "Jacob", "Charlie", "Thomas", "Oscar", "William", "James", "George", "Alfie", "Leo", "Henry", "Max", "Jake", "Lola", "Holly", "Lilly", "Rosie" };
        string[] EnSurnameArray = { "Abramson", "Adderiy", "Howard", "Holiday", "Jeff", "Jenkin", "Batton", "Alsopp", "Andrews", "Arnold", "Kelly", "Page", "Day", "Derrick", "Ralphs", "Ryder", "Young", "Haig" };

        string[] CanadaNameArray = { "Carter", "Daniel", "Felix", "Gabriel", "Jacob", "Antoine", "Alexis", "Liam", "Mason", "Noah", "Olivier", "Owen", "Lucas", "Tyler", "William", "Hailey", "Jessica", "Lea" };
        string[] CanadaSurnameArray = { "Abramson", "Adderiy", "Howard", "Holiday", "Jeff", "Jenkin", "Batton", "Alsopp", "Andrews", "Arnold", "Kelly", "Page", "Day", "Derrick", "Ralphs", "Ryder", "Young", "Haig" };

        string[] Sport = { "Biathlon", "Bobsleigh", "Curling", "Snowboard", "Ski race", "Skiing", };
        #endregion


        public void NewSportsmen(Tab1 tab)
        {
            Sportsmen sportsmen = new Sportsmen();

            sportsmen.Country   = tab.Country.Text == ""    ? "Country"     : tab.Country.Text;
            sportsmen.Name      = tab.NameT.Text == ""      ? "Name"        : tab.NameT.Text;
            sportsmen.Surname   = tab.Surname.Text == ""    ? "Surname"     : tab.Surname.Text;
            sportsmen.Age       = tab.Age.Text == ""        ? "0"           : tab.Age.Text;
            sportsmen.Sport     = tab.Sport.Text == ""      ? "Sport"       : tab.Sport.Text;
            sportsmen.Gold      = tab.Gold.Text == ""       ? "0"           : tab.Gold.Text;
            sportsmen.Silver    = tab.Silver.Text == ""     ? "0"           : tab.Silver.Text;
            sportsmen.Bronze    = tab.Bronze.Text == ""     ? "0"           : tab.Bronze.Text;

            Variables.sportsmens.Add(sportsmen);
        }

        public void ReWriteSportsmen(Tab1 tab)
        {
            Sportsmen sportsmen = new Sportsmen();

            sportsmen.Country    = tab.Country.Text;
            sportsmen.Name       = tab.NameT.Text;
            sportsmen.Surname    = tab.Surname.Text;
            sportsmen.Age        = tab.Age.Text;
            sportsmen.Sport      = tab.Sport.Text;

            sportsmen.Gold       = tab.Gold.Text;
            sportsmen.Silver     = tab.Silver.Text;
            sportsmen.Bronze     = tab.Bronze.Text;

            Variables.sportsmens[Variables.tmpIndex] = sportsmen;
        }

        public void RandomData(Tab1 tab)
        {
            Random random = new Random();

            tab.Country.Text = countryArray[random.Next(0, countryArray.Length)];
            switch (tab.Country.Text)
            {
                case "Japan":
                    tab.NameT.Text = JapanNameArray[random.Next(0, JapanNameArray.Length)];
                    tab.Surname.Text = JapanSurnameArray[random.Next(0, JapanSurnameArray.Length)];
                    break;
                case "Germany":
                    tab.NameT.Text = GermanyNameArray[random.Next(0, GermanyNameArray.Length)];
                    tab.Surname.Text = GermanySurnameArray[random.Next(0, GermanySurnameArray.Length)];
                    break;
                case "Russian":
                    tab.NameT.Text = RussianNameArray[random.Next(0, RussianNameArray.Length)];
                    tab.Surname.Text = RussianSurnameArray[random.Next(0, RussianSurnameArray.Length)];
                    break;
                case "French":
                    tab.NameT.Text = FrenchNameArray[random.Next(0, FrenchNameArray.Length)];
                    tab.Surname.Text = FrenchSurnameArray[random.Next(0, FrenchSurnameArray.Length)];
                    break;
                case "Gr. Britain":
                    tab.NameT.Text = EnNameArray[random.Next(0, EnNameArray.Length)];
                    tab.Surname.Text = EnSurnameArray[random.Next(0, EnSurnameArray.Length)];
                    break;
                case "USA":
                    tab.NameT.Text = EnNameArray[random.Next(0, EnNameArray.Length)];
                    tab.Surname.Text = EnSurnameArray[random.Next(0, EnSurnameArray.Length)];
                    break;
                case "Canada":
                    tab.NameT.Text = CanadaNameArray[random.Next(0, CanadaNameArray.Length)];
                    tab.Surname.Text = CanadaSurnameArray[random.Next(0, CanadaSurnameArray.Length)];
                    break;
            }

            tab.Age.Text = random.Next(25, 51).ToString();
            tab.Sport.Text = Sport[random.Next(0, Sport.Length)];
            tab.Gold.Text = random.Next(0, 8).ToString();
            tab.Silver.Text = random.Next(0, 14).ToString();
            tab.Bronze.Text = random.Next(0, 21).ToString();
        }
    }
}
