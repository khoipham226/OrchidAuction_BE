using STARAS.BusinessLayer.ResponseModels;
using STARAS.DataLayer.Models;

namespace STARAS.BusinessLayer.Utilities.JwtService
{
    public interface IJwtService
    {
        TokenModel GenerateToken(Account account);
        bool ValidateToken(string token);
        string HashPassword(string password);
        bool VerifyPassword(string password, string hashedPassword);
    }
}
