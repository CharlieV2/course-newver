﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace course
{
    public partial class MainForm : Form
    {
        //--------//
        FileWorker fileWorker = new FileWorker();
        UIcreator ui = new UIcreator();

        BDhandler bdhandler = new BDhandler();
        //--------//

        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        void InitializeControls()
        {
            // настройка прозрачности панелей
            DirectoryPath.Text = Variables.path;


            // добавление UserControl для работы с БД
            this.Controls.Add(bdhandler);
            bdhandler.Visible = false;
            bdhandler.Location = new Point(0, 0);
            bdhandler.BringToFront();

            bdhandler.BackBut.Click += new EventHandler(BDhandlerBackBut_Click);
        }
        
        #region MainForm_Buttons

        private void NewBDBut_Click(object sender, EventArgs e)
        {
            ActionsPanel.Controls.Add(ui.Actions("create", BdName.Text));

            fileWorker.CreateBd(BdName.Text);
            BdName.Clear();
        }
        private void DeleteBDBut_Click(object sender, EventArgs e)
        {
            ActionsPanel.Controls.Add(ui.Actions("delete", BdName.Text));

            fileWorker.DeleteBD(BdName.Text);
            BdName.Clear();
        }

        private void BdName_TextChanged(object sender, EventArgs e)
        {
            if (BdName.Text == "")
            {
                NewBDBut.Enabled = false;
                DeleteBDBut.Enabled = false;
                RewriteWarning.Visible = false;
            }
            else
            {
                NewBDBut.Enabled = true;

                if (File.Exists(Variables.path + BdName.Text + ".txt"))
                {
                    DeleteBDBut.Enabled = true;
                    RewriteWarning.Visible = true;
                }
                else
                {
                    DeleteBDBut.Enabled = false;
                    RewriteWarning.Visible = false;
                }
            }
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (ActionsPanel.Controls.Count > 0)
            {
                ActionsPanel.Controls[0].BackColor = Color.FromArgb(ActionsPanel.Controls[0].BackColor.A - 1,
                                                                    ActionsPanel.Controls[0].BackColor.R,
                                                                    ActionsPanel.Controls[0].BackColor.G,
                                                                    ActionsPanel.Controls[0].BackColor.B);

                if (ActionsPanel.Controls[0].BackColor.A <= 0) ActionsPanel.Controls.RemoveAt(0);

                Application.DoEvents();
            }
        }

        private void NextStepBut_Click(object sender, EventArgs e)
        {
            bdhandler.Visible = true;
            bdhandler.DirectoryPath.Text = DirectoryPath.Text;
            BdName.Clear();

            AnimationTimer.Enabled = false;
            while (ActionsPanel.Controls.Count > 0)
            {
                ActionsPanel.Controls.RemoveAt(0);
            }
        }
        private void BDhandlerBackBut_Click(object sender, EventArgs e)
        {
            bdhandler.Visible = false;
            bdhandler.BdName.Clear();
            bdhandler.BdInfo.Visible = false;

            DirectoryPath.Text = Variables.path;

            AnimationTimer.Enabled = true;
        }

        #endregion

        private void DirectoryPath_TextChanged(object sender, EventArgs e)
        {
            Variables.path = DirectoryPath.Text;
        }


        #region Drag and Drop

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

            if (Path.GetExtension(file[0]) == ".txt")
            {
                Variables.path = Path.GetDirectoryName(file[0]) + @"\";
                DirectoryPath.Text = Variables.path;

                BdName.Text = Path.GetFileNameWithoutExtension(file[0]);
            }
        }

        #endregion
    }
}
