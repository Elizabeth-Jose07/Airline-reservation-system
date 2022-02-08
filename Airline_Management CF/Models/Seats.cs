
using System;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Airline_Management_CF.Models
{
    [Table("Seat")]
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [Required(ErrorMessage ="specify the class")]
        [StringLength(10)]
        public string SeatType { get; set;}

        [Required]
        public int SeatNumber { get; set; }

        [Required]
        public float Price { get; set; }

        [ForeignKey("FlightInfo")]
        public int FlightId { get; set; }

        public virtual FlightInfo FlightInfo { get; set; }
    }
}
