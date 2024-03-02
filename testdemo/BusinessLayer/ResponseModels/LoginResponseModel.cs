namespace STARAS.BusinessLayer.ResponseModels
{
    public class LoginResponseModel
    {
        public AccountResponseModel Account { get; set; }
        public TokenModel Token { get; set; }
        public int StoreID { get; set; }
    }
}
