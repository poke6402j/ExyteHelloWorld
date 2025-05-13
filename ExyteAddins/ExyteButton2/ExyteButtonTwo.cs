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

namespace ExyteAddins.ExyteButton2
{
    internal class ExyteButtonTwo : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            string TabName = "Exyte Addins";
            application.CreateRibbonTab(TabName);

            RibbonPanel panel02 = application.CreateRibbonPanel(TabName, "Exyte No.2"); //設定功能面板

            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location; //取得主程式(.dll)路徑
            string NamespaceName02 = "ExyteAddins"; //命名空間名稱
            string ClassName02 = "HelloWorld"; //外部命令類別名稱

            //設定按鈕
            PushButtonData b02Data = new PushButtonData(
                "Exyte_Button_Two",
                "Exyte\nButton Two",
                thisAssemblyPath,
                NamespaceName02 + "." + ClassName02);

            //綁定按鈕
            PushButton button02 = panel02.AddItem(b02Data) as PushButton;

            //按鈕縮圖
            BitmapImage buttonImage02 = new BitmapImage(
                new Uri("pack://application:,,,/ExyteAddins;component/pic/Exyte_LOGO.png"));

            button02.LargeImage = buttonImage02;

            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

    }
}
