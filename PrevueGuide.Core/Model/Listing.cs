using System.Diagnostics.CodeAnalysis;

namespace PrevueGuide.Core.Model;

[ExcludeFromCodeCoverage]
public record Listing
{
    public string ChannelId { get; init; }
    public string Title { get; init; }
    public int Block { get; init; }
    public string Category { get; init; }
    public string Description { get; init; }
    public string Year { get; init; }
    public string Rating { get; init; }
    public string Subtitled { get; init; }
    public DateTime StartTime { get; init; }
    public DateTime EndTime { get; init; }
}
