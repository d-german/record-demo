using System.Collections.Immutable;

namespace RecordDemo;

public record ImmutableGangster
{
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }

    public ImmutableList<string>? NickNames { get; init; }
}
