using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ezyapp.Data.Hotels.Models
{
    public class HotelEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
    }
}