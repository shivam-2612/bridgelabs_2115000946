using System;
using NUnit.Framework;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            throw new ArgumentException();
    }
}

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration reg;

    [SetUp]
    public void Setup() => reg = new UserRegistration();

    [Test]
    public void ValidUser() => Assert.DoesNotThrow(() => reg.RegisterUser("user", "email@test.com", "pass123"));

    [Test]
    public void InvalidUser() => Assert.Throws<ArgumentException>(() => reg.RegisterUser("", "", ""));
}
