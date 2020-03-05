using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course
{
    public partial class Tab1 : UserControl
    {
        Generator generator = new Generator();


        public Tab1()
        {
            InitializeComponent();

            Color alphazerocolor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackColor = alphazerocolor;
            pictureBox2.BackColor = alphazerocolor;
            pictureBox3.BackColor = alphazerocolor;
        }

        public void SelectElement()
        {
            Country.Text =   Variables.SelectedSportsmen.Country;
            NameT.Text =     Variables.SelectedSportsmen.Name;
            Surname.Text =   Variables.SelectedSportsmen.Surname;
            Age.Text =       Variables.SelectedSportsmen.Age.ToString();
            Sport.Text =     Variables.SelectedSportsmen.Sport;
            Gold.Text =      Variables.SelectedSportsmen.Gold.ToString();
            Silver.Text =    Variables.SelectedSportsmen.Silver.ToString();
            Bronze.Text =    Variables.SelectedSportsmen.Bronze.ToString();

            SaveBut.Enabled = true;
            DelBut.Enabled = true;
        }


        // buttons
        private void NewBut_Click(object sender, EventArgs e)
        {
            NewBut.Enabled = false;

            Sportsmen sportsmen = new Sportsmen();

            sportsmen.Country   = Country.Text == "" ? "Country" : Country.Text;
            sportsmen.Name      = NameT.Text == "" ? "Name" : NameT.Text;
            sportsmen.Surname   = Surname.Text == "" ? "Surname" : Surname.Text;
            sportsmen.Age       = Age.Text == "" ? 0 : int.Parse(Age.Text);
            sportsmen.Sport     = Sport.Text == "" ? "Sport" : Sport.Text;
            sportsmen.Gold      = Gold.Text == "" ? 0 : int.Parse(Gold.Text);
            sportsmen.Silver    = Silver.Text == "" ? 0 : int.Parse(Silver.Text);
            sportsmen.Bronze    = Bronze.Text == "" ? 0 : int.Parse(Bronze.Text);

            Variables.sportsmens.Add(sportsmen);

            NewBut.Enabled = true;
        }
        private void SaveBut_Click(object sender, EventArgs e)
        {
            SaveBut.Enabled = false;
            
            Variables.tmpIndex = Variables.sportsmens.IndexOf(Variables.SelectedSportsmen);

            Sportsmen sportsmen = new Sportsmen();

            sportsmen.Country = Country.Text;
            sportsmen.Name = NameT.Text;
            sportsmen.Surname = Surname.Text;
            sportsmen.Age = int.Parse(Age.Text);
            sportsmen.Sport = Sport.Text;

            sportsmen.Gold = int.Parse(Gold.Text);
            sportsmen.Silver = int.Parse(Silver.Text);
            sportsmen.Bronze = int.Parse(Bronze.Text);

            Variables.sportsmens[Variables.tmpIndex] = sportsmen;
        }
        private void DelBut_Click(object sender, EventArgs e)
        {
            Variables.sportsmens.Remove(Variables.SelectedSportsmen);
        }
        private void RandomBut_Click(object sender, EventArgs e)
        {
            Sportsmen data = generator.RandomData();

            Country.Text =  data.Country;
            NameT.Text =    data.Name;
            Surname.Text =  data.Surname;
            Age.Text =      data.Age.ToString();
            Sport.Text =    data.Sport;
            Gold.Text =     data.Gold.ToString();
            Silver.Text =   data.Silver.ToString();
            Bronze.Text =   data.Bronze.ToString();
        }
    }
}
