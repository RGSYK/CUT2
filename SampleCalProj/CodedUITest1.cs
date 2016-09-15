using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace SampleCalProj
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            string ApplicationPath = "C:\\Windows\\System32\\calc.exe";
            ApplicationUnderTest application = ApplicationUnderTest.Launch(ApplicationPath);

            //Define Calculator Main window
            WinWindow mainWindow = new WinWindow();
            mainWindow.SearchProperties.Add(WinWindow.PropertyNames.Name, "Calculator");
            mainWindow.WindowTitles.Add("Calculator");

            //Click on 7 (seven) button. 
            WinButton btnSeven = new WinButton(mainWindow);
            btnSeven.SearchProperties.Add(WinButton.PropertyNames.Name, "7");
            btnSeven.WindowTitles.Add("Calculator");
            Mouse.Click(btnSeven);

            //Click (+) plus button. 
            WinButton btnPlus = new WinButton(mainWindow);
            btnPlus.SearchProperties.Add(WinButton.PropertyNames.Name, "Add");
            btnPlus.WindowTitles.Add("Calculator");
            Mouse.Click(btnPlus);

            //Click 3 (three) button.
            WinButton btnThree = new WinButton(mainWindow);
            btnThree.SearchProperties.Add(WinButton.PropertyNames.Name, "3");
            btnThree.WindowTitles.Add("Calculator");
            Mouse.Click(btnThree);

            //Click (=) equals button. 
            WinButton btnEquals = new WinButton(mainWindow);
            btnEquals.SearchProperties.Add(WinButton.PropertyNames.Name, "Equals");
            btnEquals.WindowTitles.Add("Calculator");
            Mouse.Click(btnEquals);

            //Verify the result. 
            WinText txtResult = new WinText(mainWindow);
            txtResult.SearchProperties.Add(WinText.PropertyNames.Name, "Result");
            txtResult.WindowTitles.Add("Calculator");
            Assert.AreEqual("10", txtResult.DisplayText);

            application.Close();
        
        
        }
    }

}
