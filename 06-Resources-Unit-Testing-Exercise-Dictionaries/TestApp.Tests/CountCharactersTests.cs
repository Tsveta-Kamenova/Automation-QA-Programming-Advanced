using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "a", "aaaa", "aaa"};

        // Act
        string result = CountCharacters.Count(input);
        string expectedResult = "a -> 8";

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithOnlyOneCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "a"};

        // Act
        string result = CountCharacters.Count(input);
        string expectedResult = "a -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "abcbaaaa", "asd", "b" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 6");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 1");
        sb.AppendLine("s -> 1");
        sb.AppendLine("d -> 1");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);
        //string expectedResult = "a -> 6\r\nb -> 3\r\nc -> 1\r\ns -> 1\r\nd -> 1";

        // Assert
        Assert.That(result , Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "$@aa#", "@" };

        StringBuilder sb = new();
        sb.AppendLine("$ -> 1");
        sb.AppendLine("@ -> 2");
        sb.AppendLine("a -> 2");
        sb.AppendLine("# -> 1");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    [Test]
    public void Test_Count_WithUpperCaseAndNumbers_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "$@aA#", "@2 1" };

        StringBuilder sb = new();
        sb.AppendLine("$ -> 1");
        sb.AppendLine("@ -> 2");
        sb.AppendLine("a -> 1");
        sb.AppendLine("A -> 1");
        sb.AppendLine("# -> 1");
        sb.AppendLine("2 -> 1");
        sb.AppendLine("  -> 1");
        sb.AppendLine("1 -> 1");

        string expectedResult = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
