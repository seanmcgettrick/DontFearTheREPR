using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DontFearTheREPR.WeatherService.Features.GetCurrentWeather;

public class GetCurrentWeatherEndpoint : EndpointBaseAsync.WithRequest<string>.WithActionResult<GetCurrentWeatherResponse>
{
    private readonly IMediator _mediator;

    public GetCurrentWeatherEndpoint(IMediator mediator) => _mediator = mediator;

    [HttpGet("api/weather/{zipCode}")]
    public override async Task<ActionResult<GetCurrentWeatherResponse>> HandleAsync(string zipCode,
        CancellationToken cancellationToken = new())
    {
        var currentWeather = await _mediator.Send(new GetCurrentWeatherQuery(zipCode), cancellationToken);

        if (currentWeather is null)
            return NotFound(currentWeather);

        return Ok(currentWeather);
    }
}