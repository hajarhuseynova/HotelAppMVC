using HotelApp.Context;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly HotelAppDbContext _context;

        public ServiceController(HotelAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Service> services= await _context.Services.Where(x=>!x.IsDeleted).ToListAsync();
            return View(services);
        }
    //    public async Task<IActionResult> Create()
    //    {
    //        Service service = new Service
    //        {
    //            CreatedDate = DateTime.Now,
    //            Title = "WELCOME 10",
    //            Desc = "hello guyss",
    //            Icon= "<i class='fa fa-utensils fa-2x text-primary'></i>",
    //            IsDeleted = false,
    //            Link = "hahaha",
    //        };
    //        Service service2 = new Service
    //        {
    //            CreatedDate = DateTime.Now,
    //            Title = "WELCOME 15",
    //            Desc = "hello guyss",
    //            Icon = "<i class='fa fa-hotel fa-2x text-primary'></i>",
    //            IsDeleted = false,
    //            Link = "hahaha",
    //        };
    //        Service service3 = new Service
    //        {
    //            CreatedDate = DateTime.Now,
    //            Title = "WELCOME 55",
    //            Desc = "hello guyss",
    //            Icon = "<i class='fa fa-hotel fa-2x text -primary'></i>",
    //            IsDeleted = false,
    //            Link = "hahaha",
    //        };



    //        await _context.AddAsync(service);
    //    await _context.AddAsync(service2);
    //        await _context.AddAsync(service3);
    //        await _context.SaveChangesAsync();
    //        return Json("OK");
    //}


}
}
