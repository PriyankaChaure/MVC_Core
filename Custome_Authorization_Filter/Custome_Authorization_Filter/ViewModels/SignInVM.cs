using System.ComponentModel.DataAnnotations;

namespace Custome_Authorization_Filter.ViewModels
{
    public class SignInVM
    {
        [Required(ErrorMessage ="Email Id Require!!")]
        [EmailAddress(ErrorMessage ="Invalid Email Id!!")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Password Require!!")]
        public string Password { get; set; }
    }
}
