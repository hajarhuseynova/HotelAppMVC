using HotelApp.Context;
using HotelApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services
{
    public class SettingService
    {
        private readonly HotelAppDbContext _context;

        public SettingService(HotelAppDbContext context)
        {
            _context = context;
        }
        public async Task<Setting?> Get()
        {
            Setting? setting = await _context.Settings.FirstOrDefaultAsync();
            return setting;
        }
    }
}
