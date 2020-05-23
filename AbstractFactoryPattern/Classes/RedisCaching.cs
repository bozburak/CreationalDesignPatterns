using AbstractFactoryPattern.Abstracts;
using System;

namespace AbstractFactoryPattern.Classes
{
    class RedisCaching : Caching
    {
        public override void Cache()
        {
            Console.WriteLine("RedisCache");
        }
    }
}
