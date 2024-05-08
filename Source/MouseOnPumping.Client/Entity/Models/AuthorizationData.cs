using System.Text.Json.Serialization;

namespace MouseOnPumping.Domain.Models;

[JsonSerializable(typeof(AuthorizationData))]
public class AuthorizationData
{
    [JsonPropertyName("token")]
    public required string Token { get; init; }
}
