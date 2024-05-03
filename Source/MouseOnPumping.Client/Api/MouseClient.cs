using MouseOnPumping.Core.Requests;
using MouseOnPumping.Core.Models;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components;

namespace MouseOnPumping.Core
{
    public class MouseClient(HttpClient httpClient, ILogger<MouseClient> logger)
    {
        private readonly HttpClient _http = httpClient;
        private readonly ILogger<MouseClient> _logger = logger;

        public async Task<AuthorizationData?> AuthorizationRequest(string email, string password)
        {
            AuthorizationRequest request = new(email, password);

            StringContent content = new(JsonSerializer.Serialize(request),
                Encoding.UTF8, "application/json");

            String route = "api/login";
            _logger.LogWarning(route);
            _logger.LogWarning(email);
            _logger.LogWarning(password);
            HttpResponseMessage response =  await _http.PostAsync(route, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();
            _logger.LogWarning(jsonResponse);

            AuthorizationData? data = JsonSerializer.Deserialize<AuthorizationData>(jsonResponse);

            return data;
        }
    }
}
