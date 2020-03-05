using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using course.HelpClasses;

namespace course
{
    public partial class BDhandler : UserControl
    {
        //--------//
        FileWorker fileWorker = new FileWorker();

        UIcreator ui = new UIcreator();
        PanelsCreator panelsCreator = new PanelsCreator();
        //--------//

        public BDhandler()
        {
            InitializeComponent();
            InitializeTabControl();

            DirectoryPath.Text = Variables.path;

            ElementsPanel.Location = new Point(6, 67);
            BackBut.BackColor = Color.FromArgb(0, 0, 0, 0);
        }




        #region ---- Input Handler ---->

        private void BdName_TextChanged(object sender, EventArgs e)
        {
            ElementsPanel_Clear();
            Variables.elements.Clear();
            Variables.sportsmens.Clear();

            switch (fileWorker.CheckBd(BdName.Text))
            {
                case "has data":

                    fileWorker.ReadBD(BdName.Text);
                    CreateElementPanels("general");

                    UpdateEnabled("has data");
                    break;

                case "empty":
                    UpdateEnabled("empty");
                    break;

                case "not exists":

                    BdInfo.Text = "Такой базы данных не существует";
                    // ставим BdInfo по центру панели
                    BdInfo.Location = new Point(ElementsPanel.Width / 2 - BdInfo.Width / 2, BdInfo.Location.Y);
                    BdInfo.Visible = true;

                    UpdateEnabled("not exists");
                    break;
            }
        }

        private void UpdateEnabled(string set)
        {
            // в зависимости от настройки меняет enabled кнопок и панелей
            switch (set)
            {
                case "none selected":
                    tab1.SaveBut.Enabled = false;
                    tab1.DelBut.Enabled = false;
                    break;


                case "has data":

                    BdInfo.Visible = false;
                    ElementsPanel.Visible = true;

                    // настройка кнопок редактирования БД
                    tab1.NewBut.Enabled = true;

                    // настройка TabControl
                    tab2.Enabled = true;
                    tab3.Enabled = true;
                    TabBut2.Enabled = true;
                    TabBut3.Enabled = true;

                    break;


                case "empty":

                    BdInfo.Text = "Выбранная база данных\nне содержит элементов";
                    // ставим BdInfo по центру панели
                    BdInfo.Location = new Point(ElementsPanel.Width / 2 - BdInfo.Width / 2, BdInfo.Location.Y);
                    BdInfo.Visible = true;

                    ElementsPanel.Visible = false;
                    BDstatusInfoPanel.Visible = true;

                    // настройка кнопок редактирования БД
                    tab1.NewBut.Enabled = true;
                    tab1.SaveBut.Enabled = false;
                    tab1.DelBut.Enabled = false;

                    // настройка TabControl
                    if (TabBut1.Size == new Size(60, 30)) TabBut1_Click(TabBut1, null);
                    tab2.Enabled = false;
                    tab3.Enabled = false;
                    TabBut2.Enabled = false;
                    TabBut3.Enabled = false;

                    break;


                case "not exists":

                    ElementsPanel.Visible = false;
                    BDstatusInfoPanel.Visible = true;

                    // настройка кнопок редактирования БД
                    tab1.NewBut.Enabled = false;
                    tab1.SaveBut.Enabled = false;
                    tab1.DelBut.Enabled = false;

                    // настройка TabControl
                    if (TabBut1.Size == new Size(60, 30)) TabBut1_Click(TabBut1, null);
                    tab2.Enabled = false;
                    tab3.Enabled = false;
                    TabBut2.Enabled = false;
                    TabBut3.Enabled = false;

                    break;
            }
        }

        public void DirectoryPath_TextChanged(object sender, EventArgs e)
        {
            Variables.path = DirectoryPath.Text;
            BdName.SelectedIndex = -1;

            BdName.Items.Clear();

            string[] files = Directory.GetFiles(Variables.path, "*.bd");
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileNameWithoutExtension(files[i]);
            }

            BdName.Items.AddRange(files);
        }

        #endregion <----

        #region ---- ElementsPanel Handler ---->
        // create panels
        public void CreateElementPanels(string set)
        {
            switch (set)
            {
                case "general":
                    // создание панелей на основе прочитанной бд
                    ElementsPanel.Width = Variables.sportsmens.Count > 4 ? 306 : 286;

                    panelsCreator.CreatePanels_General(ElementsPanel, tab1);
                    break;


                case "4.1":
                    #region task 4.1
                    // Для заданной страны вывести список команды с указанием
                    // фамилии спортсмена и вида спорта 
                    ElementsPanel_Clear();
                    panelsCreator.CreatePanels_4_1(ElementsPanel, tab2.Country.Text);
                    #endregion
                    break;


                case "4.2":
                    #region task 4.2
                    // Для заданного вида спорта вывести список спортсменов-участников
                    // с указанием страны в порядке возрастания результата

                    ElementsPanel_Clear();
                    List<Sportsmen> rowSportsmens = new List<Sportsmen>();

                    // фильтр по спорту
                    foreach (Sportsmen item in Variables.sportsmens)
                        if (item.Sport.ToLower() == tab2.Sport.Text.ToLower()) rowSportsmens.Add(item);

                    // сортировка
                    var sortedSportsmens = from item in rowSportsmens
                                         orderby (item.Gold + item.Silver + item.Bronze) ascending
                                         select item;

                    panelsCreator.CreatePanels_4_2(ElementsPanel, sortedSportsmens.ToList());
                    #endregion
                    break;


                case "4.3":
                    #region task 4.3
                    // Вывести таблицу стран-участниц с указанием
                    // количества зол., сереб. и бронз. наград (>)
                    ElementsPanel_Clear();

                    var countries = new Dictionary<string, Dictionary<string, int>>();

                    // заполнение словаря
                    foreach (Sportsmen item in Variables.sportsmens)
                    {
                        if (countries.ContainsKey(item.Country))
                        {
                            countries[item.Country]["Gold"] += item.Gold;
                            countries[item.Country]["Silver"] += item.Silver;
                            countries[item.Country]["Bronze"] += item.Bronze;
                        }
                        else
                        {
                            countries.Add(item.Country, new Dictionary<string, int>());

                            countries[item.Country].Add("Gold", item.Gold);
                            countries[item.Country].Add("Silver", item.Silver);
                            countries[item.Country].Add("Bronze", item.Bronze);
                        }

                    }


                    // сортировка
                    var sortedCountries = from pair in countries
                                       orderby (pair.Value["Gold"] + pair.Value["Silver"] + pair.Value["Bronze"]) descending
                                       select pair;

                    panelsCreator.CreatePanels_4_3(ElementsPanel, sortedCountries.ToDictionary(pair => pair.Key, pair => pair.Value));
                    #endregion
                    break;


                case "4.4":
                    #region task 4.4
                    ElementsPanel_Clear();

                    // calculate
                    var rowChartData = new Dictionary<string, List<int>>();

                    // агрегатор   возраст : количество наград, участников такого возраста
                    foreach (Sportsmen item in Variables.sportsmens)
                    {
                        if (item.Sport.ToLower() == tab3.Sport44.Text.ToLower())
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
                    List<int> avrgAwardsChartData = new List<int>();

                    int avrgAwards;

                    foreach (var item in sortedChartData)
                    {
                        avrgAwards = item.Value[0] / item.Value[1];

                        ageChartData.Add(item.Key);
                        avrgAwardsChartData.Add(avrgAwards);
                    }
                    
                    panelsCreator.CreatePanels_4_4(ElementsPanel, ageChartData, avrgAwardsChartData);
                    #endregion
                    break;


                case "4.5":
                    #region task 4.5
                    ElementsPanel_Clear();

                    var data45 = new Dictionary<string, int>();

                    foreach (Sportsmen item in Variables.sportsmens)
                    {
                        if (item.Sport.ToLower() == tab3.Sport45.Text.ToLower())
                        {
                            if (data45.ContainsKey(item.Country))
                                data45[item.Country]++;
                            else
                                data45.Add(item.Country, 1);
                        }
                    }

                    panelsCreator.CreatePanels_4_5(ElementsPanel, data45);
                    #endregion
                    break;


                case "4.6":
                    #region task 4.6 
                    ElementsPanel_Clear();

                    var data46 = new Dictionary<string, int>();

                    foreach (Sportsmen item in Variables.sportsmens)
                    {
                        if (data46.ContainsKey(item.Country))
                            data46[item.Country]++;
                        else
                            data46.Add(item.Country, 1);
                    }

                    panelsCreator.CreatePanels_4_6(ElementsPanel, data46);
                    #endregion
                    break;
            }
        }

        private void ElementsPanel_Clear()
        {
            // очистка текстовых полей
            foreach (TextBox item in tab1.Controls.OfType<TextBox>().ToArray())
            {
                item.Clear();
            }

            ElementsPanel.Controls.Clear();

            ElementsPanel.Width = 286;
        }
        private void ElementsPanel_Fill()
        {
            foreach (Panel element in Variables.elements)
            {
                ElementsPanel.Controls.Add(element);
            }

            ElementsPanel.Width = Variables.sportsmens.Count > 4 ? 306 : 286;
        }
        private void ElementsPanel_Update(object sender, EventArgs e)
        {
            fileWorker.SaveBd(BdName.Text);

            Panel element;
            switch ((sender as Button).Text)
            {
                case "New":
                    element = ui.CreateElements_General(Variables.sportsmens[Variables.sportsmens.Count - 1], tab1);
                    Variables.elements.Add(element);

                    UpdateEnabled("has data");
                    ElementsPanel.Controls.Add(element);
                    break;

                case "Save":
                    element = ui.CreateElements_General(Variables.sportsmens[Variables.tmpIndex], tab1);
                    Variables.elements[Variables.tmpIndex] = element;

                    UpdateEnabled("none selected");
                    ElementsPanel_Clear();
                    ElementsPanel_Fill();
                    break;

                case "Delete":
                    ElementsPanel.Controls.Remove(Variables.SelectedPanel);
                    Variables.elements.Remove(Variables.SelectedPanel);

                    UpdateEnabled("none selected");

                    if (ElementsPanel.Controls.Count == 0) UpdateEnabled("empty");
                    break;
            }

            ElementsPanel.Width = Variables.sportsmens.Count > 4 ? 306 : 286;
        }

        #endregion <----

        #region ---- TabControl ---->

        //CustomTabControl
        public Tab1 tab1 = new Tab1();
        public Tab2 tab2 = new Tab2();
        public Tab3 tab3 = new Tab3();

        Button CurrentTabSender;

        void InitializeTabControl()
        {
            Transform(TabBut1); // select first tab

            // TAB 1 - data base editor
            tab1.Location = new Point(324, 69);
            tab1.BackColor = Color.FromArgb(125, 0, 0, 0);

            tab1.SaveBut.Click += new EventHandler(ElementsPanel_Update);
            tab1.NewBut.Click  += new EventHandler(ElementsPanel_Update);
            tab1.DelBut.Click  += new EventHandler(ElementsPanel_Update);


            // TAB 2 - user requests handler
            tab2.Location = new Point(324, 69);
            tab2.BackColor = Color.FromArgb(125, 0, 0, 0);
            tab2.Visible = false;

            tab2.StartBut_4_1.Click += new EventHandler(StartBut_4_1_Click);
            void StartBut_4_1_Click(object sender, EventArgs e) => CreateElementPanels("4.1");

            tab2.StartBut_4_2.Click += new EventHandler(StartBut_4_2_Click);
            void StartBut_4_2_Click(object sender, EventArgs e) => CreateElementPanels("4.2");

            tab2.StartBut_4_3.Click += new EventHandler(StartBut_4_3_Click);
            void StartBut_4_3_Click(object sender, EventArgs e) => CreateElementPanels("4.3");


            // TAB 3 - graphs
            tab3.Location = new Point(324, 69);
            tab3.BackColor = Color.FromArgb(125, 0, 0, 0);
            tab3.Visible = false;

            tab3.StartBut_4_4.Click += new EventHandler(StartBut_4_4_Click);
            void  StartBut_4_4_Click(object sender, EventArgs e) => CreateElementPanels("4.4");

            tab3.StartBut_4_5.Click += new EventHandler(StartBut_4_5_Click);
            void StartBut_4_5_Click(object sender, EventArgs e) => CreateElementPanels("4.5");

            tab3.StartBut_4_6.Click += new EventHandler(StartBut_4_6_Click);
            void StartBut_4_6_Click(object sender, EventArgs e) => CreateElementPanels("4.6");


            // add tabs to the form
            Controls.Add(tab1);
            Controls.Add(tab2);
            Controls.Add(tab3);
        }


        // help functions
        void DisableAll()
        {
            // reset color
            (CurrentTabSender as Button).BackColor = Color.FromArgb(255, 201, 201, 201);

            // reset transform
            CurrentTabSender.Location = new Point(CurrentTabSender.Location.X + 2, CurrentTabSender.Location.Y + 2);
            CurrentTabSender.Size = new Size(60, 30);
            Application.DoEvents();

            //reset tab panel
            tab1.Visible = false;
            tab2.Visible = false;
            tab3.Visible = false;
        }
        private void Transform(object sender)
        {
            CurrentTabSender = (sender as Button);
            CurrentTabSender.BackColor = Color.FromArgb(255, 123, 165, 240);
            CurrentTabSender.BringToFront();
            CurrentTabSender.Size = new Size(64, 32);

            CurrentTabSender.Location = new Point(CurrentTabSender.Location.X - 2, CurrentTabSender.Location.Y - 2);
            Application.DoEvents();
        }


        // buttons click
        private void TabBut1_Click(object sender, EventArgs e)
        {
            TabBut1.Enabled = false;

            DisableAll();
            tab1.Visible = true;

            Transform(sender);

            ElementsPanel_Clear();
            ElementsPanel_Fill();

            TabBut1.Enabled = true;
        }
        private void TabBut2_Click(object sender, EventArgs e)
        {
            TabBut2.Enabled = false;

            DisableAll();
            tab2.Visible = true;

            Transform(sender);

            ElementsPanel_Clear();

            TabBut2.Enabled = true;
        }
        private void TabBut3_Click(object sender, EventArgs e)
        {
            TabBut3.Enabled = false;

            DisableAll();
            tab3.Visible = true;

            Transform(sender);

            ElementsPanel_Clear();

            TabBut3.Enabled = true; ;
        }

        #endregion <----



        #region ---- BDhandler Buttons ---->
        private void BackBut_Animation_Enter(object sender, EventArgs e)
        {
            BackBut.Image = Properties.Resources.Back_Active;
        }
        private void BackBut_Animation_Leave(object sender, EventArgs e)
        {
            BackBut.Image = Properties.Resources.Back_Default;
        }
        private void ClearBut_Click(object sender, EventArgs e)
        {
            BdName.SelectedIndex = -1;
        }

        #endregion <----

        #region ---- Drag and Drop ---->
        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (Path.GetExtension(file[0]) == ".bd")
            {
                Variables.path = Path.GetDirectoryName(file[0]) + @"\";
                DirectoryPath.Text = Variables.path;

                BdName.Text = Path.GetFileNameWithoutExtension(file[0]);
            }
            else
            {
                BdInfo.Text = "Формат загружаемого файла\nдолжен быть bd";
                BdInfo.Location = new Point(ElementsPanel.Width / 2 - BdInfo.Width / 2, BdInfo.Location.Y);

                BdInfo.Visible = true;
            }
        }

        #endregion <----
    }
}
