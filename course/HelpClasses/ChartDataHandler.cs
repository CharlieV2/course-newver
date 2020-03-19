using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.HelpClasses
{
    public class ChartDataHandler
    {
        public Tuple<List<string>, List<double>> Data_44(string Sport)
        {
            // calculate
            var rowChartData = new Dictionary<string, List<int>>();

            // агрегатор   возраст : количество наград, участников такого возраста
            foreach (Sportsmen item in Variables.sportsmens)
            {
                if (item.Sport.ToLower() == Sport.ToLower())
                {
                    if (rowChartData.ContainsKey(item.Age.ToString()))
                    {
                        rowChartData[item.Age.ToString()][0] += item.Gold + item.Silver + item.Bronze;
                        rowChartData[item.Age.ToString()][1]++;
                    }
                    else
                    {
                        rowChartData.Add(item.Age.ToString(), new List<int>());

                        rowChartData[item.Age.ToString()].Add(item.Gold + item.Silver + item.Bronze);
                        rowChartData[item.Age.ToString()].Add(1);
                    }
                }
            }


            // сортировка по возрасту <
            var sortedChartData = from pair in rowChartData
                                  orderby int.Parse(pair.Key) ascending
                                  select pair;

            // получение средних значений
            List<string> ageChartData = new List<string>();
            List<double> avrgAwardsChartData = new List<double>();

            double avrgAwards;

            foreach (var item in sortedChartData)
            {
                avrgAwards = Convert.ToDouble(item.Value[0]) / Convert.ToDouble(item.Value[1]);

                ageChartData.Add(item.Key);
                avrgAwardsChartData.Add(avrgAwards);
            }

            var result = Tuple.Create(ageChartData, avrgAwardsChartData);

            return result;
        }

        public Dictionary<string, int> Data_45(string Sport)
        {
            var data = new Dictionary<string, int>();

            foreach (Sportsmen item in Variables.sportsmens)
            {
                if (item.Sport.ToLower() == Sport)
                {
                    if (data.ContainsKey(item.Country))
                        data[item.Country]++;
                    else
                        data.Add(item.Country, 1);
                }
            }

            return data;
        }

        public Dictionary<string, int> Data_46()
        {
            var data = new Dictionary<string, int>();

            foreach (Sportsmen item in Variables.sportsmens)
            {
                if (data.ContainsKey(item.Country))
                    data[item.Country]++;
                else
                    data.Add(item.Country, 1);
            }

            return data;
        }
    }
}
