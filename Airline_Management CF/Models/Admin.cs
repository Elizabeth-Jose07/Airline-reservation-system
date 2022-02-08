using System;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Airline_Management_CF.Models
{
    [Table("Admin")]
    public class Admin
    {

        [Key]
        public int Adminid { get; set; }


        [Required(ErrorMessage ="Admin Email ID required")]
        [Display(Name ="Email Id")]
        [MinLength(4, ErrorMessage = "minimum 4 characters required")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

     
        [Required(ErrorMessage = "Password required")]
       
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="minimum 8 characters required"),MaxLength(10,ErrorMessage ="Maximum 10 characters")]
        public string Password { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;


    }


}
