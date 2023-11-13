using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWordsInput = { "cat" };
        string textInput = "The quick brown fox jumps over the lazy dog";
        string expectedOutput = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWordsInput,textInput);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWordsInput = { "quick", "dog" };
        string textInput = "The quick brown fox jumps over the lazy dog";
        string expectedOutput = "The ***** brown fox jumps over the lazy ***";

        // Act
        string result = TextFilter.Filter(bannedWordsInput, textInput);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWordsInput = Array.Empty<string>();
        string textInput = "The quick brown fox jumps over the lazy dog";
        string expectedOutput = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWordsInput, textInput);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWordsInput = { " quick ", "dog" };
        string textInput = "The quick brown fox jumps over the lazy dog";
        string expectedOutput = "The*******brown fox jumps over the lazy ***";

        // Act
        string result = TextFilter.Filter(bannedWordsInput, textInput);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }
}
