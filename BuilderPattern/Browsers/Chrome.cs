using BuilderPattern.Abstracts;
using System;

namespace BuilderPattern.Models
{
    class Chrome : BrowserBuilder
    {
        public override void GetBrowserName()
        {
            Console.WriteLine("Chrome");
        }

        public override void GetBrowserVersion()
        {
            Console.WriteLine("1.0");
        }
    }
}