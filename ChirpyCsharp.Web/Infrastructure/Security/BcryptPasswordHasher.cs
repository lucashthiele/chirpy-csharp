using ChirpyCsharp.Web.Domain.Services;

namespace ChirpyCsharp.Web.Infrastructure.Security;

public class BcryptPasswordHasher : IPasswordHasher
{
    public string Hash(string plainPassword)
    {
        throw new NotImplementedException();
    }

    public bool IsMatch(string hashPassword, string plainPassword)
    {
        throw new NotImplementedException();
    }
}