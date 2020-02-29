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
            Age.Text =       Variables.SelectedSportsmen.Age;
            Sport.Text =     Variables.SelectedSportsmen.Sport;
            Gold.Text =      Variables.SelectedSportsmen.Gold;
            Silver.Text =    Variables.SelectedSportsmen.Silver;
            Bronze.Text =    Variables.SelectedSportsmen.Bronze;

            SaveBut.Enabled = true;
            DelBut.Enabled = true;
        }




        private void NewBut_Click(object sender, EventArgs e)
        {
            NewBut.Enabled = false;
            generator.NewSportsmen(this);
        }
        private void SaveBut_Click(object sender, EventArgs e)
        {
            SaveBut.Enabled = false;
            
            Variables.tmpIndex = Variables.sportsmens.IndexOf(Variables.SelectedSportsmen);

            generator.ReWriteSportsmen(this);
        }
        private void DelBut_Click(object sender, EventArgs e)
        {
            Variables.sportsmens.Remove(Variables.SelectedSportsmen);
        }
        private void RandomBut_Click(object sender, EventArgs e)
        {
            generator.RandomData(this);
        }

        private void Sport_TextChanged(object sender, EventArgs e)
        {

        }
        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
