namespace ChirpyCsharp.Web.Domain.Services;

public interface IPasswordHasher
{
    string Hash(string plainPassword);
    bool IsMatch(string hashPassword, string plainPassword);
}