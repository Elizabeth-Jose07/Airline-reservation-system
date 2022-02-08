using System;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Airline_Management_CF.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public string PaymentType { get; set; }

        [Required]      
       public float  PaymentAmount { get; set; }
       
        [Required]
        public bool TransactionStatus { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }


        public virtual User User { get; set; }

    }
}
