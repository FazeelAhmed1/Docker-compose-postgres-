using DockerTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        public string StudentName { get; private set; } = "PageModel in C#";
        private readonly SchoolContext _context;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, SchoolContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            var s = _context.Students?.Where(d => d.ID == 1).FirstOrDefault();
            this.StudentName = $"{s?.FirstMidName} {s?.LastName}";
            return StudentName;
        }
    }
}