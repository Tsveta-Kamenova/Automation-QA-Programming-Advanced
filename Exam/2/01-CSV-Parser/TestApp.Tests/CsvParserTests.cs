using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = string.Empty;

        // Act 
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(Array.Empty<string>()));

    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "a";
        string[] expected = { "a" };

        // Act 
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "ad,hb";
        string[] expected = { "ad", "hb" };

        // Act 
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = " a d,h   b    ";
        string[] expected = { "a d", "h   b" };

        // Act 
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
