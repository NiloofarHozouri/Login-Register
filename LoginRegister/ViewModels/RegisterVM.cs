using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginRegister.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords Dont match . . . ")]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
    }
}
