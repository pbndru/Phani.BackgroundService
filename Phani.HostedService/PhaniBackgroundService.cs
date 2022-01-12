using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Phani.HostedService
{
    public class PhaniBackgroundService: BackgroundService
    {
        protected async override Task ExecuteAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine($"{ DateTime.Now.ToString() } - Phani Background Service");
                await Task.Delay(5000, token);
            }
        }
    }
}
