using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace course.UnitTestProject1
{
    [TestClass]
    public class BDhandler_Test
    {
        BDhandler bdh = new BDhandler();

        [TestMethod]
        public void BDhandler_UpdateEnabled()
        {
            bool status;

            // when none selected
            bdh.UpdateEnabled("none selected");

            Assert.AreEqual(false, (bdh.tab1.SaveBut.Enabled && bdh.tab1.DelBut.Enabled));

            // when has data
            bdh.UpdateEnabled("has data");

            status = !bdh.BdInfo.Visible &&
                      bdh.ElementsPanel.Visible &&
                      bdh.tab1.NewBut.Enabled &&
                      bdh.tab2.Enabled &&
                      bdh.TabBut2.Enabled &&
                      bdh.TabBut3.Enabled;

            Assert.AreEqual(true, status);

            // when empty
            bdh.UpdateEnabled("empty");

            Assert.AreEqual("Выбранная база данных\nне содержит элементов", bdh.BdInfo.Text);

            status = bdh.BdInfo.Visible &&
                    !bdh.ElementsPanel.Visible &&
                     bdh.BDstatusInfoPanel.Visible &&
                     bdh.tab1.NewBut.Enabled &&
                    !bdh.tab1.SaveBut.Enabled &&
                    !bdh.tab1.DelBut.Enabled &&
                    !bdh.tab2.Enabled &&
                    !bdh.tab3.Enabled &&
                    !bdh.TabBut2.Enabled &&
                    !bdh.TabBut3.Enabled;

            Assert.AreEqual(true, status);

            // when not exists
            bdh.UpdateEnabled("not exists");

            status = !bdh.ElementsPanel.Visible &&
                      bdh.BDstatusInfoPanel.Visible &&
                     !bdh.tab1.NewBut.Enabled &&
                     !bdh.tab1.SaveBut.Enabled &&
                     !bdh.tab1.DelBut.Enabled &&
                     !bdh.tab2.Enabled &&
                     !bdh.tab3.Enabled &&
                     !bdh.TabBut2.Enabled &&
                     !bdh.TabBut3.Enabled;

            Assert.AreEqual(true, status);
        }

        [TestMethod]
        public void BDhandler_CreateElementPanels()
        {
            Generator gen = new Generator();
            Sportsmen sportsmen = gen.RandomData();

            Variables.sportsmens.Clear();

            // create new sportsmens
            Variables.sportsmens.Add(sportsmen);
            Variables.sportsmens.Add(sportsmen);

            bdh.CreateElementPanels("general");

            Assert.AreEqual(2, bdh.ElementsPanel.Controls.Count);

            // add 3 more sportsmen
            bdh.ElementsPanel.Controls.Clear();

            Variables.sportsmens.Add(sportsmen);
            Variables.sportsmens.Add(sportsmen);
            Variables.sportsmens.Add(sportsmen);

            bdh.CreateElementPanels("general");

            Assert.AreEqual(5, bdh.ElementsPanel.Controls.Count);
        }

        [TestMethod]
        public void BDhandler_ElementsPanelManipulation()
        {
            bool status = true;

            // clear
            bdh.ElementsPanel_Clear();

            foreach (TextBox item in bdh.tab1.Controls.OfType<TextBox>().ToArray())
            {
                if (item.Text != "") status = false;
            }

            Assert.AreEqual(true, status);
            Assert.AreEqual(0, bdh.ElementsPanel.Controls.Count);
            Assert.AreEqual(286, bdh.ElementsPanel.Width);


            // fill             
            // add 3 items
            Variables.elements.Clear();
            bdh.ElementsPanel.Controls.Clear();

            Variables.elements.Add(new Panel());
            Variables.elements.Add(new Panel());
            Variables.elements.Add(new Panel());

            bdh.ElementsPanel_Fill();

            Assert.AreEqual(3, bdh.ElementsPanel.Controls.Count);
            bdh.ElementsPanel.Controls.Clear();

            // add 2 more items
            Variables.elements.Add(new Panel());
            Variables.elements.Add(new Panel());

            bdh.ElementsPanel_Fill();

            Assert.AreEqual(5, bdh.ElementsPanel.Controls.Count);
            bdh.ElementsPanel.Controls.Clear();
        }
    }
}
