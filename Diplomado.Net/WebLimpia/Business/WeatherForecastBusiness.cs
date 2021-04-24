using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLimpia.Repository;

namespace WebLimpia.Business
{
    public class WeatherForecastBusiness
    {
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            string[] Summaries = new WeatherForecastRepository().getSummaries();
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
                .ToArray();
        }

        public WeatherForecast GetWeatherForecasts(int id)
        {
            string[] Summaries = new WeatherForecastRepository().getSummaries();
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[id-1]
            })
                .First();
        }
    }
}
