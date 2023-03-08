using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ezyapp.Data.Hotels.Models;
using Ezyapp.Domain.Hotels.Models;
using Ezyapp.Domain.Hotels.Repository;

namespace Ezyapp.Data.Hotels.Queries
{
    public class CreateHotelQuery : ICreateHotelQuery
    {
        private readonly ApplicationDbContext _context;

        public CreateHotelQuery(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<int> CreateHotel(Hotel hotel, bool save)
        {
            var entity = new HotelEntity { Id = hotel.Id, Name = hotel.Name };
            _context.Hotels.Add(entity);
            return save ? await _context.SaveChangesAsync().ConfigureAwait(false) : 0;
        }
    }
}