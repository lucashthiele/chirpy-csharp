using ChirpyCsharp.Web.Domain.Services;
using static BCrypt.Net.BCrypt;

namespace ChirpyCsharp.Web.Infrastructure.Security;

public class BcryptPasswordHasher : IPasswordHasher
{
    private const int SaltNumber = 8;

    public string Hash(string plainPassword)
    {
        return HashPassword(plainPassword, SaltNumber);
    }

    public bool IsMatch(string hashPassword, string plainPassword)
    {
        return Verify(plainPassword, hashPassword);
    }
}