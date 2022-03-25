using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RevitAPITraining_Ribbon
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Моя вкладка";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\ProgramFiles\RevitAPITrainig\";

            var panel1 = application.CreateRibbonPanel(tabName, "Моделирование");

            var button = new PushButtonData("Стены", "Количество и объем",
                Path.Combine(utilsFolderPath, "RevitAPITrainingUI_5_2.dll"),
                "RevitAPITrainingUI_5_2.Main");

            Uri uriImage = new Uri(@"C:\Program Files\RevitAPITrainig\Images\2.png", UriKind.Absolute);
            BitmapImage largeImage = new BitmapImage(uriImage);
            button.LargeImage = largeImage;

            panel1.AddItem(button);

            var button2 = new PushButtonData("Создание кнопок", "Создание кнопок",
                         Path.Combine(utilsFolderPath, "RevitAPITrainingUI_.dll"),
                         "RevitAPITrainingUI_.Main");

            Uri uriImage2 = new Uri(@"C:\Program Files\RevitAPITrainig\Images\1.png", UriKind.Absolute);
            BitmapImage largeImage2 = new BitmapImage(uriImage);
            button2.LargeImage = largeImage2;


            panel1.AddItem(button2);

            

           
            return Result.Succeeded;
        }

    }

}

