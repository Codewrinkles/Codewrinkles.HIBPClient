using Microsoft.Extensions.Logging;
using Codewrinkles.HIBP.Client.Logging;

var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddProvider(new HibpClientLoggerProvider());
});

var logger = loggerFactory.CreateLogger("MyCategory");

logger.LogInformation("Log Information Sample");
logger.LogError("Log Error Sample");

Console.ReadKey();