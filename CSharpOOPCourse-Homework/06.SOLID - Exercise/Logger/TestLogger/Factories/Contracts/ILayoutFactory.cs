using LogForMe.ConsoleApp.Layouts.Contracts;

namespace TestLogger.Factories.Contracts
{
    public interface ILayoutFactory
    {
        ILayout CreateLayoutInstance(string layoutType);
    }
}
