using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ezyapp.Api.Hotels.Models
{
    public class HotelsResponse
    {
        public IEnumerable<Hotel> Payload { get; set; } = new Hotel[0];
    }
}