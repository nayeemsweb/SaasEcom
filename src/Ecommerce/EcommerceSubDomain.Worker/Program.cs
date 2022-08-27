using Autofac;
using Autofac.Extensions.DependencyInjection;
using Ecommerce.Store;
using Ecommerce.Store.DbContexts;
using EcommerceSubDomain.Worker;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false)
                    .AddEnvironmentVariables().Build();

var connectionString = configuration.GetConnectionString("DefaultConnection");
var migrationAssemblyName = typeof(Worker).Assembly.FullName;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();

try
{
    Log.Information("SubDomain Application is starting up");

    IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService()
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .UseSerilog()
    .ConfigureContainer<ContainerBuilder>(builder => {
        builder.RegisterModule(new WorkerModule());
        builder.RegisterModule(new StoreModule(connectionString, migrationAssemblyName));
    })
    .ConfigureServices(services =>
    {
        services.AddDbContext<StoreDbContext>(options =>
            options.UseSqlServer(connectionString, m => m.MigrationsAssembly(migrationAssemblyName)));
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddHostedService<Worker>();
    })
    .Build();

    await host.RunAsync();
}catch(Exception ex)
{
    Log.Fatal(ex, " SubDomain Application startup failed");
}
finally
{
    Log.CloseAndFlush();
}

