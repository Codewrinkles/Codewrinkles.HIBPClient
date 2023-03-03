using Microsoft.Extensions.Logging;

namespace Codewrinkles.HIBP.Client.Logging;

public class HibpClientLoggerProvider : ILoggerProvider
{
 
    public HibpClientLoggerProvider()
    {
        
    }
    
    public ILogger CreateLogger(string categoryName)
    {
        return new HibpClientLogger(categoryName);
    }

    public void Dispose()
    {
        // implement any cleanup logic here
    }
}