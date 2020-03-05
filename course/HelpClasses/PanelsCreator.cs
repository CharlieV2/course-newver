using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course.HelpClasses
{
    public class PanelsCreator
    {
        UIcreator ui = new UIcreator();

        public void CreatePanels_General(Panel ElementsPanel, Tab1 tab)
        {
            Panel element = new Panel();

            foreach (Sportsmen item in Variables.sportsmens)
            {
                element = ui.CreateElements_General(item, tab);
                Variables.elements.Add(element);

                ElementsPanel.Controls.Add(element);
            }
        }
        public void CreatePanels_4_1(Panel ElementsPanel, string country)
        {
            foreach (Sportsmen item in Variables.sportsmens)
            {
                if (item.Country.ToLower() == country.ToLower())
                {
                    ElementsPanel.Controls.Add(ui.CreateElements_4_1(item.Surname, item.Sport));
                }
            }

            ElementsPanel.Width = ElementsPanel.Controls.Count > 7 ? 306 : 286;
        }
        public void CreatePanels_4_2(Panel ElementsPanel, List<Sportsmen> sportsmens)
        {
            ElementsPanel.Width = sportsmens.Count > 5 ? 306 : 286;

            foreach (Sportsmen item in sportsmens)
            {
                ElementsPanel.Controls.Add(ui.CreateElements_4_2(item.Country, item.Name + " " + item.Surname));
            }
        }
        public void CreatePanels_4_3(Panel ElementsPanel, Dictionary<string, Dictionary<string, int>> countries)
        {
            foreach (var item in countries)
            {
                ElementsPanel.Controls.Add(ui.CreateElements_4_3(item.Key, item.Value["Gold"], item.Value["Silver"], item.Value["Bronze"]));
            }

            ElementsPanel.Width = ElementsPanel.Controls.Count > 5 ? 306 : 286;
        }
        public void CreatePanels_4_4(Panel ElementsPanel, List<string> age, List<int> awards)
        {
            // add save chart button
            Button btnSaveChart = ui.NewButton(new Font("Segoe UI Light", 9F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))), FlatStyle.Flat, ElementsPanel);

            // paint 
            ElementsPanel.Controls.Add(ui.CreateElements_4_4(age, awards));
            ElementsPanel.Controls.Add(btnSaveChart);
        }
        public void CreatePanels_4_5(Panel ElementsPanel, Dictionary<string, int> data)
        {
            // add save chart button
            Button btnSaveChart = ui.NewButton(new Font("Segoe UI Light", 9F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))), FlatStyle.Flat, ElementsPanel);

            // paint 
            ElementsPanel.Controls.Add(ui.CreateElements_4_5(data));
            ElementsPanel.Controls.Add(btnSaveChart);
        }
        public void CreatePanels_4_6(Panel ElementsPanel, Dictionary<string, int> data)
        {
            // add save chart button
            Button btnSaveChart = ui.NewButton(new Font("Segoe UI Light", 9F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))), FlatStyle.Flat, ElementsPanel);

            // paint 
            ElementsPanel.Controls.Add(ui.CreateElements_4_6(data));
            ElementsPanel.Controls.Add(btnSaveChart);
        }
    }
}
