using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using course.Properties;
using System.Windows.Forms.DataVisualization.Charting;


namespace course
{
    public class UIcreator
    {
        //-----//
        // цвета элементов
        public static Color defaultColor = Color.FromArgb(202, 202, 202);
        public static Color activeColor = Color.FromArgb(66, 191, 244);

        // отслеживание текущего элемента
        Panel CurrentChoose = null;
        //-----//

        // actions panel
        public Panel Actions(string action, string BdName)
        {
            // Создание информационной панели о действии
            Panel actionPanel = new Panel();


            Label actionInfo = NewLabel("", new Point(0, 0));
            actionInfo.TextAlign = ContentAlignment.MiddleCenter;

            switch (action)
            {
                case "create":
                    actionInfo.Text = $"Created new BD\n{BdName}";
                    actionPanel.BackColor = Color.FromArgb(140, 115, 253, 198);
                    actionPanel.Size = new Size(160, 45);

                    actionInfo.Size = new Size(160, 45);
                    break;

                case "delete":
                    string strok = File.ReadAllText(Variables.path + BdName + ".txt").Trim().Split('\n').Length.ToString();

                    actionInfo.Text = $"Deleted BD\n{BdName}\n({strok} стр.)";
                    actionPanel.BackColor = Color.FromArgb(140, 255, 70, 74);
                    actionPanel.Size = new Size(160, 62);

                    actionInfo.Size = new Size(160, 62);
                    break;

                default:
                    break;
            }

            actionPanel.Controls.Add(actionInfo);

            return actionPanel;
        }


        // help funcs
        public Label NewLabel(string Text, Point Location)
        {
            Label lbl = new Label();

            lbl.Text = Text;
            lbl.Location = Location;

            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Segoe UI Light", 10, FontStyle.Regular);
            lbl.Width = 130;

            return lbl;
        }
        public PictureBox NewPictureBox(Image image, Point location)
        {
            PictureBox pb = new PictureBox();

            pb.Image = image;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(30, 30);
            pb.Location = location;

            return pb;
        }
        public Button NewButton(Font font, FlatStyle flatstyle, Panel ElementsPanel)
        {
            Button btn = new Button();
            FileWorker fileWorker = new FileWorker();

            btn.TabStop = false;
            btn.BackColor = Color.FromArgb(123, 165, 240);
            btn.Font = font;
            btn.FlatStyle = flatstyle;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.FromArgb(123, 165, 240);

            btn.Text = "Save chart";
            btn.Size = new Size(280, 30);
            btn.Click += new EventHandler(btnSaveChart_Click);
            void btnSaveChart_Click(object sender, EventArgs e) => fileWorker.SaveChart((ElementsPanel.Controls[0] as Chart), sender);

            return btn;
        }


        // creating elements
        public Panel CreateElements_General(Sportsmen sportsmen, Tab1 tab)
        {
            #region Creating elements
            // главная панель
            Panel MainPanel = new Panel();
            MainPanel.Size = new Size(280, 82);

            MainPanel.BackColor = defaultColor;
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.BringToFront();


            // страна, фамилия + имя, возраст, вид спорта
            Label countrylab = NewLabel(sportsmen.Country, new Point(1, 1));
            Label namelab = NewLabel(sportsmen.Name + " " + sportsmen.Surname, new Point(1, 20));
            Label agelab = NewLabel("Age " + sportsmen.Age, new Point(1, 39));
            Label sportlab = NewLabel(sportsmen.Sport, new Point(1, 58));


            // золото
            PictureBox goldimage = NewPictureBox(Resources.gold, new Point(140, 5));
            Label goldlab = NewLabel(sportsmen.Gold, new Point(140, 40));

            goldlab.TextAlign = ContentAlignment.MiddleCenter;
            goldlab.Size = new Size(30, 15);


            // серебро
            PictureBox silverimage = NewPictureBox(Resources.silver, new Point(180, 5));
            Label silverlab = NewLabel(sportsmen.Silver, new Point(180, 40));

            silverlab.TextAlign = ContentAlignment.MiddleCenter;
            silverlab.Size = new Size(30, 15);

            // бронза
            PictureBox bronzeimage = NewPictureBox(Resources.bronze, new Point(220, 5));
            Label bronzelab = NewLabel(sportsmen.Bronze, new Point(220, 40));

            bronzelab.TextAlign = ContentAlignment.MiddleCenter;
            bronzelab.Size = new Size(30, 15);


            // кнопка выбора
            PictureBox edit = new PictureBox();
            edit.Image = Resources.right_arrow;

            edit.SizeMode = PictureBoxSizeMode.Zoom;

            edit.Size = new Size(30, 30);
            edit.Location = new Point(250, 25);

            edit.MouseEnter += new EventHandler(Edit_MouseEnter);
            edit.MouseLeave += new EventHandler(Edit_MouseLeave);
            edit.Click += new EventHandler(Edit_Click);
            #endregion

            // функции кнопки редактирования
            void Edit_Click(object sender, EventArgs e)
            {
                if (CurrentChoose != null)
                    CurrentChoose.BackColor = defaultColor;

                CurrentChoose = MainPanel;
                CurrentChoose.BackColor = activeColor;


                // сохранение данных о текущем элементе
                Variables.SelectedSportsmen = sportsmen;
                Variables.SelectedPanel = MainPanel;

                tab.SelectElement();
            }

            void Edit_MouseEnter(object sender, EventArgs e)
            {
                edit.Image = Resources.right_arrow_active;
            }
            void Edit_MouseLeave(object sender, EventArgs e)
            {
                edit.Image = Resources.right_arrow;
            }




            MainPanel.Controls.Add(countrylab);
            MainPanel.Controls.Add(namelab);
            MainPanel.Controls.Add(agelab);
            MainPanel.Controls.Add(sportlab);

            MainPanel.Controls.Add(goldimage);
            MainPanel.Controls.Add(silverimage);
            MainPanel.Controls.Add(bronzeimage);

            MainPanel.Controls.Add(goldlab);
            MainPanel.Controls.Add(silverlab);
            MainPanel.Controls.Add(bronzelab);

            MainPanel.Controls.Add(edit);


            return MainPanel;
        }
        public Panel CreateElements_4_1(string surname, string sport)
        {
            // Для заданной страны вывести список команды с указанием
            // фамилии спортсмена и вида спорта 

            #region creating elements

            // главная панель
            Panel MainPanel = new Panel();
            MainPanel.Size = new Size(280, 41);

            MainPanel.BackColor = defaultColor;
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.BringToFront();


            // фамилия + спорт
            Label label = NewLabel(surname + "  -  " + sport, new Point(1, 1));

            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(278, 35);
            #endregion

            MainPanel.Controls.Add(label);

            return MainPanel;
        }
        public Panel CreateElements_4_2(string country, string name)
        {
            #region creating elements
            // главная панель
            Panel MainPanel = new Panel();
            MainPanel.Size = new Size(280, 60);

            MainPanel.BackColor = defaultColor;
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.BringToFront();


            // страна
            Label lblCountry = NewLabel(country, new Point(1, 1));

            lblCountry.TextAlign = ContentAlignment.MiddleCenter;
            lblCountry.Size = new Size(278, 30);


            // имя + фамилия
            Label lblName = NewLabel(name, new Point(1, 22));

            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Size = new Size(278, 30);
            #endregion

            MainPanel.Controls.Add(lblCountry);
            MainPanel.Controls.Add(lblName);

            return MainPanel;
        }
        public Panel CreateElements_4_3(string country, int gold, int silver, int bronze)
        {
            #region creating elements
            // главная панель 
            Panel MainPanel = new Panel();
            MainPanel.Size = new Size(280, 70);

            MainPanel.BackColor = defaultColor;
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.BringToFront();

            // страна
            Label lblCountry = NewLabel(country, new Point(1, 1));

            lblCountry.TextAlign = ContentAlignment.MiddleCenter;
            lblCountry.Size = new Size(278, 30);


            // gold
            PictureBox picGold = NewPictureBox(Properties.Resources.gold, new Point(10, 32));

            Label lblGold = new Label();

            lblGold.Location = new Point(40, 34);
            lblGold.Size = new Size(30, 30);

            lblGold.Text = gold.ToString();
            lblGold.TextAlign = ContentAlignment.MiddleCenter;
            lblGold.ForeColor = Color.White;
            lblGold.Font = new Font("Segoe UI Light", 13, FontStyle.Regular);


            // silver
            PictureBox picSilver = NewPictureBox(Properties.Resources.silver, new Point(110, 32));

            Label lblSilver = new Label();

            lblSilver.Location = new Point(140, 34);
            lblSilver.Size = new Size(30, 30);

            lblSilver.Text = silver.ToString();
            lblSilver.TextAlign = ContentAlignment.MiddleCenter;
            lblSilver.ForeColor = Color.White;
            lblSilver.Font = new Font("Segoe UI Light", 13, FontStyle.Regular);


            // bronze
            PictureBox picBronze = NewPictureBox(Properties.Resources.bronze, new Point(210, 32));

            Label lblBronze = new Label();

            lblBronze.Location = new Point(240, 34);
            lblBronze.Size = new Size(30, 30);

            lblBronze.Text = bronze.ToString();
            lblBronze.TextAlign = ContentAlignment.MiddleCenter;
            lblBronze.ForeColor = Color.White;
            lblBronze.Font = new Font("Segoe UI Light", 13, FontStyle.Regular);






            #endregion

            MainPanel.Controls.Add(lblCountry);
            MainPanel.Controls.Add(picGold);
            MainPanel.Controls.Add(lblGold);
            MainPanel.Controls.Add(picSilver);
            MainPanel.Controls.Add(lblSilver);
            MainPanel.Controls.Add(picBronze);
            MainPanel.Controls.Add(lblBronze);

            return MainPanel;

        }
        public Chart CreateElements_4_4(List<string> age, List<int> awards)
        {

            Chart newChart = new Chart();
            newChart.Size = new Size(265, 300);


            //--- chart area
            newChart.ChartAreas.Add(new ChartArea());

            //newChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            newChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            newChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);


            //--- series
            newChart.Series.Add(new Series());

            newChart.Series[0].ChartType = SeriesChartType.Line;
            newChart.Series[0].MarkerStyle = MarkerStyle.Circle;
            newChart.Series[0].MarkerSize = 7;


            newChart.Palette = ChartColorPalette.Excel;


            newChart.Series[0].Points.DataBindXY(age, awards);

            return newChart;
        }
        public Chart CreateElements_4_5(Dictionary<string, int> data)
        {
            Chart newChart = new Chart();
            newChart.Size = new Size(275, 300);

            newChart.ChartAreas.Add(new ChartArea());
            newChart.Series.Add(new Series());
            newChart.Series[0].ChartType = SeriesChartType.Pie;

            newChart.Palette = ChartColorPalette.Excel;

            newChart.Series[0].Points.DataBindXY(data.Keys, data.Values);
            
            return newChart;
        }

        public Chart CreateElements_4_6(Dictionary<string, int> data)
        {
            Chart newChart = new Chart();
            newChart.Size = new Size(260, 300);

            newChart.ChartAreas.Add(new ChartArea());
            newChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            newChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            newChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);

            newChart.Series.Add(new Series());
            newChart.Series[0].ChartType = SeriesChartType.Column;

            newChart.Palette = ChartColorPalette.Excel;

            newChart.Series[0].Points.DataBindXY(data.Keys, data.Values);

            return newChart;
        }
    }
}
