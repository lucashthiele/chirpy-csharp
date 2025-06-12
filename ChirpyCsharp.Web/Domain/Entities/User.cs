namespace ChirpyCsharp.Web.Domain.Entities;

public class User
{
    private Guid _id;
    private string? _email;
    private string? _password;
    private DateTime _createdAt;
    private DateTime _updatedAt;

    public Guid Id
    {
        get => _id;
        set => _id = value.Equals(null) ? Guid.NewGuid() : value;
    }

    public string Email
    {
        get => _email!;
        set => _email = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Password
    {
        get => _password!;
        set => _password = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value;
    }

    public DateTime UpdatedAt
    {
        get => _updatedAt;
        set => _updatedAt = value;
    }
}

public class UserBuilder
{
    private User _user;

    public UserBuilder Email(string email)
    {
        _user.Email = email;
        return this;
    }

    public UserBuilder Password(string password)
    {
        _user.Password = password;
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