using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ezyapp.Api.Hotels.Models
{
    public class Hotel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
    }
}