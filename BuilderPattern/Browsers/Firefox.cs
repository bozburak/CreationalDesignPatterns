using BuilderPattern.Abstracts;
using System;

namespace BuilderPattern.Models
{
    class Firefox : BrowserBuilder
    {
        public override void GetBrowserName()
        {
            Console.WriteLine("Firefox");
        }

        public override void GetBrowserVersion()
        {
            Console.WriteLine("2.0");
        }
    }
}