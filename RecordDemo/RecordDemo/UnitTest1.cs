namespace RecordDemo;

public class Tests
{
    [Test]
    public void ClassToStringTest()
    {
        var weatherData = new WeatherDataClass
        {
            Temperature = 100,
            Humidity = 50,
            Pressure = 30
        };

        Assert.That(weatherData.ToString(), Is.EqualTo("RecordDemo.WeatherDataClass"));
    }

    [Test]
    public void RecordToStringTest()
    {
        var weatherData = new WeatherDataRecord
        {
            Temperature = 100,
            Humidity = 50,
            Pressure = 30
        };

        Assert.That(weatherData.ToString(), Is.EqualTo("WeatherDataRecord { Temperature = 100, Humidity = 50, Pressure = 30 }"));
    }

    [Test]
    public void ClassEqualityCheckTest()
    {
        var weatherData1 = new WeatherDataClass
        {
            Temperature = 100,
            Humidity = 50,
            Pressure = 30
        };

        var weatherData2 = new WeatherDataClass
        {
            Temperature = 100,
            Humidity = 50,
            Pressure = 30
        };

        Assert.That(weatherData1, Is.Not.EqualTo(weatherData2));
        Assert.Multiple(() =>
        {
            Assert.That(weatherData1.Temperature, Is.EqualTo(weatherData2.Temperature));
            Assert.That(weatherData1.Humidity, Is.EqualTo(weatherData2.Humidity));
            Assert.That(weatherData1.Pressure, Is.EqualTo(weatherData2.Pressure));
        });
    }

    [Test]
    public void RecordEqualityCheckTest()
    {
        var weatherData1 = new WeatherDataRecord()
        {
            Temperature = 100,
            Humidity = 50,
            Pressure = 30
        };

        var weatherData2 = new WeatherDataRecord()
        {
            Temperature = 100,
            Humidity = 50,
            Pressure = 30
        };

        Assert.That(weatherData1, Is.EqualTo(weatherData2));
    }

    [Test]
    public void Foo1EqualityChecks()
    {
        
    }
}
