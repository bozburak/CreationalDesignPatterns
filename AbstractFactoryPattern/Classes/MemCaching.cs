using AbstractFactoryPattern.Abstracts;
using System;

namespace AbstractFactoryPattern.Classes
{
    class MemCaching : Caching
    {
        public override void Cache()
        {
            Console.WriteLine("MemCache");
        }
    }
}
