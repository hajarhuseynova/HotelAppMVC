using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Service:BaseModel
    {
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
