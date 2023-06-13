using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
namespace SimpleAPI.test
{
    public class UnitTest1
    {
         Mock<ILogger<WeatherForecastController>> mockLogger = new Mock<ILogger<WeatherForecastController>>();
         [Fact]
         public void GetReturnsMyName()
         {
             WeatherForecastController controller = new WeatherForecastController(mockLogger.Object);
             var returnValue = controller.Get();
             Assert.Equal("Isabel Prempeh", returnValue);
        }

    }
}
