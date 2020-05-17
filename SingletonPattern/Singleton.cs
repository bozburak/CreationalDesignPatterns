using System.Linq.Expressions;

namespace SingletonPattern
{
    internal class Singleton
    {
        private static Singleton _instance = null;

        private Singleton() => Expression.Empty();

        internal static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
