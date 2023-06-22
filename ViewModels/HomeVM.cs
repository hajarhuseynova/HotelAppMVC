using HotelApp.Models;

namespace HotelApp.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Slides { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public Setting Settings { get; set; }
    }
}
