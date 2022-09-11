using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }




        [DisplayName("First Name")]
        public string FirstName { get; set; }




        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]

        public string UserName { get; set; }


        [DisplayName("Password")]
        public string Password { get; set; }


        public string Gender { get; set; }

        [Required]
        [DisplayName("Mobile No")]
        public string MobileNo { get; set; }



        [DisplayName("Email")]
        public string Email { get; set; }

        public string Address { get; set; }
    }
}
