namespace RecordDemo;

public record Gangster
{
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public List<string>? NickNames { get; init; }
}
