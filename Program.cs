using Ilse.Bus.Connection;
using Ilse.Bus.DependencyInjection;
using Ilse.Bus.Subscriber;
using Ilse.InboxConsumer.Consumer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", true, true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddScoped<IConnectionProvider, RabbitConnectionProvider>();
builder.Services.AddScoped<IBusSubscriber, RabbitSubscriber>();
builder.Services.AddConsumers();

var host = builder.Build();

var loggerFactory = LoggerFactory.Create(b => b.AddConsole());
var logger = loggerFactory.CreateLogger(nameof(Program));
logger.LogInformation("Starting consumer");

host.Services.UseConsumer<BrandAddConsumer>();
host.Services.UseConsumer<BrandAdd2Consumer>();
host.Services.UseConsumer<BrandDeleteConsumer>();

Console.ReadLine();
