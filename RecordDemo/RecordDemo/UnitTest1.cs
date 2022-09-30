using NuGet.Frameworks;

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

        Assert.That(weatherData1, Is.Not.EqualTo(weatherData2)); // EqualTo tests two items for equality
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
        var foo1 = new Foo1 { Bar1 = 1 };
        var foo2 = new Foo1 { Bar1 = 1 };

        Assert.That(foo1, Is.EqualTo(foo2));
        Assert.That(foo1.GetHashCode(), Is.EqualTo(foo2.GetHashCode()));
        Assert.That(foo1.ToString(), Is.EqualTo("Foo1 { Bar1 = 1 }"));
        Assert.That(foo2.ToString(), Is.EqualTo("Foo1 { Bar1 = 1 }"));
    }

    [Test]
    public void CopyWithTest()
    {
        var weatherDataRecord1 = new WeatherDataRecord
        {
            Temperature = 100,
            Humidity = 50,
            Pressure = 30
        };

        var weatherDataRecord2 = weatherDataRecord1;

        Assert.That(weatherDataRecord1, Is.SameAs(weatherDataRecord2)); // SameAs tests that two references are the same object
        Assert.That(weatherDataRecord2.ToString(), Is.EqualTo("WeatherDataRecord { Temperature = 100, Humidity = 50, Pressure = 30 }"));

        var weatherDataRecord3 = weatherDataRecord1 with { };
        Assert.That(weatherDataRecord1, Is.EqualTo(weatherDataRecord3));
        Assert.That(weatherDataRecord1, Is.Not.SameAs(weatherDataRecord3));

        var weatherDataRecord4 = weatherDataRecord1 with { Temperature = 120 };
        Assert.That(weatherDataRecord4.ToString(), Is.EqualTo("WeatherDataRecord { Temperature = 120, Humidity = 50, Pressure = 30 }"));
    }

    [Test]
    public void GangsterTest()
    {
        var g1 = new Gangster();
        var g2 = new Gangster();

        Assert.That(g1, Is.Not.EqualTo(g2));
        Assert.That(g1.GetHashCode(), Is.Not.EqualTo(g2.GetHashCode()));
        Assert.That(g1.ToString(), Is.EqualTo("Gangster { }"));
        Assert.That(g2.ToString(), Is.EqualTo("Gangster { }"));

        var g3 = g1 with { };
        
        Assert.That(g3.ToString(), Is.EqualTo("Gangster { }"));

        Assert.That(g1, Is.EqualTo(g3));
        Assert.That(g1, Is.Not.SameAs(g2));
        Assert.That(g1.GetHashCode(), Is.EqualTo(g3.GetHashCode()));
    }
}
