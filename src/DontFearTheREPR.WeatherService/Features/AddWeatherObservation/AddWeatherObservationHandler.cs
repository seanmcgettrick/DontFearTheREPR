using DontFearTheREPR.WeatherService.Data;
using MediatR;

namespace DontFearTheREPR.WeatherService.Features.AddWeatherObservation;

public class AddWeatherObservationHandler : IRequestHandler<AddWeatherObservationCommand>
{
    private readonly WeatherDataStore _weatherDataStore;

    public AddWeatherObservationHandler(WeatherDataStore weatherDataStore) => _weatherDataStore = weatherDataStore;

    public async Task Handle(AddWeatherObservationCommand request, CancellationToken cancellationToken)
    {
        var (location, currentConditions, temperature, temperatureUnit, windSpeed, windSpeedUnit) =
            request.WeatherObservation;

        await _weatherDataStore.AddWeatherCondition(new WeatherCondition(location, currentConditions, temperature,
            temperatureUnit, windSpeed, windSpeedUnit));

    }
}