using ChirpyCsharp.Web.Domain.Entities.User;
using ChirpyCsharp.Web.Infrastructure.Exceptions;

namespace ChirpyCsharp.Tests.Domain.Entities.User;

public class UserBuilderTest
{
    private const string ValidEmailAddress = "test@test.com";
    private const string ValidPassword = "12345678";

    [Fact]
    public void GivenPasswordShouldHash()
    {
        var validEmail = ValidEmailAddress;
        var validPassword = ValidPassword;

        var user = new UserBuilder()
            .Email(validEmail)
            .Password(validPassword)
            .Build();

        var isValid = BcryptValidator.IsValidBcryptHash(user.Password);
        Assert.True(isValid);
    }

    [Fact]
    public void GivenValidInputShouldBuildUser()
    {
        var validEmail = ValidEmailAddress;
        var validPassword = ValidPassword;
        var createdAt = DateTime.UtcNow;
        var updatedAt = DateTime.UtcNow;

        var user = new UserBuilder()
            .Email(validEmail)
            .Password(validPassword)
            .CreatedAt(createdAt)
            .UpdatedAt(updatedAt)
            .Build();

        Assert.IsType<Web.Domain.Entities.User.User>(user);
        Assert.Equal(ValidEmailAddress, user.Email);
        var isValid = BcryptValidator.IsValidBcryptHash(user.Password);
        Assert.True(isValid);
        Assert.Equal(createdAt, user.CreatedAt);
        Assert.Equal(updatedAt, user.UpdatedAt);
    }

    [Fact]
    public void GivenInvalidEmailShouldThrowException()
    {
        var invalidEmail = "invalid_email";
        var password = ValidPassword;

        var ex = Assert.Throws<InvalidEmailException>(() =>
            new UserBuilder().Email(invalidEmail).Password(password).Build());
        Assert.Equal("invalid email", ex.Message);
    }

    [Fact]
    public void NotGivenEmailShouldThrow()
    {
        var validPassword = ValidPassword;
        var createdAt = DateTime.UtcNow;
        var updatedAt = DateTime.UtcNow;

        var ex = Assert.Throws<MissingFieldException>(() => new UserBuilder()
            .Password(validPassword)
            .CreatedAt(createdAt)
            .UpdatedAt(updatedAt)
            .Build());
        Assert.Equal("email not provided", ex.Message);
    }

    [Fact]
    public void NotGivenPasswordShouldThrow()
    {
        var validEmail = ValidEmailAddress;
        var createdAt = DateTime.UtcNow;
        var updatedAt = DateTime.UtcNow;

        var ex = Assert.Throws<MissingFieldException>(() => new UserBuilder()
            .Email(validEmail)
            .CreatedAt(createdAt)
            .UpdatedAt(updatedAt)
            .Build());
        Assert.Equal("email not provided", ex.Message);
    }
}