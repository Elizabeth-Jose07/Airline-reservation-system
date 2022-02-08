using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Airline_Management_CF.Models
{
    [Table("FlightInfo")]
    public class FlightInfo 
    {
        [Key]
        public int FlightId { get; set; }                 //primary key

        [ForeignKey("FlightDetails")]
        public int FlightNumber { get; set; }      //foreign key
       

        [Required(ErrorMessage ="source City Required")]
        [Display(Name ="Source")]
        [StringLength(40, ErrorMessage ="maximum 40 characters")]
        public string Source { get; set;}                  //source city


        [Required(ErrorMessage = "Destination City Required")]
        [Display(Name = "Destination")]
        [StringLength(40, ErrorMessage = "maximum 40 characters")]
        public string Destination { get; set; }                       //destination city


        [Required(ErrorMessage = "Departure date  Required")]
        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]                                   //departure date
       
        public DateTime  DepartureDate{ get; set; }


        [Required(ErrorMessage ="Arrival date required")]
        [Display(Name = " Date")]
        [DataType(DataType.Date)]

        public DateTime ArrivalDate { get; set; }               //arrival date

        //[Required]
        //public TimeSpan DepartureTime { get; set; }
        
        //[Required]
        //public TimeSpan ArrivalTime { get; set; }

        [Display(Name = "Buisness class seats ")] 
                                            //buisness calss saets in number
        public int  Bseats { get; set; }

        [Display(Name ="Economy class seats")]              //economy class seats
        public int Eseats { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;      //is active



        public virtual FlightDetails Flight { get; set; }
    }
}
