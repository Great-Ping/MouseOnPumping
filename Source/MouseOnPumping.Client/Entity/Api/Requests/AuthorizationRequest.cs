using System.Text.Json.Serialization;

namespace MouseOnPumping.Domain.Api.Requests;

public class AuthorizationRequest(string email, string password)
{
    [JsonPropertyName("mail")]
    public string Email { get; set; } = email;
    [JsonPropertyName("password")]
    public string Password { get; set; } = password;
}
