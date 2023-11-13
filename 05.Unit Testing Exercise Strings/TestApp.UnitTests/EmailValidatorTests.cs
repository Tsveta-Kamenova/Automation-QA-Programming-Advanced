using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("valid_Email@valid.domain.net")]
    [TestCase("valid+Email@valid.domain")]
    [TestCase("valid_Email@valid.domain")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }


    [TestCase("invalid Email@valid.domain")]
    [TestCase("valid_Email@in valid.domain")]
    [TestCase("invalid Email@in valid.domain")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
