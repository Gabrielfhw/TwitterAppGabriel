using System.ComponentModel.DataAnnotations;

namespace TwitterAppGabriel.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "The email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm the password")]
        [Compare("Password", ErrorMessage = "The informed password are not the same")]
        public string ConfirmPassword { get; set; }
    }
}
