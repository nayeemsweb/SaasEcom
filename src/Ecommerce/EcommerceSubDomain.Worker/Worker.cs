using Autofac;
using AutoMapper;
using EcommerceSubDomain.Worker.HostFiles;

namespace EcommerceSubDomain.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ILifetimeScope _scope;
        private readonly IMapper _mapper;

       // public static bool triggerHostService=false;

        public Worker(ILogger<Worker> logger, ILifetimeScope scope, IMapper mapper)
        {
            _logger = logger;
            _scope = scope;
            _mapper = mapper;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    //if (triggerHostService)
                    //{
                    var host = _scope.Resolve<HostFile>();
                    host.Resolve(_scope);
                    //host.View();
                    host.AddSubDomain();
                    host.AddUrl();
                    //host.FromDB();
                    //triggerHostService = false;
                    //}
                    //Console.WriteLine(triggerHostService);
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                catch(Exception e)
                {
                    _logger.LogError(e.Message);
                }
                await Task.Delay(500, stoppingToken);
            }
        }
    }
}