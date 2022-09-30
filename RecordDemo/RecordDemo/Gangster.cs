using System.Collections.Immutable;

namespace RecordDemo;

public record Gangster
{
    int Id { get; init; }
    private string? FirstName { get; init; } = "Al";
    private string? LastName { get; init; } = "Capone";

    ImmutableList<string>? NickNames { get; init; } = ImmutableList.Create(
        "Scarface",
        "Big Al",
        "The Big Fellow",
        "Snorky",
        "King Alphonse");
}
