using System.Runtime.Versioning;
using Avalonia;
using Consolonia;

namespace Pororoca.Console;
public static class Program
{
    private static void Main(string[] args)
    {
        BuildAvaloniaApp()
            .StartWithConsoleLifetime(args);
    }

    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure<App>()
            .UseConsolonia()
            .UseAutoDetectedConsole()
            .LogToException();
    }
}