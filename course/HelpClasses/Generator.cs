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
        string[] countryArray = { "Japan", "Germany", "Russia", "French", "Gr. Britain", "USA", "Canada" };

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

        public Sportsmen RandomData()
        {
            Random random = new Random();
            Sportsmen sportsmen = new Sportsmen();

            sportsmen.Country = countryArray[random.Next(0, countryArray.Length)];
            switch (sportsmen.Country)
            {
                case "Japan":
                    sportsmen.Name = JapanNameArray[random.Next(0, JapanNameArray.Length)];
                    sportsmen.Surname = JapanSurnameArray[random.Next(0, JapanSurnameArray.Length)];
                    break;
                case "Germany":
                    sportsmen.Name = GermanyNameArray[random.Next(0, GermanyNameArray.Length)];
                    sportsmen.Surname = GermanySurnameArray[random.Next(0, GermanySurnameArray.Length)];
                    break;
                case "Russian":
                    sportsmen.Name = RussianNameArray[random.Next(0, RussianNameArray.Length)];
                    sportsmen.Surname = RussianSurnameArray[random.Next(0, RussianSurnameArray.Length)];
                    break;
                case "French":
                    sportsmen.Name = FrenchNameArray[random.Next(0, FrenchNameArray.Length)];
                    sportsmen.Surname = FrenchSurnameArray[random.Next(0, FrenchSurnameArray.Length)];
                    break;
                case "Gr. Britain":
                    sportsmen.Name = EnNameArray[random.Next(0, EnNameArray.Length)];
                    sportsmen.Surname = EnSurnameArray[random.Next(0, EnSurnameArray.Length)];
                    break;
                case "USA":
                    sportsmen.Name = EnNameArray[random.Next(0, EnNameArray.Length)];
                    sportsmen.Surname = EnSurnameArray[random.Next(0, EnSurnameArray.Length)];
                    break;
                case "Canada":
                    sportsmen.Name = CanadaNameArray[random.Next(0, CanadaNameArray.Length)];
                    sportsmen.Surname = CanadaSurnameArray[random.Next(0, CanadaSurnameArray.Length)];
                    break;
            }

            sportsmen.Age = random.Next(25, 51);
            sportsmen.Sport = Sport[random.Next(0, Sport.Length)];
            sportsmen.Gold = random.Next(0, 8);
            sportsmen.Silver = random.Next(0, 14);
            sportsmen.Bronze = random.Next(0, 21);

            return sportsmen;
        }
    }
}
