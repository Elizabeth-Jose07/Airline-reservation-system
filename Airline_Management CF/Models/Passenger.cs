using System;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Airline_Management_CF.Models
{
    [Table("Passenger")]
    public class Passenger
    {

        [Key]
        public int PassId { get; set; }

        [Required(ErrorMessage ="First Name required")]
        [Display(Name ="First Name")]
        [MaxLength(20, ErrorMessage = "Maximum length 20 characters")]
        public string PFirstName { get; set; }

        [Required(ErrorMessage = "last Name required")]
        [Display(Name = "Last Name")]
        [MaxLength(20,ErrorMessage ="Maximum length 20 characters")]
        public string PLastName { get; set; }

        [Required(ErrorMessage ="Please specify the gender")]
        [StringLength(10,ErrorMessage ="please specify gender")]

        public string Gender { get; set; }

        [Required]
        public  int Age { get; set; }


        //[ForeignKey("User")]
        //public int UserId { get; set; }

        [ForeignKey("Seat")]
        public int SeatId { get; set; }

        //public virtual User User { get; set; }
        public virtual Seat Seat { get; set; }




    }
}
