namespace RecordDemo;

public record Gangster
{
    int Id { get; init; }
    private string? FirstName { get; init; } = "Al";
    private string? LastName { get; init; } = "Capone";

    List<string>? NickNames { get; init; } = new()
    {
        "Scarface",
        "Big Al",
        "The Big Fellow",
        "Snorky",
        "King Alphonse"
    };
}