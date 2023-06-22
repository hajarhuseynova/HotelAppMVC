
using HotelApp.Context;
using HotelApp.Models;
using HotelApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HotelAppDbContext _context;

        public HomeController(HotelAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
           HomeVM homeVM = new HomeVM();
            homeVM.Slides = _context.Slides.Where(x => !x.IsDeleted).ToList();
            homeVM.Settings = _context.Settings.FirstOrDefault();
            homeVM.Services = _context.Services.Where(x => !x.IsDeleted).ToList();
            return View(homeVM);
        }

        //public async Task<IActionResult> Create()
        //{
        //    Slider Slider = new Slider
        //    {
        //        CreatedDate = DateTime.Now,
        //        Title = "WELCOME 10",
        //        IsDeleted = false,
        //        Image = "carousel-1.jpg",
        //        Link = "hahaha",
        //        isActive = true
        //    };
        //    Slider Slider2 = new Slider
        //    {
        //        CreatedDate = DateTime.Now,
        //        Title = "WELCOME 20",
        //        IsDeleted = false,
        //        Image = "carousel-1.jpg",
        //        Link = "hahaha"
        //    };
        //    await _context.AddAsync(Slider);
        //    await _context.AddAsync(Slider2);
        //    await _context.SaveChangesAsync();
        //    return Json("OK");
        //}


        //public async Task<IActionResult> Create()
        //{
        //    Setting Setting = new Setting
        //    {
        //        CreatedDate = DateTime.Now,
        //       Email ="hajar@code.edu",
        //       Address="gunaydinsokak",
        //       ClientCount=50,
        //       StaffCount=250,
        //       RoomCount=500,
        //       PhoneNumber="+9943928274",
        //       AboutText="gunaydiiin cocxular xosh geldizniz",
        //       DiscoverDescription="lalala ben enguzel",
        //       DiscoverTitle="babiesss",
        //       VideoLink= "https://www.youtube.com/watch?v=ueEA3pTOUuU&list=RDueEA3pTOUuU&start_radio=1"
        //    };
         
        //    await _context.AddAsync(Setting);
        //    await _context.SaveChangesAsync();
        //    return Json("OK");
        //}

    }
}