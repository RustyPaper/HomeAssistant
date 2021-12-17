using Blazored.LocalStorage;
using HomeAssistant_Client.Service;
using HomeAssistant_Client.Service.IService;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssistant_Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress =
                        new Uri(builder.Configuration.GetValue<string>("BaseAPIUrl"))});
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<IHomeApService, HomeApService>();
            builder.Services.AddScoped<IHomeAmenityService, HomeAmenityService>();
            builder.Services.AddScoped<IApartamentOrderDetailsService, ApartamentOrderDetailsService>();
            builder.Services.AddScoped<IStripePaymentService, StripePaymentService>();
            await builder.Build().RunAsync();
        }
    }
}
