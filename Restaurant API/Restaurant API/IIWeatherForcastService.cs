using System.Collections.Generic;

namespace Restaurant_API
{
    public interface IIWeatherForcastService
    {
        IEnumerable<WeatherForecast> Get(int count, int minTemperature, int maxTemperature );
    }
}