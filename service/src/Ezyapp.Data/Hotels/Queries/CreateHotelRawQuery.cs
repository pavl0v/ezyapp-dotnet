using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ezyapp.Data.Hotels.Models;
using Ezyapp.Domain.Hotels.Models;
using Ezyapp.Domain.Hotels.Repository;

namespace Ezyapp.Data.Hotels.Queries
{
    public class CreateHotelRawQuery : ICreateHotelRawQuery
    {
        private readonly ApplicationDbContext _context;

        public CreateHotelRawQuery(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<int> CreateHotelRaw(HotelRaw hotel, bool save)
        {
            var entity = new HotelRawEntity { Id = hotel.Id, Raw = hotel.Raw };
            _context.HotelsRaw.Add(entity);
            return save ? await _context.SaveChangesAsync().ConfigureAwait(false) : 0;
        }
    }
}