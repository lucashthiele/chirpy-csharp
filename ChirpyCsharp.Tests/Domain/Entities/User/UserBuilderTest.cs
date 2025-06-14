using ChirpyCsharp.Tests.Helpers;
using ChirpyCsharp.Web.Domain.Entities.User;
using ChirpyCsharp.Web.Infrastructure.Exceptions;

namespace ChirpyCsharp.Tests.Domain.Entities.User;

public class UserBuilderTest
{
    private const string ValidEmailAddress = "test@test.com";
    private const string ValidPassword = "12345678";

    [Fact]
    public void GivenValidInputShouldBuildUser()
    {
        var validEmail = ValidEmailAddress;
        var validPassword = ValidPassword;
        var createdAt = DateTime.UtcNow;
        var updatedAt = DateTime.UtcNow;

        var user = new UserBuilder()
            .Email(validEmail)
            .HashedPassword(validPassword)
            .CreatedAt(createdAt)
            .UpdatedAt(updatedAt)
            .Build();

        Assert.IsType<Web.Domain.Entities.User.User>(user);
        Assert.Equal(ValidEmailAddress, user.Email);
        Assert.Equal(createdAt, user.CreatedAt);
        Assert.Equal(updatedAt, user.UpdatedAt);
    }

    [Fact]
    public void NotGivenEmailShouldThrow()
    {
        var validPassword = ValidPassword;
        var createdAt = DateTime.UtcNow;
        var updatedAt = DateTime.UtcNow;

        var ex = Assert.Throws<MissingFieldException>(() => new UserBuilder()
            .HashedPassword(validPassword)
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
        Assert.Equal("password not provided", ex.Message);
    }
}