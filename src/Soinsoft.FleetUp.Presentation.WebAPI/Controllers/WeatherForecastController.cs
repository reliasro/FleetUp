using MediatR;
using Microsoft.AspNetCore.Mvc;
using Soinsoft.FleetUp.Application.Business.Features.Assets.Commands.Create;

namespace Soinsoft.FleetUp.Presentation.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private readonly IMediator _mediator;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        //Probando el funcionamiento de Mediator
        CreateAssetCommand item = new(){
            VIN="AFF-0255",Description="Test From Controller",
            CurrentValue=1975, Model="Mazda",Make="Honda",Year="1988",Color="Gray"
        };

        _mediator.Send(item);

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
