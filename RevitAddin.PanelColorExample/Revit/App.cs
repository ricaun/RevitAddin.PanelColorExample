using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ricaun.Revit.UI;
using System;

namespace RevitAddin.PanelColorExample.Revit
{
    [Console]
    public class App : IExternalApplication
    {
        static RibbonPanel ribbonPanel;
        public Result OnStartup(UIControlledApplication application)
        {
            ribbonPanel = application.CreatePanel("Color");
            ribbonPanel.AddPushButton<Commands.Command>()
                .SetLargeImage(@"https://img.icons8.com/small/32/0000ff/menu.png".GetBitmapSource());

            ribbonPanel.GetRibbonPanel().CustomPanelTitleBarBackground = System.Windows.Media.Brushes.Red;

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            ribbonPanel.Remove();
            return Result.Succeeded;
        }
    }
}