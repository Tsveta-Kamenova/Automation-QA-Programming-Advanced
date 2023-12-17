using NUnit.Framework;
using System.Security.Cryptography;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int rotations = 189;

        // Act 
        string result = StringRotator.RotateRight(input, rotations);
        string expected = string.Empty;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "Qwerty89";
        int rotations = 0;

        // Act 
        string result = StringRotator.RotateRight(input, rotations);
        string expected = "Qwerty89";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Qwerty89";
        int rotations = 3;

        // Act 
        string result = StringRotator.RotateRight(input, rotations);
        string expected = "y89Qwert";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Qwerty89";
        int rotations = -5;

        // Act 
        string result = StringRotator.RotateRight(input, rotations);
        string expected = "rty89Qwe";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "Qwerty89";
        int rotations = 3 + (input.Length * 2);

        // Act 
        string result = StringRotator.RotateRight(input, rotations);
        string expected = "y89Qwert";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
