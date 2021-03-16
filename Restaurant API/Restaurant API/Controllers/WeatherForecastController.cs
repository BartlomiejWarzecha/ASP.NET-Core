﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IIWeatherForcastService _service;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IIWeatherForcastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]

        public IEnumerable<WeatherForecast> GET()
        {

            var result = _service.Get();
            return result;

        }

    }
}