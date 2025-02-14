using Microsoft.Extensions.Compliance.Testing;

namespace WebApplication1
{
    public class WeatherForecast
    {
        [PrivateData]
        public DateOnly Date { get; set; }
 
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}


