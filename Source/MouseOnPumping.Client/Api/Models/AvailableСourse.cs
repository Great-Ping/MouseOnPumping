namespace MouseOnPumping.Core.Models
{
    public class AvailableСourse
    {
        public required int Id { get; init; }
        public required string Name { get; init; }
        public required string Description { get; init; }
        public required string Url { get; init; }
        public required float Hours { get; init; }
    }
}
