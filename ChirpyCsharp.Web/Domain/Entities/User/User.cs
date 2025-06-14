namespace ChirpyCsharp.Web.Domain.Entities.User;

public class User
{
    private Guid _id;
    private string? _email;
    private string? _hashedPassword;
    private string? _accessToken;
    private string? _refreshToken;
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

    public string HashedPassword
    {
        get => _hashedPassword!;
        set => _hashedPassword = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string AccessToken
    {
        get => _accessToken!;
        set => _accessToken = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string RefreshToken
    {
        get => _refreshToken!;
        set => _refreshToken = value ?? throw new ArgumentNullException(nameof(value));
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
