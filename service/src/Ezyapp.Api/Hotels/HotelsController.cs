using Ezyapp.Api.Hotels.Models;
using Ezyapp.Domain.Hotels.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ezyapp.Api.Hotels;

[ApiController]
[Route("api/hotels")]
public class HotelsController : ControllerBase
{
    private readonly HotelsService _hotelsService;
    private readonly CreateHotelService _createHotelService;
    
    public HotelsController(
        HotelsService hotelsService, 
        CreateHotelService createHotelService)
    {
        _hotelsService = hotelsService;
        _createHotelService = createHotelService;
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

    [HttpPost("create")]
    public async Task<CreateHotelResponse> CreateHotelAsync([FromBody] CreateHotelRequest request)
    {
        var id = Guid.NewGuid();
        var json = $@"{{""address"": ""{request.Address}"", ""name"": ""{request.Name}""}}";
        var hotel = new Domain.Hotels.Models.Hotel { Id = id, Name = request.Name };
        var hotelRaw = new Domain.Hotels.Models.HotelRaw { Id = id, Raw = json };
        await _createHotelService.CreateHotelAsync(hotel, hotelRaw);
        return new CreateHotelResponse 
        {
            Id = id
        };
    }
}
