using System.ComponentModel.DataAnnotations;

namespace r00ch.LotteryTicketRegistrator.Web.Models
{
    public class UserModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}