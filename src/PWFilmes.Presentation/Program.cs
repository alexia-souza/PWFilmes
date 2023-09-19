using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Presentation
{
    public class Program
    {
        //Teste
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.
                AddScoped(sp => new HttpClient
                { BaseAddress = new Uri("https://localhost:44373") });

            await builder.Build().RunAsync();
        }
    }
}
