using MouseOnPumping.Core.Requests;
using MouseOnPumping.Core.Models;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace MouseOnPumping.Core
{
    public class MouseClient(HttpClient httpClient, ILogger<MouseClient> logger)
    {
        private readonly HttpClient _http = httpClient;
        private readonly ILogger<MouseClient> _logger = logger;
        private AuthorizationData? _authorizationData = null;

        public bool IsAuthorized => _authorizationData != null;

        public async Task AuthorizeAsync(string email, string password)
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
            _authorizationData = JsonSerializer.Deserialize<AuthorizationData>(jsonResponse);
            _http.DefaultRequestHeaders.Add("Authorization", "Gay " + _authorizationData?.Token??"");
        }

        public async Task<List<AvailableСourse>> GetCoursesAsync() 
        {
            HttpResponseMessage response = await _http.GetAsync("api/courses");
            var jsonResponse = await response.Content.ReadAsStringAsync();
            _logger.LogWarning(jsonResponse);

            var result = JsonSerializer.Deserialize<List<AvailableСourse>>(jsonResponse);
            return result ?? new List<AvailableСourse>();
        }
    }
}
