using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Autodesk.Revit.Attributes; //載入RevitAPI內容
using Autodesk.Revit.DB; //載入RevitAPI內容
using Autodesk.Revit.UI; //載入RevitAPI內容

using ExyteAddins;

namespace ExyteAddins.ExyteButton1
{
    internal class ExyteButtonOne : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            RibbonPanel panel01 = application.CreateRibbonPanel("Exyte No.1");

            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string NamespaceName01 = "ExyteAddins";
            string ClassName01 = "HelloWorld";

            PushButtonData b01Data = new PushButtonData(
                "Exyte_Button_One",
                "Exyte\nButton One",
                thisAssemblyPath,   
                NamespaceName01 + "." + ClassName01);

            PushButton button01 = panel01.AddItem(b01Data) as PushButton;

            BitmapImage buttonImage01 = new BitmapImage(
                new Uri("pack://application:,,,/ExyteAddins;component/pic/Exyte_LOGO.png"));

            button01.LargeImage = buttonImage01;

            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

    }
}
