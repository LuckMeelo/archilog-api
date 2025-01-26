using ApiClassLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArchiLogApi.Data.Models
{
    public class Reservation : BaseModel
    {

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int TotalCost { get; set; }

        [Required]
        public int CarID { get; set; }

        [Required]
        [ForeignKey(nameof(CarID))]
        public virtual Car ReservedCar { get; set; }
    }
}
