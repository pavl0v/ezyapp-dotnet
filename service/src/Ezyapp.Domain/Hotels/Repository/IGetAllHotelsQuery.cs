using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ezyapp.Domain.Hotels.Models;

namespace Ezyapp.Domain.Hotels.Repository
{
    public interface IGetAllHotelsQuery
    {
        Task<IEnumerable<Hotel>> GetAllHotelsAsync();
    }
}