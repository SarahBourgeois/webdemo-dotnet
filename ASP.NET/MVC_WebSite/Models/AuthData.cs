using MVC_WebSite.Models.EDM;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_WebSite.Models
{
    public class AuthData 
    {
        // Login 
        [Required]
        [Display(Name = "login")]
        public string Login { get; set; }

        // Password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must contain at least {2} characters.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "password")]
        public string Password { get; set; }

        // Confirm password
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The two password don't correspond.")]
        public string ConfirmPassword { get; set; }

        // email
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email : ")]
        public string Email { get; set; }


        // List Users
        public List<User> UsersList { get; set; }
    }
}