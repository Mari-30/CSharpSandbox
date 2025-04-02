namespace MyFirstApp;

internal static class ConsoleExtensions
{
    public static string ReadLine()
    {
        return Console.ReadLine() ?? string.Empty;
    }
}
