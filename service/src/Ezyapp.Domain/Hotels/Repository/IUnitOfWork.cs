using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ezyapp.Domain.Hotels.Repository
{
    public interface IUnitOfWork
    {
        Task<int> DoneAsync();
    }
}