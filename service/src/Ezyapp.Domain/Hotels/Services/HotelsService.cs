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
        private readonly IGetAllHotelsQuery _repository;

        public HotelsService(IGetAllHotelsQuery repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Hotel>> GetAllHotelsAsync()
        {
            return _repository.GetAllHotelsAsync();
        }
    }
}