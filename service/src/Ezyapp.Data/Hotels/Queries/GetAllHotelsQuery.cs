using Ezyapp.Data.Hotels.Models;
using Ezyapp.Domain.Hotels.Models;
using Ezyapp.Domain.Hotels.Repository;
using Microsoft.EntityFrameworkCore;

namespace Ezyapp.Data.Hotels.Queries;

public class GetAllHotelsQuery : IGetAllHotelsQuery
{
    private readonly ApplicationDbContext _context;

    public GetAllHotelsQuery(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    {
        var entities = await _context.Hotels.ToArrayAsync().ConfigureAwait(false);
        return entities.Select(x => new Hotel { Id = x.Id, Name = x.Name });
    }
}
