using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ezyapp.Domain.Hotels.Models
{
    public class HotelRaw
    {
        public Guid Id { get; set; }
        public string Raw { get; set; } = default!;
    }
}