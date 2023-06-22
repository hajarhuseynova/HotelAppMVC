using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Slider:BaseModel
    {
        [Required]
        [StringLength(100)] 
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Link { get; set; }    
        public bool isActive { get; set; }  
    }
}
