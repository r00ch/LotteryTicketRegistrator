using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace r00ch.LotteryTicketRegistrator.Models.Entities
{
    [Table("Customers", Schema = "r00ch")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string EmailAddress { get; set; }
    }

    
}