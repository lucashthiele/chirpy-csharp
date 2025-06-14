using ChirpyCsharp.Web.Infrastructure.Security;

namespace ChirpyCsharp.Web.Domain.Entities.User;

public class UserBuilder
{
    private readonly User _user;
    private readonly BcryptPasswordHasher _hasher = new();

    public UserBuilder()
    {
        _user = new User();
    }

    public UserBuilder Email(string email)
    {
        _user.Email = email;
        return this;
    }

    public UserBuilder Password(string password)
    {
        var hashedPassword = _hasher.Hash(password);
        _user.Password = hashedPassword;
        return this;
    }

    public UserBuilder AccessToken(string accessToken)
    {
        _user.AccessToken = accessToken;
        return this;
    }

    public UserBuilder RefreshToken(string refreshToken)
    {
        _user.RefreshToken = refreshToken;
        return this;
    }

    public UserBuilder CreatedAt(DateTime createdAt)
    {
        _user.CreatedAt = createdAt;
        return this;
    }

    public UserBuilder UpdatedAt(DateTime updatedAt)
    {
        _user.UpdatedAt = updatedAt;
        return this;
    }

    public User Build()
    {
        return _user;
    }
}