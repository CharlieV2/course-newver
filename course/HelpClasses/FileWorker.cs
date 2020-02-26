﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace course
{
    public class FileWorker
    {
        // bd
        public string CheckBd(string BdName)
        {
            if (File.Exists(Variables.path + BdName + ".txt"))
                if (File.ReadAllText(Variables.path + BdName + ".txt") == "") return "empty"; else return "has data";
            else return "not exists";
        }

        public void CreateBd(string BdName)
        {
            File.WriteAllText(Variables.path + BdName + ".txt", "");
        }

        public void SaveBd(string BdName)
        {
            string final = "";

            foreach(Sportsmen item in Variables.sportsmens)
            {
                final += item.Country + "_" +
                         item.Name + "_" +
                         item.Surname + "_" +
                         item.Age + "_" +
                         item.Sport + "_" +
                         item.Gold + "_" +
                         item.Silver + "_" +
                         item.Bronze + "\n";
            }

            File.WriteAllText(Variables.path + BdName + ".txt", final);
        }

        public void DeleteBD(string BdName)
        {
            if (File.Exists(Variables.path + BdName + ".txt")) File.Delete(Variables.path + BdName + ".txt");
        }

        public void ReadBD(string BdName)
        {
            // Обнуление существующей БД
            Variables.sportsmens.Clear();

            // чтение БД (массив строк, строка = спортсмен)
            string[] rowData = File.ReadAllText(Variables.path + BdName + ".txt").Trim().Split('\n');

            // в строке: 0-Country 1-Name 2-Surname 3-Age 4-Sport 5-Gold 6-Silver 7-Bronze
            foreach (string item in rowData)
            {
                string[] sportsmenRowInfo = item.Trim().Split('_');

                Sportsmen sportsmen = new Sportsmen();

                sportsmen.Country =   sportsmenRowInfo[0];
                sportsmen.Name =      sportsmenRowInfo[1];
                sportsmen.Surname =   sportsmenRowInfo[2];
                sportsmen.Age =       sportsmenRowInfo[3];
                sportsmen.Sport =     sportsmenRowInfo[4];
                sportsmen.Gold =      sportsmenRowInfo[5];
                sportsmen.Silver =    sportsmenRowInfo[6];
                sportsmen.Bronze =    sportsmenRowInfo[7];

                Variables.sportsmens.Add(sportsmen);
            }
        }


        // chart
        public void SaveChart(Chart chart, object sender)
        {
            (sender as Button).Enabled = false;

            string name = "Chart ";
            int counter = 1;

            while (File.Exists(Variables.path + name + counter + ".png")) counter++;

            chart.SaveImage(Variables.path + name + counter + ".png", ChartImageFormat.Png);

            (sender as Button).Enabled = true;
        }
    }
}
