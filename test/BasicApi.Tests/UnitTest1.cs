using BasicApi.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace BasicApi.Tests
{
    public class Tests
    {
        WeatherForecastController weatherForecastController;
        Mock<ILogger<WeatherForecastController>> loggerMock = new Mock<ILogger<WeatherForecastController>>();
        [SetUp]
        public void Setup()
        {
            weatherForecastController = new WeatherForecastController(loggerMock.Object);
        }

        [Test]
        public void Test1()
        {
            var results = weatherForecastController.Get();

            Assert.That(results.Count, Is.EqualTo(11));
        }
    }
}