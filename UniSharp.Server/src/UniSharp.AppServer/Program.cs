using System;
using System.Threading.Tasks;
using MagicOnion.Hosting;
using MagicOnion.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace UniSharp.AppServer
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            // Main gRPC Host
            var magicOnionHost = MagicOnionHost.CreateDefaultBuilder()
                .UseMagicOnion()
                .ConfigureServices((context, collection) =>
                {
                    // afe
                })
                .Build();

            var swaggerWeb = new WebHostBuilder()
                .ConfigureServices(collection =>
                {
                    // Add MagicOnionServiceDefinition for reference from Startup.
                    collection.AddSingleton(magicOnionHost.Services.GetService<MagicOnionHostedServiceDefinition>()
                        .ServiceDefinition);
                })
                .UseKestrel()
                .Build();

            await Task.WhenAll(magicOnionHost.RunAsync(), swaggerWeb.RunAsync());
        }
    }
}