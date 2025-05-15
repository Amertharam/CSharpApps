namespace SimplePluginFramework
{
    public interface IPlugin
    {
        void Execute();
        string Name { get; }
    }
}