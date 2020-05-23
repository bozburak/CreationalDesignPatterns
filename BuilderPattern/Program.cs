using BuilderPattern.Abstracts;
using BuilderPattern.Models;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BrowserDirector browserDirector = new BrowserDirector();
            var builderChrome = new Chrome();
            browserDirector.GenerateBrowser(builderChrome);
            var builderFirefox = new Firefox();
            browserDirector.GenerateBrowser(builderFirefox);
            Console.ReadKey();
        }
    }

    class BrowserDirector
    {
        public void GenerateBrowser(BrowserBuilder browserBuilder)
        {
            browserBuilder.GetBrowserName();
            browserBuilder.GetBrowserVersion();
        }
    }
}
