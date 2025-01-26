using ApiClassLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace ArchiLogApi.Data.Models
{
    public class Car : BaseModel
    {
        [MaxLength(150)]
        [Required]
        public string Model { get; set; } = "";

        [MaxLength(150)]
        [Required]
        public string Brand { get; set; } = "";

        [Required]
        public float DailyRate { get; set; } = 0;
    }
}
