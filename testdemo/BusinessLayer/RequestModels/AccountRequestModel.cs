using System.ComponentModel.DataAnnotations;

namespace STARAS.BusinessLayer.RequestModels
{
    public class AccountUpdateModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "RoleId is required")]
        public int? RoleId { get; set; }

        public bool? Active { get; set; }
    }

    public class AccountAllResponseModel
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? RefreshToken { get; set; }

        public int? RoleId { get; set; }

        public bool? Active { get; set; }

        public int? CompanyId { get; set; }
    }
}
