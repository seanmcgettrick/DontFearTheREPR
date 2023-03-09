namespace DontFearTheREPR.WeatherService.Data;

public record WeatherCondition(string Location, string CurrentConditions, decimal Temperature, string TemperatureUnit, decimal WindSpeed, string WingSpeedDirection);