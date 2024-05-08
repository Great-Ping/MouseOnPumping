using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MouseOnPumping.Domain.Api;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services
    .AddSingleton<HttpClient>(services => new HttpClient()
    {
        BaseAddress = new Uri("http://192.168.240.161:5000")
    })
    .AddSingleton<MouseClient>();

await builder.Build().RunAsync();
