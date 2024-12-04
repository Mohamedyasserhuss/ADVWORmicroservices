using System;

namespace AdventureWorksAPI
{
    // WeatherForecast model representing weather data
    public class WeatherForecast
    {
        // Primary key for the WeatherForecast entity
        public int Id { get; set; }

        // Date when the forecast was made
        public DateTime Date { get; set; }

        // Temperature in Celsius
        public int TemperatureC { get; set; }

        // Summary of the weather (e.g., "Sunny", "Cloudy")
        public string? Summary { get; set; }

        // Property to calculate Temperature in Fahrenheit
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
