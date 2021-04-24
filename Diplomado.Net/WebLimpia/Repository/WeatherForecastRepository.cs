using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLimpia.Repository
{
    public class WeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
       {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string[] getSummaries()
        {
            return Summaries;
        }
    }
}
