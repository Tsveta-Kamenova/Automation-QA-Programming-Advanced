using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expectedResult = "The quick brown jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "The";
        string input = "The quick brown fox jumps over the lazy dog";
        string expectedResult = "quick brown fox jumps over lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "The quick brown fox jumps over the lazy dog";
        string expectedResult = "The quick brown fox jumps over the lazy";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "dog";
        string input = "Dog dog DOG DOg dOG dog";
        string expectedResult = "";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    //[Test]
    //public void Test_EmptyStringInput_ReturnEmptyString()
    //{
    //    // Arrange
    //    string toRemove = "";
    //    string input = "The quick brown fox jumps over the lazy dog";
    //    string expectedResult = "";

    //    // Act
    //    string result = Substring.RemoveOccurrences(toRemove, input);

    //    // Assert
    //    Assert.That(result, Is.EqualTo(expectedResult));
    //}
}
