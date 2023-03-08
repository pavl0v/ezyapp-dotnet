using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ezyapp.Domain.Hotels.Models;

namespace Ezyapp.Domain.Hotels.Repository
{
    public interface ICreateHotelRawQuery
    {
        Task<int> CreateHotelRaw(HotelRaw hotel, bool save);
    }
}