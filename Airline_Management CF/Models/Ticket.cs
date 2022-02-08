using System;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Airline_Management_CF.Models
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        [Required]
        public bool TicketStatus { get; set; } = true;
        [Required]
        public int SeatNumber { get; set; }

        [Required]
        public string SeatType { get; set; }
        [Required]
        public float Price { get; set; }



        [ForeignKey("FlightInfo")]
        public int FlightId { get; set; }
       
       
        
        [ForeignKey("Payment")]
        public int PaymentId { get; set; }


       
        public virtual FlightInfo Flight { get; set; }
       
        public virtual Payment Payment { get; set; }


    }
}
