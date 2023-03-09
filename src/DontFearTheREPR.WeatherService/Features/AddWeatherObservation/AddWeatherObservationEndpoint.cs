using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DontFearTheREPR.WeatherService.Features.AddWeatherObservation;

public class AddWeatherObservationEndpoint : EndpointBaseAsync.WithRequest<AddWeatherObservationRequest>.WithoutResult
{
    private readonly IMediator _mediator;

    public AddWeatherObservationEndpoint(IMediator mediator) => _mediator = mediator;

    [HttpPost("api/weather")]
    public override async Task HandleAsync(
        [FromBody] AddWeatherObservationRequest request,
        CancellationToken cancellationToken = new())
    {
        await _mediator.Send(new AddWeatherObservationCommand(request), cancellationToken);
    }
}