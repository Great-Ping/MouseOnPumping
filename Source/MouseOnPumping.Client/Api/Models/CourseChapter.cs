using System.Text.Json.Serialization;

namespace MouseOnPumping.Client.Api.Models
{
    [JsonSerializable(typeof(CourseChapter))]
    public class CourseChapter(int id, string name, string description)
    {
        [JsonPropertyName("id")]
        public int Id { get; init; } = id;
        [JsonPropertyName("name")]
        public string Name { get; init; } = name;
        [JsonPropertyName("description")]
        public string Description { get; init; } = description;
    }
}
