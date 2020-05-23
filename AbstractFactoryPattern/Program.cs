using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.Classes;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Caching cemCaching = new MemCaching();
            cemCaching.Cache();
            Caching redisCaching = new RedisCaching();
            redisCaching.Cache();
            Console.ReadKey();
        }
    }
}
