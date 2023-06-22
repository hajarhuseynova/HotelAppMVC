using HotelApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Context
{
    public class HotelAppDbContext:DbContext
    {
        public DbSet<Slider> Slides { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Service> Services { get; set; }
        public HotelAppDbContext(DbContextOptions<HotelAppDbContext> options) : base(options)
        {

        }
    }
}
