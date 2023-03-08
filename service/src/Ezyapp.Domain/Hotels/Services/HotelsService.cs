using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ezyapp.Domain.Hotels.Models;
using Ezyapp.Domain.Hotels.Repository;

namespace Ezyapp.Domain.Hotels.Services
{
    public class HotelsService
    {
        private readonly IGetAllHotels _repository;

        public HotelsService(IGetAllHotels repository)
        {
            _repository = repository;
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            return _repository.GetAllHotels();
        }
    }
}