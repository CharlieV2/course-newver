using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace course.UnitTestProject1
{
    [TestClass]
    public class UIcreator_Test
    {
        UIcreator ui = new UIcreator();


        [TestMethod]
        public void UIcreator_Actions()
        {
            // when create
            Panel testPanel = ui.Actions("create", "test_bdname");

            Assert.AreEqual(Color.FromArgb(140, 115, 253, 198), testPanel.BackColor);

            // when delete
            File.WriteAllText(Variables.path + "test_bdname" + ".bd", "");

            testPanel = ui.Actions("delete", "test_bdname");

            Assert.AreEqual(Color.FromArgb(140, 255, 70, 74), testPanel.BackColor);

            File.Delete(Variables.path + "test_bdname" + ".bd");
        }

        [TestMethod]
        public void UIcreator_NewLabel()
        {
            Label lbl = ui.NewLabel("expected label text", new Point(0, 0));

            Assert.AreEqual("expected label text", lbl.Text);
            Assert.AreEqual(Color.White, lbl.ForeColor);
            Assert.AreEqual(new Font("Segoe UI Light", 10, FontStyle.Regular), lbl.Font);
        }

        [TestMethod]
        public void UIcreator_CreateElements()
        {
            Generator gen = new Generator();

            Sportsmen sportsmen = gen.RandomData();
            Panel pnl = ui.CreateElements_General(sportsmen, new Tab1());

            Assert.AreEqual(11, pnl.Controls.Count);
        }
    }
}
