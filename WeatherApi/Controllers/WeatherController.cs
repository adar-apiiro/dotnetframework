using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet]
    public IActionResult GetWeather()
    {
        var weatherData = new[]
        {
            new { Date = DateTime.Now, TemperatureC = 25, Summary = "Sunny" },
            new { Date = DateTime.Now.AddDays(1), TemperatureC = 22, Summary = "Cloudy" }
        };
        return Ok(weatherData);
    }

    [HttpGet("{id}")]
    public IActionResult GetWeatherById(int id)
    {
        if (id == 1)
        {
            return Ok(new { Date = DateTime.Now, TemperatureC = 25, Summary = "Sunny" });
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost]
    public IActionResult CreateWeather([FromBody] dynamic weather)
    {
        return CreatedAtAction(nameof(GetWeatherById), new { id = 1 }, weather);
    }
}
