using System.Linq.Expressions;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance = null;

        private Singleton() => Expression.Empty();

        public static Singleton Instance
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
