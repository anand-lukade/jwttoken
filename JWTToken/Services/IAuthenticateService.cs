using JWTToken.Model;

namespace JWTToken.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string username,string password);
    }
}
