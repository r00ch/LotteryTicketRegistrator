using System;
using System.ComponentModel.DataAnnotations;
using r00ch.LotteryTicketRegistrator.Models.Entities;

namespace r00ch.LotteryTicketRegistrator.Web.Models
{
    public class CustomerModel
    {
        [Required]
        [RegularExpression("[+]?[0-9]+", ErrorMessage = "Phone Number may contain only numbers")]
        public string PhoneNumber { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Name may contain only letters")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Surname may contain only letters")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("[0-9]{2}-[0-9]{3}", ErrorMessage = "Invalid Postal Code format. Should be: 00-000")]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string EmailAddress { get; set; }

        public Customer ToEntity()
        {
            var phoneNumberAsInt = PhoneNumber.Replace("+", "00");
            var customerEntity = new Customer
            {
                PhoneNumber = phoneNumberAsInt,
                FirstName = this.FirstName,
                LastName = this.LastName,
                PostalCode = this.PostalCode,
                EmailAddress = this.EmailAddress
            };
            return customerEntity;
        }
    }
}