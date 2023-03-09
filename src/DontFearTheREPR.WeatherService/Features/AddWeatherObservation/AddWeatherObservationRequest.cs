namespace DontFearTheREPR.WeatherService.Features.AddWeatherObservation;

public record AddWeatherObservationRequest(string Location, string CurrentConditions, decimal Temperature, string TemperatureUnit, decimal WindSpeed, string WingSpeedDirection);