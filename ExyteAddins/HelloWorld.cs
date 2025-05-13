using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.Attributes; //載入RevitAPI內容
using Autodesk.Revit.DB; //載入RevitAPI內容
using Autodesk.Revit.UI; //載入RevitAPI內容

namespace ExyteAddins //命名空間
{
    [Transaction(TransactionMode.Manual)] //設定transaction mode
    public class HelloWorld : IExternalCommand //執行Revit Add-In進入點
    {
        //Revit Add-In 主執行方法
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            string whoIAm = "ExyteBIM"; //視窗Title

            string wordToSay = "Hello BUD"; //訊息內容

            TaskDialog.Show(whoIAm, wordToSay); //呼叫TaskDialog對話框

            return Result.Succeeded; //回傳值: 執行成功
        }
    }
}
