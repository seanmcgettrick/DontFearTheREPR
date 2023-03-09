namespace DontFearTheREPR.WeatherService.Features.GetCurrentWeather;

public record GetCurrentWeatherResponse(string Location, string CurrentConditions, decimal Temperature, string TemperatureUnit, decimal WindSpeed, string WingSpeedDirection);