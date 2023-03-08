using Ezyapp.Data.Hotels.Models;
using Ezyapp.Domain.Hotels.Models;
using Ezyapp.Domain.Hotels.Repository;

namespace Ezyapp.Data.Hotels.Queries;

public class GetAllHotels : IGetAllHotels
{
    IEnumerable<Hotel> IGetAllHotels.GetAllHotels()
    {
        var hotels = new HotelEntity[] 
        { 
            new HotelEntity { Id = Guid.NewGuid(), Name = "test"} 
        };
        return hotels.Select(x => new Hotel { Id = x.Id, Name = x.Name });
    }
}
