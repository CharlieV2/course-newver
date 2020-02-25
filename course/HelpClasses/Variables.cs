using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace course
{
    public static class Variables
    {
        // список спортсменов в текущей БД
        public static List<Sportsmen> sportsmens = new List<Sportsmen>();


        public static Sportsmen SelectedSportsmen;
        public static Panel SelectedPanel;

        public static int tmpIndex;

        public static List<Panel> elements = new List<Panel>();


        // путь к папке с базами данных
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\";
    }
}
