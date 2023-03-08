using Ezyapp.Api.Hotels.Models;
using Ezyapp.Domain.Hotels.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ezyapp.Api.Hotels;

[ApiController]
[Route("api/hotels")]
public class HotelsController : ControllerBase
{
    private readonly HotelsService _hotelsService;
    
    public HotelsController(HotelsService hotelsService)
    {
        _hotelsService = hotelsService;
    }

    [HttpGet("all")]
    public HotelsResponse GetAllHotels()
    {
        var hotels = _hotelsService.GetAllHotels();
        return new HotelsResponse 
        {
            Payload = hotels.Select(x => new Hotel { Id = x.Id, Name = x.Name }).ToArray()
        };
    }
}
