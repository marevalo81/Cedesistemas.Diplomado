using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebLimpia.Business;
using WebLimpia.Models;

namespace WebLimpia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILoggerManager logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            try
            {
                logger.LogDebug("Empezo a ejecutar el llamado");
                IEnumerable<WeatherForecast> weathers = new WeatherForecastBusiness().GetWeatherForecasts();
                return Ok(weathers);
            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
                return BadRequest(new ErrorDto() { code="999", message=e.Message });
            }
            
        }

        [HttpGet("{id}")]
        public ActionResult<WeatherForecast> Get(int id)
        {
                logger.LogDebug("Empezo a ejecutar el llamado");
                return Ok(new WeatherForecastBusiness().GetWeatherForecasts(id));
           

        }
    }
}
