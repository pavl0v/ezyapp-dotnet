using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ezyapp.Domain.Hotels.Models;
using Ezyapp.Domain.Hotels.Repository;

namespace Ezyapp.Domain.Hotels.Services
{
    public class CreateHotelService
    {
        private readonly ICreateHotelQuery _createHotel;
        private readonly ICreateHotelRawQuery _createHotelRaw;
        private readonly IUnitOfWork _unitOfWork;

        public CreateHotelService(
            ICreateHotelQuery createHotel, 
            ICreateHotelRawQuery createHotelRaw,
            IUnitOfWork unitOfWork)
        {
            _createHotel = createHotel;
            _createHotelRaw = createHotelRaw;
            _unitOfWork = unitOfWork;
        }

        public Task<int> CreateHotelAsync(Hotel hotel, HotelRaw hotelRaw)
        {
            _createHotel.CreateHotel(hotel, false);
            _createHotelRaw.CreateHotelRaw(hotelRaw, false);
            return _unitOfWork.DoneAsync();
        }
    }
}