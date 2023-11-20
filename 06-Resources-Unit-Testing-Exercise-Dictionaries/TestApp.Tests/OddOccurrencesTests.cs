using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "5", "5", "abvc", "abvc" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = { "5" };

        StringBuilder sb = new();
        sb.AppendLine("5 ");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = { "5", "5", "awe", "5", "afghyt", "afghyt", "awe", "afghyt", "afghyt", "afghyt" };

        StringBuilder sb = new();
        sb.AppendLine("5 afghyt");
    
        string expectedResult = sb.ToString().Trim();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "5", "5", "aWE", "5", "afGhyt", "AFghyT", "awe", "Afghyt", "afghyt", "afGHyt" };

        StringBuilder sb = new();
        sb.AppendLine("5 afghyt");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
