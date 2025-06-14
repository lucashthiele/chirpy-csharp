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

    public UserBuilder HashedPassword(string hashedPassword)
    {
        _user.HashedPassword = hashedPassword;
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
        if (string.IsNullOrWhiteSpace(_user.Email))
            throw new MissingFieldException("email not provided");

        if (string.IsNullOrWhiteSpace(_user.HashedPassword))
            throw new MissingFieldException("password not provided");
        
        return _user;
    }
}