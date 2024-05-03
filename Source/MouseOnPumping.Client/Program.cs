using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MouseOnPumping.Core;
using MouseOnPumping.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services
    .AddSingleton<HttpClient>(services => new HttpClient() {
        BaseAddress= new Uri("http://192.168.0.241:5000")
    })
    .AddSingleton<MouseClient>()
    .AddSingleton<AuthorizationService>();

await builder.Build().RunAsync();
