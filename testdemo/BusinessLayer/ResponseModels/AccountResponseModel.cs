namespace STARAS.BusinessLayer.ResponseModels
{
    public class AccountResponseModel
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? RefreshToken { get; set; }

        public int? RoleId { get; set; }

        public bool? Active { get; set; }
    }
}
