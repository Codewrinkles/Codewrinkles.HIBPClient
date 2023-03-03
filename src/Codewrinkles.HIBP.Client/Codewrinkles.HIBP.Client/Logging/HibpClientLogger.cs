using Microsoft.Extensions.Logging;

namespace Codewrinkles.HIBP.Client.Logging;

public class HibpClientLogger : ILogger
{
    private readonly string _categoryName;

    public HibpClientLogger(string categoryName)
    {
        _categoryName = categoryName;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        Console.WriteLine($"[{DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")}] [{logLevel}] [{_categoryName}] {formatter(state, exception)}");
    }
}