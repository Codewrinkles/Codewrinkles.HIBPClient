using Codewrinkles.HIBP.Client.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders().AddProvider(new HibpClientLoggerProvider());

builder.Services.AddTransient<Worker>();

var app = builder.Build();

app.RunWorker();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public static class WorkerRunner
{
    public static void RunWorker(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var worker = scope.ServiceProvider.GetRequiredService<Worker>();
        worker.DoWork();
    }
}


public class Worker
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    public void DoWork()
    {
        _logger.LogInformation("Starting work...");
        // Do some logic work here
        _logger.LogInformation("Work complete.");
    }
}