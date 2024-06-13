using Frame_Manager.Data;
using Frame_Manager.Model.Entity;
using Frame_Manager.Repository;
using Frame_Manager.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frame_Manager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly CounterService counterService;
     
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(CounterService counterService, ILogger<WeatherForecastController> logger)
        {
            this.counterService = counterService;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<List<Frame>> Get()
        {

            return await counterService.counterFrame();
            

        }
    }
}
