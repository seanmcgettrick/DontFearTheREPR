using MediatR;

namespace DontFearTheREPR.WeatherService.Features.GetCurrentWeather;

public record GetCurrentWeatherQuery(string ZipCode) : IRequest<GetCurrentWeatherResponse>;
