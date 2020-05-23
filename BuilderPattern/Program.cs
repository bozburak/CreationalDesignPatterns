using BuilderPattern.Abstracts;
using BuilderPattern.Model;
using BuilderPattern.Models;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BrowserDirector browserDirector = new BrowserDirector();
            var chromeModel = browserDirector.GenerateBrowser(new Chrome());
            Console.WriteLine(chromeModel.Name + " - " + chromeModel.Version);
            var firefoxModel = browserDirector.GenerateBrowser(new Firefox());
            Console.WriteLine(firefoxModel.Name + " - " + firefoxModel.Version);
            Console.ReadKey();
        }
    }

    class BrowserDirector
    {
        public BrowserModel GenerateBrowser(BrowserBuilder browserBuilder)
        {
            browserBuilder.GetBrowserName();
            browserBuilder.GetBrowserVersion();
            var resultModel = browserBuilder.Build();
            return resultModel;
        }
    }
}
