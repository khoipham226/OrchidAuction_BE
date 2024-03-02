using System.ComponentModel.DataAnnotations;

namespace STARAS.BusinessLayer.RequestModels
{
    public class LoginModel
    {
        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? RefreshToken { get; set; }
    }

    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "OldPassword is required!")]
        public string OldPassword { get; set;}

        [Required(ErrorMessage = "New password is required.")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string NewPassword { get; set;}
    }
}
