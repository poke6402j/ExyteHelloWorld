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
            RibbonPanel panel01 = application.CreateRibbonPanel("Exyte No.1"); //設定功能面板

            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location; //取得主程式(.dll)路徑
            string NamespaceName01 = "ExyteAddins"; //命名空間名稱
            string ClassName01 = "HelloWorld"; //外部命令類別名稱

            //設定按鈕
            PushButtonData b01Data = new PushButtonData(
                "Exyte_Button_One",
                "Exyte\nButton One",
                thisAssemblyPath,   
                NamespaceName01 + "." + ClassName01);

            //綁定按鈕
            PushButton button01 = panel01.AddItem(b01Data) as PushButton;

            //按鈕縮圖
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
