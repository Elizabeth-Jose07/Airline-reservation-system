 using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Airline_Management_CF.Models
{
    [Table("FlightDetails")]
    public class FlightDetails
    {
       

        [Key]

        public int FlightNumber { get; set; }

        [Required(ErrorMessage ="Flight Name")]
        [Display (Name ="Flight Name")]
        public string FlightName { get; set; }

        [Required]
        [Display(Name ="Flight Model")]

        public string FlightModel { get; set; }
    }
}
