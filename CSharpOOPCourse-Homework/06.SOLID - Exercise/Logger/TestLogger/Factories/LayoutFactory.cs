using LogForMe.ConsoleApp.Layouts;
using LogForMe.ConsoleApp.Layouts.Contracts;
using TestLogger.Factories.Contracts;
using TestLogger.Layouts;

namespace TestLogger.Factories
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayoutInstance(string layoutType)
        {
            switch (layoutType)
            {
                case "SimpleLayout":
                    return new SimpleLayout();
                case "XmlLayout":
                    return new XmlLayout();
                default:
                    throw new InvalidOperationException("No such a type exists");
            }
        }
    }
}