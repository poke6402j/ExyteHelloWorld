using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace ExyteAddins
{
    [Transaction(TransactionMode.Manual)]
    public class HelloWorld : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            string whoIAm = "ExyteBIM";

            string wordToSay = "Hello World";

            TaskDialog.Show(whoIAm, wordToSay);

            return Result.Succeeded;
        }
    }
}
