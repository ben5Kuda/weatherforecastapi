using Microsoft.Extensions.Logging;
using NSubstitute;
using WebApplication1.Controllers;

namespace UnitTests;

public class UnitTest1
{
    private WeatherForecastController _weatherForecastController;
    private ILogger<WeatherForecastController> _logger = Substitute.For<ILogger<WeatherForecastController>>();

    public UnitTest1()
    {
        _weatherForecastController = new WeatherForecastController(_logger);
    }
    [Fact]
    public void Test_ShouldPass()
    {
        var data = _weatherForecastController.Get();
        
        Assert.Equal(5, data.Count());
        Assert.Equal(10, 10);
    }
    
    [Fact]
    public void Test_ShouldFail()
    {
        Assert.NotEqual(10, 12);
    }
}