namespace RecordDemo;

public record WeatherDataRecord
{
    public int Temperature { get; init; }
    public int Humidity { get; init; }
    public int Pressure { get; init; }
}
