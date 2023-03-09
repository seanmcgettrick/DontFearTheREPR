using DontFearTheREPR.WeatherService.Data;
using MediatR;

namespace DontFearTheREPR.WeatherService.Features.GetCurrentWeather;

public class GetCurrentWeatherHandler : IRequestHandler<GetCurrentWeatherQuery, GetCurrentWeatherResponse?>
{
    private readonly WeatherDataStore _weatherDataStore;

    public GetCurrentWeatherHandler(WeatherDataStore weatherDataStore) => _weatherDataStore = weatherDataStore;

    public async Task<GetCurrentWeatherResponse?> Handle(GetCurrentWeatherQuery request, CancellationToken cancellationToken)
    {
        var response = await _weatherDataStore.GetCurrentWeatherCondition(request.ZipCode);

        if (response is null)
            return null;

        return await Task.FromResult(new GetCurrentWeatherResponse(response.Location, response.CurrentConditions,
            response.Temperature, response.TemperatureUnit, response.WindSpeed, response.WingSpeedDirection));
    }
}