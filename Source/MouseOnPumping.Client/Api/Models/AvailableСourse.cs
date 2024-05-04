using System.Diagnostics.CodeAnalysis;

namespace MouseOnPumping.Core.Models
{
    
    public class AvailableСourse(int id, string name, string descriprion, float hours)
    {

        public int Id { get; init; } = id;
        public string Name { get; init; } = name;
        public string Description { get; init; } = descriprion;
        public float Hours { get; init; } = hours;
    }
}
