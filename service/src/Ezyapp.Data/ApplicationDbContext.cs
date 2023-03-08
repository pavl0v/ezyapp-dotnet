using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ezyapp.Data.Hotels.Models;
using Microsoft.EntityFrameworkCore;

namespace Ezyapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<HotelEntity> Hotels { get; set; }
        public DbSet<HotelRawEntity> HotelsRaw { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ezyappnet;Username=postgres;Password=postgres");
        }
    }
}