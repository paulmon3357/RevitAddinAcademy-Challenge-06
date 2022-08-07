#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Media.Imaging;
using System.IO;

#endregion

namespace RevitAddinAcademy_Challenge_06
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            // step 1: crate ribbon tab
            try 
            {
                a.CreateRibbonTab("Revit Add-in Academy");
            }
            catch (Exception)
            {
                Debug.Print("Tab already exists");
            }


            // step 2: create ribbon panel
            //RibbonPanel curPanel = a.CreateRibbonPanel("Revit Add-in Academy","Revit Tools");
            RibbonPanel curPanel = CreateRibbonPanel(a, "Revit Add-in Academy", "Revit Tools");


            // step 3: create button data instances
            PushButtonData pData1 = new PushButtonData("button1", "Tool 1", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command01");
            PushButtonData pData2 = new PushButtonData("button2", "Tool 2", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command02");
            PushButtonData pData3 = new PushButtonData("button3", "Tool 3", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command03");
            PushButtonData pData4 = new PushButtonData("button4", "Tool 4", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command04");
            PushButtonData pData5 = new PushButtonData("button5", "Tool 5", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command05");
            PushButtonData pData6 = new PushButtonData("button6", "Tool 6", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command06");
            PushButtonData pData7 = new PushButtonData("button7", "Tool 7", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command07");
            PushButtonData pData8 = new PushButtonData("button8", "Tool 8", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command08");
            PushButtonData pData9 = new PushButtonData("button9", "Tool 9", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command09");
            PushButtonData pData10 = new PushButtonData("button10", "Tool 10", GetAssemblyName(), "RevitAddinAcademy_Challenge_06.Command10");

            SplitButtonData sData1 = new SplitButtonData("splitButton1", "Split Button");
            PulldownButtonData pdData1 = new PulldownButtonData("pulldownDutton", "More Tools");
            


            // step 4: add images

            sData1.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Red_16);
            sData1.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Red_32);

            pdData1.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Green_16);
            pdData1.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Green_32);

            pData1.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData1.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData2.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData2.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData3.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData3.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData4.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData4.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData5.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData5.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData6.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData6.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData7.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData7.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData7.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData7.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData8.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData8.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData9.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData9.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            pData10.Image = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_16);
            pData10.LargeImage = BitmapToImageSource(RevitAddinAcademy_Challenge_06.Properties.Resources.Blue_32);

            // step 5:  add tooltip info

            pData1.ToolTip = "Command tool tip fro Tool 1";
            pData2.ToolTip = "Command tool tip fro Tool 2";
            pData3.ToolTip = "Command tool tip fro Tool 3";
            pData4.ToolTip = "Command tool tip fro Tool 4";
            pData5.ToolTip = "Command tool tip fro Tool 5";
            pData6.ToolTip = "Command tool tip fro Tool 6";
            pData7.ToolTip = "Command tool tip fro Tool 7";
            pData8.ToolTip = "Command tool tip fro Tool 8";
            pData9.ToolTip = "Command tool tip fro Tool 9";
            pData10.ToolTip = "Command tool tip fro Tool 10";

            
            
            // step 6: crate buttons
            PushButton b1 = curPanel.AddItem(pData1) as PushButton;
            PushButton b2 = curPanel.AddItem(pData2) as PushButton;

            curPanel.AddSeparator();

            curPanel.AddStackedItems(pData3,pData4,pData5);


            curPanel.AddSeparator();

            SplitButton splitButton = curPanel.AddItem(sData1) as SplitButton;
            splitButton.AddPushButton(pData6);
            splitButton.AddPushButton(pData7);

            curPanel.AddSeparator();

            PulldownButton pulldownButton = curPanel.AddItem(pdData1) as PulldownButton;
            pulldownButton.AddPushButton(pData8);
            pulldownButton.AddPushButton(pData9);
            pulldownButton.AddPushButton(pData10);

            curPanel.AddSeparator();

            return Result.Succeeded;
        }

        private RibbonPanel CreateRibbonPanel(UIControlledApplication a, string tabName, string panelName)
        {
            foreach (RibbonPanel tmpPanel in a.GetRibbonPanels(tabName))
            {
                if (tmpPanel.Name == panelName)
                    return tmpPanel;
            }

            RibbonPanel returnPanel = a.CreateRibbonPanel(tabName, panelName);

            return returnPanel;

        }

        private string GetAssemblyName()
        {
            return Assembly.GetExecutingAssembly().Location;
        }

        private BitmapImage BitmapToImageSource(System.Drawing.Bitmap bm)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                bm.Save(mem, System.Drawing.Imaging.ImageFormat.Png);
                mem.Position = 0;
                BitmapImage bmi = new BitmapImage();
                bmi.BeginInit();
                bmi.StreamSource = mem;
                bmi.CacheOption = BitmapCacheOption.OnLoad;
                bmi.EndInit();

                return bmi;
            }
        }

        

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
