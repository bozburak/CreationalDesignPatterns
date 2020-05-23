using BuilderPattern.Model;

namespace BuilderPattern.Abstracts
{
    abstract class BrowserBuilder
    {
        public abstract void GetBrowserName();
        public abstract void GetBrowserVersion();
        public abstract BrowserModel Build();
    }
}
