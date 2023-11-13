using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] textInput = Array.Empty<string>();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(textInput);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] textInput = { "asd" };
        string expectedOutput = "asd";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(textInput);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] textInput = { "asd" , "ghj", "poi"};
        string expectedOutput = "poighjasd";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(textInput);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] textInput = null;

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(textInput);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] textInput = { "asd    dfg", "ptoyi" };
        string expectedOutput = "ptoyiasd    dfg";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(textInput);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] textInput = { "asd", "ghj", "poi", "qwerty", "asd dfg", "ptoyi", "a", "b" };
        string expectedOutput = "baptoyiasd dfgqwertypoighjasd";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(textInput);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }
}
