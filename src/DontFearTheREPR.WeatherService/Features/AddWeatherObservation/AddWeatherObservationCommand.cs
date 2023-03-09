using MediatR;

namespace DontFearTheREPR.WeatherService.Features.AddWeatherObservation;

public record AddWeatherObservationCommand(AddWeatherObservationRequest WeatherObservation) : IRequest;