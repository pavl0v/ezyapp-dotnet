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
    public async Task<HotelsResponse> GetAllHotelsAsync()
    {
        var hotels = await _hotelsService.GetAllHotelsAsync();
        return new HotelsResponse 
        {
            Payload = hotels.Select(x => new Hotel { Id = x.Id, Name = x.Name }).ToArray()
        };
    }
}
