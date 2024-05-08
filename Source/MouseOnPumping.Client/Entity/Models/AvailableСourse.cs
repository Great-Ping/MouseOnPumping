using System.Text.Json.Serialization;

namespace MouseOnPumping.Domain.Models;

public class AvailableСourse(int id, string name, string? description, int hours)
{
    [JsonPropertyName("id")]
    public int Id { get; init; } = id;
    [JsonPropertyName("name")]
    public string Name { get; init; } = name;
    [JsonPropertyName("description")]
    public string? Description { get; init; } = description;
    [JsonPropertyName("complete_time")]
    public int Hours { get; init; } = hours;
}
