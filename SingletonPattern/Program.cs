using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;
            if (object.ReferenceEquals(singleton1, singleton2))
            {
                Console.WriteLine("Work");
            }
            else
            {
                Console.WriteLine("Broke");
            }

            Console.ReadLine();
        }
    }
}
