using System;

namespace MyFirstApi.Models;

public class WeatherForecast
{
  public DateOnly Date { get; set; }
  public int TemperatureC { get; set; }
  public string? Summary { get; set; }
  public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

  public WeatherForecast(DateOnly date, int temperatureC, string summary)
  {
    Date = date;
    TemperatureC = temperatureC;
    Summary = summary;
  }
}
