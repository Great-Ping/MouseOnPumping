using System.Text.Json.Serialization;

namespace MouseOnPumping.Domain.Models;

public class CourseChapter(int id, string name, string description)
{
    [JsonPropertyName("id")]
    public int Id { get; init; } = id;
    [JsonPropertyName("name")]
    public string Name { get; init; } = name;
    [JsonPropertyName("description")]
    public string Description { get; init; } = description;

    public override string ToString()
    {
        return Name;
    }
}
